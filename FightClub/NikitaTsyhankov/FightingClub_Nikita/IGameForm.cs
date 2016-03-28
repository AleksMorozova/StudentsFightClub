using GameProcess.BL.Fighters;
using System;

namespace FightingClub_Nikita
{
    public interface IGameForm
    {
        string NamePlayer1
        {
            get;
            set;
        }
        string NameCPUPlayer
        {
            set;
        }
        bool Title
        {
            set;
        }
        int Rounds
        {
            get;
            set;
        }
        string Log
        {
            get;
            set;
        }
        void HPPlayers(int player1, int player2);
        void BlockGame(string _winner);
        event EventHandler<EventArgsBodyParts> ButHeadClick;
        event EventHandler<EventArgsBodyParts> ButBodyClick;
        event EventHandler<EventArgsBodyParts> ButLegClick;
        event EventHandler ButLoadGameClick;
        event EventHandler ButSaveGameClick;

    }
}
