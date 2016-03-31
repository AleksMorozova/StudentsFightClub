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

            player = new Player(playerName, 20);
            computerPlayer = new ComputerPlayer(compName, 30);

            player.Block += new EventHandler<PlayerEventArgs>(OnBlockMessage);
            computerPlayer.Block += new EventHandler<PlayerEventArgs>(OnBlockMessage);

            player.Wound += new EventHandler<PlayerEventArgs>(OnWoundMessage);
            computerPlayer.Wound += new EventHandler<PlayerEventArgs>(OnWoundMessage);

            player.Death += new EventHandler<PlayerEventArgs>(OnDeathMessage);
            computerPlayer.Death += new EventHandler<PlayerEventArgs>(OnDeathMessage);

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

    }
}
