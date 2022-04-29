using NUnit.Framework;
using RoleplayGame_1_start;

namespace Test.Library
{

    [TestFixture]
    public class DwarveTests
    {

        [Test]
        public void Receives_AttackTest()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            dwarveTest.Receives_Attack(100);
            int expected = 130;
            Assert.AreEqual(dwarveTest.GetHP(), expected);
        }

        [Test]
        public void DiedTest()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");

            dwarveTest.Receives_Attack(1000);
            int expected = 0;
            
            Assert.AreEqual(dwarveTest.GetHP(), expected);
        }
        [Test]
        public void Add_TableTest()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            Table table = new Table("Table", 50);

            dwarveTest.Add_Table(table);
            int expected = 80;

            Assert.AreEqual(dwarveTest.GetDefense(), expected);
        }
        [Test]
        public void Remove_TableTest()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            Table table = new Table("Table", 50);

            dwarveTest.Add_Table(table);
            dwarveTest.Remove_Table(table);
            int expected = 30;

            Assert.AreEqual(dwarveTest.GetDefense(), expected);
        }
        [Test]
        public void Add_HammerTest()
        {
            Hammer hammer = new Hammer("Hammer", 50);
            Dwarves dwarveTest = new Dwarves("DwarveTest");

            dwarveTest.Add_Hammer(hammer);
            int expected = 140;

            Assert.AreEqual(dwarveTest.GetDamage(), expected);
        }

        [Test]
        public void Remove_HammerTest()
        {
            Dwarves dwarveTest = new Dwarves("DwarveTest");
            Hammer hammer = new Hammer("Hammer", 50);

            dwarveTest.Add_Hammer(hammer);
            dwarveTest.Remove_Hammer(hammer);
            int expected = 90;

            Assert.AreEqual(dwarveTest.GetDamage(), expected);
        }
    }


}