using FightClubLogic;

namespace ISD.FightClub
{
    public interface IPresenter
    {
        Battle Battle { get; }
        ILoggable Log { get; } 
        void Action(BodyPart bodyPart);
        void LoadBattle(IPresenter presenter);
        void ResetBattle(Fighter fighter1, Fighter fighter2);
    }
}
