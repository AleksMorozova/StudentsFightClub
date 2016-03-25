using GameProcess;
using GameProcess.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public class Presenter
    {
        private MainForm _view;
        private Logic _process;
        private LogManager _log;

        public Presenter(MainForm _view, Logic _process, LogManager _log)
        {
            this._process = _process;
            this._view = _view;
            this._log = _log;
            _process.player1.Name = _view.NamePlayer1;
            _view.NamePlayer2 = _process.player2.Name;
            Suscribe();

            UpdateStats();
        }

        private void Suscribe()
        {
            _view.ButHeadClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);
            _view.ButBodyClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);
            _view.ButLegClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);

            _process.player1.Block += new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.player1.Wound += new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.player1.Death += new EventHandler<EventArgsFighter>(_view_EndGame);

            _process.player2.Block += new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.player2.Wound += new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.player2.Death += new EventHandler<EventArgsFighter>(_view_EndGame);
        }
        private void UpdateStats()
        {
            _view.HPPlayers(_process.player1.HealthPoints,
                _process.player2.HealthPoints);
            _view.Rounds = _process.Round;
            _view.Title = (_process.Round % 2 == 0) ? true : false;
        }

        #region Forms' events
        private void _view_BodyPartClick(object sender, EventArgsBodyParts e)
        {
            _process.MakeStep(e._part);
            UpdateStats();
        }
        #endregion

        #region Logics' events
        private void _view_EndGame(object sender, EventArgsFighter e)
        {
            _view.AddLog = e.Name + "is dead!";
            string winner = (sender == _process.player1) ? _process.player2.Name : _process.player1.Name;
            MessageBox.Show(e.Name + " is dead!", winner + " win!", MessageBoxButtons.OK);
            _view.BlockGame(winner);
        }

        private void _view_AddLogInfoWound(object sender, EventArgsFighter e)
        {
            _view.AddLog = e.Name + " taked damage! Now he has " + e.HP;
        }

        private void _view_AddLogInfoBlock(object sender, EventArgsFighter e)
        {
            _view.AddLog = e.Name + " blocked attack!";
        }
        #endregion
    }
}
