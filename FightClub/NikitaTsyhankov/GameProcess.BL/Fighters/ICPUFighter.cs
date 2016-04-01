namespace GameProcess.BL.Fighters
{
    public interface ICPUFighter: IFighter
    {
        BodyParts MakeHit();
        void MakeBlock();
    }
}
