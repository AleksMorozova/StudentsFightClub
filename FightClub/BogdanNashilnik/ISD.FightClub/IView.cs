using System.Windows.Forms;

namespace ISD.FightClub
{
    public interface IView
    {
        void SetBindings(BindingSource bondingSource);
        void EndGame(string winnerName);
        IPresenter Presenter { get; set; }
    }
}
