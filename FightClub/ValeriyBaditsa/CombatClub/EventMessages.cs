using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{
    partial class Game
    {
        protected void OnBlockMessage(object sender, PlayerEventArgs args)
        {
            lstBox.Items.Add(args.name + ": удар заблокирован. ");
            PrintToLabel(sender);
        }

        protected void OnWoundMessage(object sender, PlayerEventArgs args)
        {
            lstBox.Items.Add(args.name + ": получен урон");
            PrintToLabel(sender);
        }

        protected void OnDeathMessage(object sender, PlayerEventArgs args)
        {
            lstBox.Items.Add(args.name + "ваш игрок убит :(");
            PrintToLabel(sender);
        }
    }
}
