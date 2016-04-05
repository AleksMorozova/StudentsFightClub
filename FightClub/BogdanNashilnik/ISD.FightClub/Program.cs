using System;
using System.Windows.Forms;

namespace ISD.FightClub
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILoggable log = new Log();
            IView view = new FormView();
            Creator fighterCreator = new MortalCombatCreator();
            IPresenter presenter = new Presenter(view, log, fighterCreator.CreateFighter(), fighterCreator.CreateCPUFighter());
            Application.Run((FormView)view);
        }
    }
}
