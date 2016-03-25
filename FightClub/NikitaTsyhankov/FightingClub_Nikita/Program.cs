using GameProcess;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
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

            MainForm form = new MainForm();
            Logic game = new Logic();
            LogManager log = new LogManager();

            Presenter presenter = new Presenter(form, game, log);

            Application.Run(form);
        }
    }
}
