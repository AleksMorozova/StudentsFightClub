using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CombatClub
{
    public interface IMainForm
    {      
        void lblSetHpPlayer(int hp);
        void lblSetHpComp(int hp);
        void NewValueViewPlayer(string name, int hp);
        void NewValueViewComp(string name, int hp);
        void setName(string namePlayer,  string nameComp);
        void buttonText(string text);
        string LstBox { set; }
        
        event EventHandler HeadClick;
        event EventHandler BodyClick;
        event EventHandler LegsClick;
    }
}

