using FightClubLogic;

namespace ISD.FightClub
{
    abstract class Creator
    {
        public abstract CPUFighter CreateCPUFighter();
        public abstract Fighter CreateFighter();
        public static Fighter CreateFighter(string name, int maxHP, int damage)
        {
            return new Fighter(name, maxHP, damage);
        }
        public static Fighter CreateFighter(string name, int maxHP, int damage, string imagePath)
        {
            return new Fighter(name, maxHP, damage, imagePath);
        }
    }
}
