using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FightClubLogic.Tests
{
    [TestClass()]
    public class FighterTests
    {
        [TestMethod()]
        public void FighterTest()
        {
            Fighter fighter = new Fighter("123", 15, 5);
            Assert.AreEqual(fighter.HP, 15);
            Assert.AreEqual(fighter.MaxHP, 15);
            Assert.AreEqual(fighter.Damage, 5);
            Assert.AreEqual(fighter.Name, "123");

            fighter = new Fighter("123", -10, -5);
            Assert.AreEqual(fighter.HP, 1);
            Assert.AreEqual(fighter.MaxHP, 1);
            Assert.AreEqual(fighter.Damage, 0);
            Assert.AreEqual(fighter.Name, "123");
        }

        [TestMethod()]
        public void FighterTest1()
        {
            Fighter fighter = new Fighter("123", 15, 5, "a.txt");
            Assert.AreEqual(fighter.HP, 15);
            Assert.AreEqual(fighter.MaxHP, 15);
            Assert.AreEqual(fighter.Damage, 5);
            Assert.AreEqual(fighter.Name, "123");
            Assert.AreEqual(fighter.ImagePath, "a.txt");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "Урон должен быть неотрицательным параметром.")]
        public void GetHitTestBasedOnDamage()
        {
            Fighter fighter = new Fighter("123", 15, 0);

            fighter.GetHit(BodyPart.Body, 10);
            Assert.AreEqual(fighter.HP, 5);

            fighter = new Fighter("123", 15, 0);
            fighter.GetHit(BodyPart.Body, 0);
            Assert.AreEqual(fighter.HP, 15);


            fighter = new Fighter("123", 15, 0);
            fighter.GetHit(BodyPart.Body, 1000);
            Assert.AreEqual(fighter.HP, 0);

            fighter = new Fighter("123", 15, 0);
            fighter.GetHit(BodyPart.Body, -5);
        }

        [TestMethod()]
        public void GetHitTestBasedOnBodyPart()
        {
            Fighter fighter = new Fighter("123", 15, 0);
            fighter.SetBlock(BodyPart.Head);

            fighter.GetHit(BodyPart.Head, 1);
            Assert.AreEqual(fighter.HP, 15);

            fighter.GetHit(BodyPart.Body, 1);
            Assert.AreEqual(fighter.HP, 14);

            fighter.GetHit(BodyPart.Legs, 1);
            Assert.AreEqual(fighter.HP, 13);
        }

        [TestMethod()]
        public void SetBlockTest()
        {
            Fighter fighter = new Fighter("123", 15, 0);

            fighter.SetBlock(BodyPart.Head);
            Assert.AreEqual(fighter.Blocked, BodyPart.Head);

            fighter.SetBlock(BodyPart.Body);
            Assert.AreEqual(fighter.Blocked, BodyPart.Body);

            fighter.SetBlock(BodyPart.Legs);
            Assert.AreEqual(fighter.Blocked, BodyPart.Legs);
        }

        #region event_test
        [TestMethod()]
        public void EventBlockEventRecievedTest()
        {
            Fighter fighter = new Fighter("123", 15, 0);
            fighter.SetBlock(BodyPart.Head);
            bool eventRecieved = false;

            fighter.Block += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };
            fighter.GetHit(BodyPart.Head, 5);
            Assert.AreEqual(eventRecieved, true);
        }

        [TestMethod()]
        public void EventBlockEventNotRecievedTest()
        {
            Fighter fighter = new Fighter("123", 15, 0);
            fighter.SetBlock(BodyPart.Head);
            bool eventRecieved = false;
            fighter.Block += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };

            fighter.GetHit(BodyPart.Body, 5);
            Assert.AreEqual(eventRecieved, false);

            eventRecieved = false;
            fighter.GetHit(BodyPart.Legs, 5);
            Assert.AreEqual(eventRecieved, false);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
         "Урон должен быть неотрицательным параметром.")]
        public void EventWoundEventRecievedTest()
        {
            Fighter fighter = new Fighter("123", 15, 0);
            fighter.SetBlock(BodyPart.Head);
            bool eventRecieved = false;
            fighter.Wound += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };

            fighter.GetHit(BodyPart.Body, 5);
            Assert.AreEqual(eventRecieved, true);

            eventRecieved = false;
            fighter.GetHit(BodyPart.Body, -10);
            Assert.AreEqual(eventRecieved, false);

            eventRecieved = false;
            fighter.GetHit(BodyPart.Body, 0);
            Assert.AreEqual(eventRecieved, true);

            eventRecieved = false;
            fighter.GetHit(BodyPart.Body, 1000);
            Assert.AreEqual(eventRecieved, true);
        }

        [TestMethod()]
        public void EventWoundEventNotRecievedTest()
        {
            Fighter fighter = new Fighter("123", 15, 0);
            fighter.SetBlock(BodyPart.Head);
            bool eventRecieved = false;
            fighter.Wound += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };

            fighter.GetHit(BodyPart.Head, 5);
            Assert.AreEqual(eventRecieved, false);
        }
        [TestMethod()]
        public void EventDeathEventRecievedTest()
        {
            Fighter fighter = new Fighter("123", 15, 0);
            fighter.SetBlock(BodyPart.Head);
            bool eventRecieved = false;
            fighter.Death += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };

            fighter.GetHit(BodyPart.Body, 1000);
            Assert.AreEqual(eventRecieved, true);
        }

        [TestMethod()]
        public void EventDeathEventNotRecievedTest()
        {
            Fighter fighter = new Fighter("123", 15, 0);
            fighter.SetBlock(BodyPart.Head);
            bool eventRecieved = false;
            fighter.Death += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };

            fighter.GetHit(BodyPart.Body, 5);
            Assert.AreEqual(eventRecieved, false);
        }
        #endregion event_test
    }
}