using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatClub
{
    static class Controller
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();           
            Player player = new Player("valera", 3);
            Player compPlayer = new ComputerPlayer("comp", 33);
            Presenter presente = new Presenter(mainForm, player, compPlayer);            
                      
            Application.Run(mainForm);            
            
        }

    }
}
