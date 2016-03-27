using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatClub
{
    class Game
    {
        public Form form1;
        public Player player;
        public ComputerPlayer computerPlayer;
        public ListBox lstBox { get; set; }
        public Label labelPlayerName { get; set; }
        public Label labelCompName { get; set; }
        public Label labelPlayerHp { get; set; }
        public Label labelCompHp { get; set; }
        public ProgressBar barPlayer { get; set; }
        public ProgressBar barComp { get; set; }
        public Button b1 { get; set; }
        public Button b2 { get; set; }
        public Button b3 { get; set; }



        public Game(string playerName, string compName,
            ListBox listBox,
            Label labelPlayerName, Label labelCompName,
            Label labelPlayerHp, Label labelCompHp,
            Button b1, Button b2, Button b3, ProgressBar barPlayer, ProgressBar barComp)
        {

            player = new Player(playerName);
            computerPlayer = new ComputerPlayer(compName);
            this.lstBox = listBox;
            this.labelPlayerName = labelPlayerName;
            this.labelPlayerHp = labelPlayerHp;
            this.labelCompName = labelCompName;
            this.labelCompHp = labelCompHp;

            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;

            this.barComp = barComp;
            this.barPlayer = barPlayer;
            this.labelPlayerName.Text = this.player.Name;
            this.labelPlayerHp.Text = Convert.ToString(player.Hp);
            this.labelCompName.Text = this.computerPlayer.Name;
            this.labelCompHp.Text = Convert.ToString(computerPlayer.Hp);
            this.b1.Text = "Head attack";
            this.b2.Text = "Body attack";
            this.b3.Text = "Legs attack";

            this.barPlayer.Maximum = player.Hp;
            this.barComp.Maximum = computerPlayer.Hp;
            this.barPlayer.Value = player.Hp;
            this.barComp.Value = computerPlayer.Hp;
        }

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
        // удар заблокирован
        public void EventBlockLog(object sender, EventsArgs args)
        {
            lstBox.Items.Add(args.name + ": удар заблокирован. ");
            PrintToLabel(sender);
        }

        // получения урона
        public void EventWoundLog(object sender, EventsArgs args)
        {
            lstBox.Items.Add(args.name + ": получен урон");
            PrintToLabel(sender);
        }

        public void EventDeathLog(object sender, EventsArgs args)
        {
            lstBox.Items.Add(args.name + "ваш игрок убит :(");
            PrintToLabel(sender);
        }

        public void ChangeRoles(Player player)
        {
            if (player.Hp > 0)
            {
                GameProc();
            }
            else
            {
                player.DeathEvent(new EventsArgs(player.Name, player.Hp));
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
                    computerPlayer.BlockEvent(new EventsArgs(computerPlayer.Name, computerPlayer.Hp));
                }
                else
                    if (computerPlayer.Blocked != player.Attacked)
                    {
                        if (computerPlayer.Hp > 0)
                        {
                            computerPlayer.Hp--;
                            computerPlayer.WoundEvent(new EventsArgs(computerPlayer.Name, computerPlayer.Hp));
                        }
                        ChangeRoles(computerPlayer);
                    }
                    else
                        if (computerPlayer.Attacker)
                        {
                            player.SetBlock(bodyPart);
                            computerPlayer.GetHit();
                            if (player.Blocked == computerPlayer.Attacked)
                            {
                                player.BlockEvent(new EventsArgs(player.Name, player.Hp));
                            }
                            else
                                if (player.Blocked != computerPlayer.Attacked)
                                {
                                    if (player.Hp > 0)
                                    {
                                        player.Hp--;
                                        player.WoundEvent(new EventsArgs(player.Name, player.Hp));
                                    }
                                    else
                                        player.DeathEvent(new EventsArgs(player.Name, player.Hp));
                                }
                            ChangeRoles(player);
                        }
            }


        }
    }
}
