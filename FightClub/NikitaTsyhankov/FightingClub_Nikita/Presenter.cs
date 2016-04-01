using GameProcess.BL;
using GameProcess.BL.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    [Serializable]
    public class Presenter
    {
        private IFighting _process;
        [NonSerialized]
        private readonly IGameForm _view;
        private readonly IManager _manager;

        public Presenter(IGameForm _view, IFighting _process, IManager _manager)
        {
            this._process = _process;
            this._view = _view;
            this._manager = _manager;
            _process.Player1.Name = _view.NamePlayer1;
            _view.NameCPUPlayer = _process.Player2.Name;
            SuscribeForm();
            SuscribeBattle();

            UpdateStats();
        }

        #region Forms' events
        private void _view_BodyPartClick(object sender, EventArgsBodyParts e)
        {
            _process.MakeStep(e.Part);
            UpdateStats();
        }
        private void _manager_SaveGame(object sender, EventArgs e)
        {
            _manager.SaveGame(_process);
        }
        private void _manager_LoadGame(object sender, EventArgs e)
        {
            IFighting _loadedGame = _manager.LoadGame();
            if (_loadedGame != null)
            {
                _process = _loadedGame;
                _view.NamePlayer1 = _process.Player1.Name;
                _view.NameCPUPlayer = _process.Player2.Name;
                _view.UnblockGame();
                _view.ClearLog();
                foreach (string item in _process.Log)
                {
                    _view.Log = item;
                }
                SuscribeBattle();
                UpdateStats();
            }
        }
        #endregion

        #region Logics' events
        private void _view_EndGame(object sender, EventArgsFighter e)
        {
            UnsuscribeBattle();

            _view.Log = e.Name + " is dead!";
            _view.Log = "Fight over in " + _process.Round + " rounds";
            _view.Log = "*Log saved*. Log saved to the root directory.";
            string winner = (sender == _process.Player1) ? _process.Player2.Name : _process.Player1.Name;
            MessageBox.Show(e.Name + " is dead!", winner + " win!", MessageBoxButtons.OK);
            _manager.SaveLog(_process.Log);
            _view.BlockGame(winner);
        }

        private void _view_AddLogInfoWound(object sender, EventArgsFighter e)
        {
            _view.Log = e.Name + " taked damage! Now he has " + e.HP;
            _process.AddToLog(e.Name + " taked damage! Now he has " + e.HP);
        }

        private void _view_AddLogInfoBlock(object sender, EventArgsFighter e)
        {
            _view.Log = e.Name + " blocked attack!";
            _process.AddToLog(e.Name + " blocked attack!");
        }
        #endregion

        private void SuscribeForm()
        {
            _view.ButHeadClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);
            _view.ButBodyClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);
            _view.ButLegClick += new EventHandler<EventArgsBodyParts>(_view_BodyPartClick);
            _view.ButLoadGameClick += new EventHandler(_manager_LoadGame);
            _view.ButSaveGameClick += new EventHandler(_manager_SaveGame);
        }
        private void SuscribeBattle()
        {
            _process.Player1.Block += new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.Player1.Wound += new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.Player1.Death += new EventHandler<EventArgsFighter>(_view_EndGame);

            _process.Player2.Block += new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.Player2.Wound += new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.Player2.Death += new EventHandler<EventArgsFighter>(_view_EndGame);
        }
        private void UnsuscribeBattle()
        {
            _process.Player1.Block -= new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.Player1.Wound -= new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.Player1.Death -= new EventHandler<EventArgsFighter>(_view_EndGame);

            _process.Player2.Block -= new EventHandler<EventArgsFighter>(_view_AddLogInfoBlock);
            _process.Player2.Wound -= new EventHandler<EventArgsFighter>(_view_AddLogInfoWound);
            _process.Player2.Death -= new EventHandler<EventArgsFighter>(_view_EndGame);
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
