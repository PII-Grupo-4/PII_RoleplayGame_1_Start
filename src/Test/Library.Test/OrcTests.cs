using NUnit.Framework;
using System.Collections.Generic;

namespace RoleplayGame_1_start.Test
{
     [TestFixture]
    public class OrcTests
    {

        [Test0]
        public void Orcdie() // si el Attack del enemy es mayor a 150
        {
           Orc orcTest = new Orc("OrcTest");
            orcTest.Receives_Attack(150);
            int expected =0;
            Assert.AreEqual(orcTest.GetHP(), expected); 
        }

        [Test1]
        public void Receives_Attack()
        {
            Orc orcTest = new Orc("OrcTest");
            orcTest.Receives_Attack(30);
            int expected =80;
            Assert.AreEqual(orcTest.GetHP(), expected);
        }
        [Test2]
        public void AddBow()
        {
            Orc orcTest = new Orc("OrcTest");
            Bow bow = new Bow("Bow", 10);
            int total = Orc.Defense + bow.GetDefense();
            int expected=60;
            Assert.AreEqual(total, expected);
        }
        [Test3]
        public void AddMask()
        {
            Orc orcTest = new Orc("OrcTest");
            Mask mask = new Mask("Mask",15);
            int total = Orc.Defense + mask.GetDefense();
            int expected=65;
            Assert.AreEqual(total, expected);
        }
        [Test4]
        public void RemoveBow()
        {
            Orc orcTest = new Orc("OrcTest");
            Bow bow = new Bow("Bow", 10);
            int total = Orc.Defense - bow.GetDefense();
            int expected=40;
            Assert.AreEqual(total, expected);
        }
        [Test5]
        public void RemoveMask()
        {
            Orc orcTest = new Orc("OrcTest");
            Mask mask = new Mask("Mask",15);
            int total = Orc.Defense - mask.GetDefense();
            int expected=35;
            Assert.AreEqual(total, expected);

        }
    }


}
    