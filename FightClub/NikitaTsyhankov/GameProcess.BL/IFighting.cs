using GameProcess.BL.Fighters;

namespace GameProcess.BL
{
    public interface IFighting
    {
        Player Player1
        {
            get;
        }
        CPUPlayer Player2
        {
            get;
        }
        int Round
        {
            get;
        }
        void MakeStep(BodyParts _part);
    }
}
