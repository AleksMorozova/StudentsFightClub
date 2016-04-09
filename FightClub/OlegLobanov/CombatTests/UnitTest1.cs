using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Combats;
using System.Diagnostics;

namespace CombatTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InitialisationTest()
        {
            Combats.Player first = new Combats.Player("f1", 100, 1000);
            Combats.CompPlayer second = new Combats.CompPlayer("f2", 100, 1000);

            Controller contr = new Controller(first, second);

            Assert.AreEqual(first, contr.human);
            Assert.AreEqual(second, contr.comp);
            Assert.AreEqual(contr.Round, 1);
            Assert.AreEqual(contr.phase, Phase.First);
        }

        [TestMethod]
        public void TickTest()
        {
            Combats.Player first = new Combats.Player("f1", 100, 1000);
            Combats.CompPlayer second = new Combats.CompPlayer("f2", 100, 1000);

            Controller contr = new Controller(first, second);

            contr.Tick(BodyPart.Head);
            Assert.AreEqual(contr.Round, 1);
            Assert.AreEqual(contr.phase, Phase.Second);

            contr.Tick(BodyPart.Head);
            Assert.AreEqual(contr.Round, 2);
            Assert.AreEqual(contr.phase, Phase.First);
        }

        
        [TestMethod]
        public void DMGTest()
        {
            Combats.Player first = new Combats.Player("f1", 100, 1000);
            Combats.CompPlayer second = new Combats.CompPlayer("f2", 100, 1000);

            Controller contr = new Controller(first, second);

            contr.human.GetHit(contr.human.Blocked, 50);
            Assert.AreEqual(contr.human.HP, 100);

            contr.human.GetHit(BodyPart.Head, 50);
            Assert.AreEqual(contr.human.HP, 50);

            contr.human.GetHit(BodyPart.Head, 100);
            Assert.AreEqual(contr.human.HP, 0);
        }

        // Тесты для Player
        [TestMethod]
        public void CorrectValuesTest()
        {
            Combats.Player first = new Combats.Player("f1", 100, 1000);
            Assert.AreEqual(first.Blocked, BodyPart.Head);

            first.SetBlock((BodyPart)3);
            Assert.AreEqual(first.Blocked, BodyPart.Legs);
            Assert.AreEqual(first.Name, "f1");
            Assert.AreEqual(first.HP, first.MaxHP);
            Assert.AreEqual(first.Damage, 1000);
        }

        [TestMethod()]
        public void HitTest()
        {
            Player first = new Player("f1", 150, 16);
            first.SetBlock(BodyPart.Head);

            first.GetHit(BodyPart.Head, 10);
            Assert.AreEqual(first.HP, 15);

            first.GetHit(BodyPart.Body, 10);
            Assert.AreEqual(first.HP, 5);

            first.GetHit(BodyPart.Legs, 16);
            Assert.AreEqual(first.HP, 0);
        }

        [TestMethod()]
        public void SetBlockTest()
        {
            Player first = new Player("f1", 150, 16);

            
            Assert.AreEqual(first.Blocked, BodyPart.Head);

            first.SetBlock(BodyPart.Body);
            Assert.AreEqual(first.Blocked, BodyPart.Body);

            first.SetBlock(BodyPart.Legs);
            Assert.AreEqual(first.Blocked, BodyPart.Legs);
        }

        [TestMethod()]
        public void EventsTest()
        {
            Player first = new Player("f1", 150, 16);

            bool[] tests = new bool[3];
            first.Block += (Player sender) =>
            {
                tests[0] = true;
            };
            first.Wound += (Player sender) =>
            {
                tests[1] = true;
            };
            first.Death +=(Player sender) =>
            {
                tests[2] = true;
            };


            first.GetHit(BodyPart.Head, 5);
            Assert.AreEqual(tests[0], true);
            first.GetHit(BodyPart.Body, 5);
            Assert.AreEqual(tests[1], true);
            first.GetHit(BodyPart.Body, 500);
            Assert.AreEqual(tests[2], true);


        }

    }
}
