using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatClub
{
    partial class Game
    {        
        public Player player;
        public Player computerPlayer;
        

        public void PrintToLabel(object sender)
        {
            string typePlayer = sender.GetType().ToString();
            if (typePlayer.Equals("CombatClub.Player"))
            {
                //labelPlayerName.Text = player.Name; // не обязательно
                labelPlayerHp.Text = Convert.ToString(player.Hp);
                barPlayer.Value = player.Hp;
            }
            else
                if (typePlayer.Equals("CombatClub.ComputerPlayer"))
                {
                    labelCompHp.Text = Convert.ToString(computerPlayer.Hp);
                    barComp.Value = computerPlayer.Hp;
                }
        }                
        

        public void LogicGame(BodyParts bodyPart)
        {
            if (player.Attacker)
            {
                computerPlayer.SetBlock(bodyPart);
                computerPlayer.GetHit(bodyPart);
                if (player != null && computerPlayer != null)
                {
                    player.Attacker = false;
                    computerPlayer.Attacker = true;
                    b1.Text = "Block head";
                    b2.Text = "Block body";
                    b3.Text = "Block legs";
                }
            }
            else
            {
                if (computerPlayer.Attacker)
                {
                    player.SetBlock(bodyPart);                    
                    player.GetHit(computerPlayer.ReturnAttackPartBody());
                    if (player != null && computerPlayer!=null)                        
                    {
                        player.Attacker = true;
                        computerPlayer.Attacker = false;
                        b1.Text = "Head attack";
                        b2.Text = "Body attack";
                        b3.Text = "Legs attack";

                    }
                }
            }
            
        }   
}
}
