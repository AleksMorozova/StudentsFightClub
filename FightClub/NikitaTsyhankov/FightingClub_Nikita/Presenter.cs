using GameProcess;
using GameProcess.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public class Presenter
    {
        private readonly MainForm _view;
        private readonly Logic _process;
        private readonly FileManager _manager;

        public Presenter(MainForm _view, Logic _process, FileManager _manager)
        {
            this._process = _process;
            this._view = _view;
            this._manager = _manager;
            _process.Player1.Name = _view.NamePlayer1;
            _view.NameCPUPlayer = _process.Player2.Name;
            Suscribe();

            UpdateStats();
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
            _view.Log = e.Name + "is dead!";
            string winner = (sender == _process.Player1) ? _process.Player2.Name : _process.Player1.Name;
            MessageBox.Show(e.Name + " is dead!", winner + " win!", MessageBoxButtons.OK);
            _manager.SaveLog(_view.Log);
            _view.BlockGame(winner);
        }

        private void _view_AddLogInfoWound(object sender, EventArgsFighter e)
        {
            _view.Log = e.Name + " taked damage! Now he has " + e.HP;
        }

        private void _view_AddLogInfoBlock(object sender, EventArgsFighter e)
        {
            _view.Log = e.Name + " blocked attack!";
        }
        #endregion

        private void Suscribe()
        {
            _view.ButHeadClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);
            _view.ButBodyClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);
            _view.ButLegClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);

            _process.Player1.Block += new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.Player1.Wound += new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.Player1.Death += new EventHandler<EventArgsFighter>(_view_EndGame);

            _process.Player2.Block += new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.Player2.Wound += new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.Player2.Death += new EventHandler<EventArgsFighter>(_view_EndGame);
        }
        private void UpdateStats()
        {
            _view.HPPlayers(_process.Player1.HealthPoints,
                _process.Player2.HealthPoints);
            _view.Rounds = _process.Round;
            _view.Title = (_process.Round % 2 == 0) ? true : false;
        }
    }
}
