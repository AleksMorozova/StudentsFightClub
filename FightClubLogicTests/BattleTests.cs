using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FightClubLogic.Tests
{
    [TestClass()]
    public class BattleTests
    {
        [TestMethod()]
        public void BattleTest()
        {
            Fighter f1 = new Fighter("123", 15, 5);
            Fighter f2 = new Fighter("abc", 25, 10);
            Battle battle = new Battle(f1, f2);

            Assert.AreEqual(f1, battle.Fighter1);
            Assert.AreEqual(f2, battle.Fighter2);
            Assert.AreEqual(battle.Round, 1);
            Assert.AreEqual(battle.RoundHalf, RoundHalf.Attack);
        }

        [TestMethod()]
        public void ActionTest()
        {
            Fighter f1 = new Fighter("123", 15, 5);
            Fighter f2 = new Fighter("123", 15, 5);
            Battle battle = new Battle(f1, f2);

            battle.Action(BodyPart.Head, BodyPart.Body);
            Assert.AreEqual(battle.Fighter1.HP, 15);
            Assert.AreEqual(battle.Fighter2.HP, 10);
            Assert.AreEqual(battle.Round, 1);
            Assert.AreEqual(battle.RoundHalf, RoundHalf.Defend);

            battle.Action(BodyPart.Head, BodyPart.Head);
            Assert.AreEqual(battle.Fighter1.HP, 15);
            Assert.AreEqual(battle.Fighter2.HP, 10);
            Assert.AreEqual(battle.Round, 2);
            Assert.AreEqual(battle.RoundHalf, RoundHalf.Attack);
        }

        [TestMethod()]
        public void AttackCPUTest()
        {
            bool headGenerated = false;
            bool bodyGenerated = false;
            bool legsGenerated = false;
            do
            {
                Fighter f1 = new Fighter("123", 15, 5);
                Fighter f2 = new Fighter("123", 15, 5);
                Battle battle = new Battle(f1, f2);
                battle.AttackCPU(BodyPart.Head);
                if (battle.Fighter2.Blocked == BodyPart.Head)
                {
                    Assert.AreEqual(battle.Fighter2.HP, 15);
                    headGenerated = true;
                }
                else if (battle.Fighter2.Blocked == BodyPart.Body)
                {
                    Assert.AreEqual(battle.Fighter2.HP, 10);
                    bodyGenerated = true;
                } 
                else
                {
                    Assert.AreEqual(battle.Fighter2.HP, 10);
                    legsGenerated = true;
                }
            } while (!(headGenerated && bodyGenerated && legsGenerated));
        }

        [TestMethod()]
        public void EventsTest()
        {
            bool eventRoundRecieved = false;
            int eventHalfRecieved = 0;
            Fighter f1 = new Fighter("123", 15, 5);
            Fighter f2 = new Fighter("abc", 25, 10);
            Battle battle = new Battle(f1, f2);
            battle.RoundChanged += delegate (Battle sender)
            {
                eventRoundRecieved = true;
            };
            battle.RoundHalfChanged += delegate (Battle sender)
            {
                eventHalfRecieved++;
            };

            battle.Action(BodyPart.Body, BodyPart.Body);
            battle.Action(BodyPart.Body, BodyPart.Body);

            Assert.AreEqual(eventRoundRecieved, true);
            Assert.AreEqual(eventHalfRecieved, 2);
        }
    }
}