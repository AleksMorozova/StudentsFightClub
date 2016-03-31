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
        public ComputerPlayer computerPlayer;
        

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

        public void ChangeRoles(Player player)
        {
            if (player.Hp > 0)
            {
                GameProc();
            }
            else
            {
                player.OnDeath();
                FinishGame();               
            }
        }

        public void FinishGame()
        {
            player = null;
            computerPlayer = null;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
        }

        public void GameProc()
        {
            if (player.Attacker == false)
            {
                player.Attacker = true;
                computerPlayer.Attacker = false;
                b1.Text = "Head attack";
                b2.Text = "Body attack";
                b3.Text = "Legs attack";
            }
            else
            {
                player.Attacker = false;
                computerPlayer.Attacker = true;
                b1.Text = "Block head";
                b2.Text = "Block body";
                b3.Text = "Block legs";
            }


        }

        public void LogicGame(BodyParts bodyPart)
        {
            if (player.Attacker)
            {
                computerPlayer.SetBlock();
                player.GetHit(bodyPart);
                if (computerPlayer.Blocked == player.Attacked)
                {
                    //computerPlayer.BlockEvent(new PlayerEventArgs(computerPlayer.Name, computerPlayer.Hp));
                    computerPlayer.OnBlock();
                    //computerPlayer.Name, computerPlayer.Hp
                    new PlayerEventArgs(computerPlayer.Name, computerPlayer.Hp);
                }
                else
                {
                    if (computerPlayer.Blocked != player.Attacked)
                    {
                        if (computerPlayer.Hp > 0)
                        {
                            computerPlayer.Hp--;
                            computerPlayer.OnWound();
                        }                        
                    }
                }
                ChangeRoles(computerPlayer);
            }       
            else          
            {
                if (computerPlayer.Attacker)
                {
                    player.SetBlock(bodyPart);
                    computerPlayer.GetHit();
                    if (player.Blocked == computerPlayer.Attacked)
                    {
                        //player.BlockEvent(new PlayerEventArgs(player.Name, player.Hp));
                        player.OnBlock();
                        //new PlayerEventArgs(player.Name, player.Hp)
                    }
                    else
                        if (player.Blocked != computerPlayer.Attacked)
                        {
                            if (player.Hp > 0)
                            {
                                player.Hp--;
                                player.OnWound();
                            }
                            else
                                player.OnDeath();
                        }
                    ChangeRoles(player);
                       
            }
        }            
    }
}
}
