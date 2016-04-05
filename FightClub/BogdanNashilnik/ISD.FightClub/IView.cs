using FightClubLogic;

namespace ISD.FightClub
{
    public interface IView
    {
        void InitializeGUI(Fighter fighter1, Fighter fighter2);
        void EndGame(Fighter winner);
    }
}
