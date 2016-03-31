using FightClubLogic;

namespace ISD.FightClub
{
    class MortalCombatCreator : Creator
    {
        public override CPUFighter CreateCPUFighter()
        {
            return new CPUFighter("Noob Saibot", 30, 5, "resources/noobsaibot.png");
        }
        public override Fighter CreateFighter()
        {
            return new Fighter("Scorpion", 15, 10, "resources/scorpion.png");
        }
    }
}
