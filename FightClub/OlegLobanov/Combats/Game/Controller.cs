using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Combats
{
   public delegate void GameStatusChanged();
    public delegate void SomethingWrittedToTheLog(string str);

    public enum Phase { First, Second }

    public class Controller:ILoggable
    {
       public Player human {get;private set;}
       public CompPlayer comp {get;private set;}


       public string status { get; private set; }
       public int Round{get;private set;}

       public Phase phase{get;private set;} 

       public event GameStatusChanged GameEnded;
       public event SomethingWrittedToTheLog Logged;

       StringBuilder log = new StringBuilder(1024);

       public Controller(Player human, CompPlayer enemy)
       {
           status="Игрок атакует...";
           StartGame(human, enemy);
       }
       public void StartGame(Player human,CompPlayer enemy)
       {
           this.human = human;
           this.comp = enemy;
           human.Death += Dead;
           comp.Death += Dead;

           human.Wound += Wounded;
           comp.Wound += Wounded;

           human.Block += Blocked;
           comp.Block += Blocked;
           Round = 1;
           phase = Phase.First;

           AddToLog("игра стартовала");
       }
       public void EndGame(Player winner)
       {
           status = "Победил игрок " + winner.Name + " за "+ Round.ToString() + " раундов!";
           AddToLog(status);

           SaveLog();
           if (GameEnded != null)
           {
               GameEnded();
           }
       }

       void Dead(Player sender)
       {
           AddToLog(sender.Name + " рассыпался на кусочки");
           if (sender.Equals(human))
           {
               EndGame(comp);
           }
           else
           {
               EndGame(human);
           }
       }
       void Wounded(Player sender)
       {
           AddToLog(sender.Name + " получает удар");
       }
       void Blocked(Player sender)
       {
           AddToLog(sender.Name + " заблокировал удар");
       }

        public void Tick(BodyPart userinput)
       {
           if (phase == Phase.First)
           {
               status = "Игрок защищается...";
               comp.EasyRandDefence();
               comp.GetHit(userinput, human.Damage);
               phase = Phase.Second;
               
           }
           else
           {
               status = "Игрок атакует...";
               human.SetBlock(userinput);
               human.GetHit(comp.EasyRandAttack(), comp.Damage);
               phase = Phase.First;

               Round++;
               
           }
           
       }
        public void AddToLog(string append)
        {
            if (Logged != null)
            {
                Logged(append);
            }

            log.Append(DateTime.Now.ToLongTimeString());
            log.Append("   ");
            log.Append(@append);
            log.AppendLine();
        }
        public void SaveLog()
        {
            log.AppendLine();
            
            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.Write(this.log);
                }
            }
        }

      

    }
}
