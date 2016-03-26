using GameProcess.Fighters;

namespace GameProcess
{
    public class Logic
    {
        public Player player1;
        public CPUPlayer player2;

        public int Round { get;  private set;}

        public Logic()
        {
            player1 = new Player("NoName", ConstantFields.basicHp);
            player2 = new CPUPlayer(ConstantFields.basicHp);

            Round = 0;
        }

        public void MakeStep(BodyParts _part)
        {
            if(Round % 2 == 0)
            {
                player2.MakeBlock();
                player2.GetHit(_part, ConstantFields.basicDamage);
            }
            else
            {
                player1.SetBlock(_part);
                player1.GetHit(player2.MakeHit(), ConstantFields.basicDamage);
            }
            Round++;
        }
    }
}
