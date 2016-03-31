using System;

namespace FightClubLogic
{
    [Serializable]
    public class CPUFighter : Fighter
    {
        private Random rng = new Random();
        public CPUFighter(string name, int maxHP, int damage) : base(name, maxHP, damage) { }
        public CPUFighter(string name, int maxHP, int damage, string imagePath) : base(name, maxHP, damage, imagePath) { }
        public void SetBlock()
        {
            base.SetBlock(this.GenerateBodyPart());
        }
        public BodyPart GenerateBodyPart()
        {
            int totalBodyParts = Enum.GetValues(typeof(BodyPart)).Length;
            return (BodyPart)rng.Next(0, totalBodyParts);
        }
    }
}
