using NUnit.Framework;
using RoleplayGame_1_start;

namespace Test.Library
{

    [TestFixture]
    public class DwarveTests
    {

        [Test]
        public void DwarveAttack()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            int expected = 90;
            Assert.AreEqual(dwarveTest.GetDamage(), expected);
        }
        [Test]
        public void DwarveDefense()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            int expected = 30;
            Assert.AreEqual(dwarveTest.GetDefense(), expected);
        }

    }


}