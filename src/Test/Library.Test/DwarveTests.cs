using NUnit.Framework;
using RoleplayGame_1_start;

namespace Test.Library
{

    [TestFixture]
    public class DwarveTests
    {

        [Test]
        public void DwarveAttackTest()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            int expected = 90;
            Assert.AreEqual(dwarveTest.GetDamage(), expected);
        }
        [Test]
        public void DwarveDefenseTest()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            int expected = 30;
            Assert.AreEqual(dwarveTest.GetDefense(), expected);
        }
        // [Test]
        // public void Remove_ElementTest()
        // {
        //     Dwarves dwarveTest = new Dwarves("DwarveTest");
        //     Items hammerTest = new Items("Hammer",50,0);
        //     dwarveTest.Add_Element(hammerTest);
        //     dwarveTest.Remove_Element(hammerTest);
        // }

    }


}