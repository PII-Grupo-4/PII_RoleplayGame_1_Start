using NUnit.Framework;
using System.Collections.Generic;

namespace RoleplayGame_1_start.Test
{
     [TestFixture]
    public class OrcTests
    {

        [Test]
        public void Orcdie() // si el Attack del enemy es mayor a 150
        {
           Orc orcTest = new Orc("OrcTest");
            orcTest.Receives_Attack(150);
            int expected =0;
            Assert.AreEqual(orcTest.GetHP(), expected); 
        }

        [Test]
        public void Receives_Attack()
        {
            Orc orcTest = new Orc("OrcTest");
            orcTest.Receives_Attack(30);
            int expected =80;
            Assert.AreEqual(orcTest.GetHP(), expected);
        }
        [Test]
        public void AddBow()
        {
            Orc orcTest = new Orc("OrcTest");
            Bow bow = new Bow("Bow", 10,10);
            int total = orcTest.GetDefense() + bow.GetDefense();
            int expected=60;
            Assert.AreEqual(total, expected);
        }
        [Test]
        public void AddMask()
        {
            Orc orcTest = new Orc("OrcTest");
            Mask mask = new Mask("Mask",15,15);
            int total = orcTest.GetDefense() + mask.GetDefense();
            int expected=65;
            Assert.AreEqual(total, expected);
        }
        [Test]
        public void RemoveBow()
        {
            Orc orcTest = new Orc("OrcTest");
            Bow bow = new Bow("Bow", 10,10);
            int total = orcTest.GetDefense() - bow.GetDefense();
            int expected=40;
            Assert.AreEqual(total, expected);
        }
        [Test]
        public void RemoveMask()
        {
            Orc orcTest = new Orc("OrcTest");
            Mask mask = new Mask("Mask",15,15);
            int total = orcTest.GetDefense() - mask.GetDefense();
            int expected=35;
            Assert.AreEqual(total, expected);

        }
    }


}
    