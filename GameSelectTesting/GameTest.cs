using System;
using NUnit.Framework;

namespace GameSelect.Test
{
    [TestFixture]
    public class TestingGame
    {
        EnemyClass en = new EnemyClass();

        [Test]
        public void TestEnemyMethodEqual()
        {
            Assert.AreEqual(2, 2);
        }
        public void TestEnemyMethodNotEqual()
        {
            Assert.AreNotEqual(2, 3);
        }
    }
}