using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{
    class Presenter
    {
        private readonly IMainForm view;
        private IPlayer player;
        private IPlayer computerPlayer;

        public Presenter(IMainForm form, IPlayer player, IPlayer compPlayer)
        {
            this.view = form;
            this.player = player;
            this.computerPlayer = compPlayer;
            this.player.Attacker = true;
            this.computerPlayer.Attacker = false;

            view.HeadClick += view_HeadClick;
            view.BodyClick += view_BodyClick;
            view.LegsClick += view_LegsClick;

            this.player.Wound += player_Wound;
            this.computerPlayer.Wound += player_Wound;

            
            this.player.Death += player_Death;            
            this.computerPlayer.Death += player_Death;

            this.player.Block += player_Block;
            this.computerPlayer.Block += player_Block;

            view.NewValueViewPlayer(player.Name, player.Hp);
            view.NewValueViewComp(computerPlayer.Name, computerPlayer.Hp);
            view.buttonText("Attack ");
        }

        void player_Block(object sender, PlayerEventArgs e)
        {
            view.LstBox = e.name+": удар блокирован";
        }

        void player_Death(object sender, PlayerEventArgs e)
        {
            view.LstBox = e.name + ": убит :(";
        }      

        void player_Wound(object sender, PlayerEventArgs e)
        {
            string typePlayer = sender.GetType().ToString();

            if (typePlayer.Equals("CombatClub.Player"))
                view.lblSetHpPlayer(e.Hp);
            else
                if (typePlayer.Equals("CombatClub.ComputerPlayer"))
                {
                    view.lblSetHpComp(e.Hp);
                }

            view.LstBox = e.name + ": нанесен урон";
        }

        void view_HeadClick(object sender, EventArgs e)
        {
            ChangePartBody(BodyParts.head);
        }

        void view_BodyClick(object sender, EventArgs e)
        {
            ChangePartBody(BodyParts.body);
        }

        void view_LegsClick(object sender, EventArgs e)
        {
            ChangePartBody(BodyParts.legs);
        }

        void ChangePartBody(BodyParts bodyPart)
        {
            if (player.Attacker)
            {
                computerPlayer.SetBlock(bodyPart);
                computerPlayer.GetHit(bodyPart);
                // 
                if (player != null && computerPlayer != null)
                {
                    player.Attacker = false;
                    computerPlayer.Attacker = true;
                    view.buttonText("Block");                    
                }
            }
            else
            {
                if (computerPlayer.Attacker)
                {
                    player.SetBlock(bodyPart);
                    player.GetHit(computerPlayer.ReturnAttackPartBody());
                    if (player != null && computerPlayer != null)
                    {
                        player.Attacker = true;
                        computerPlayer.Attacker = false;
                        view.buttonText("Attack");                        
                    }
                }
            }
        }

        

    }
}

