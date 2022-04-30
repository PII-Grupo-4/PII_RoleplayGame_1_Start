using NUnit.Framework;
using RoleplayGame_1_start;

namespace Test.Library
{

    [TestFixture]
    public class ElvesTests
    {

        [Test]
        //Test de método recibir ataque
        public void Receives_AttackTest()
        {
            Elves elfo1 = new Elves("Elfo 1");
            elfo1.Receives_Attack(100);
            int expected = 90;
            Assert.AreEqual(elfo1.GetHp(), expected);
        }
        [Test]
        //Test de que el personaje muere
        public void DiedTest()
        {
            Elves elfo1 = new Elves("Elfo 1");
            elfo1.Receives_Attack(1000);
            int expected = 0;
            Assert.AreEqual(elfo1.GetHp(), expected);
        }
        [Test]
        //Elfo cura a otro personaje
        public void Cura_Personaje()
        {
            Elves elfo1 = new Elves("Elfo 1");
            Dwarves dwarves1 = new Dwarves("Dwarves 1");
            dwarves1.Receives_Attack(90);
            int expected = 10;
            Assert.AreEqual(dwarves1.GetHP(), expected);
            elfo1.Heal_Dwarves(dwarves1);
            int expected2 = 100;
            Assert.AreEqual(dwarves1.GetHP(), expected2);
        }
        [Test]
        //Test Agregar Items a un Elve
        public void AddItems(BagofRocks bag)
        {
            BagofRocks bag1 = new BagofRocks("BagofRocks", 50, 50);
            Elves elve1 = new Elves("Elfo 1");
            elve1.AddItems(bag1);
            int expected = 60;
            Assert.AreEqual(elve1.GetDamage(), expected);
            Assert.AreEqual(elve1.GetDefense(), expected);
        }

        [Test]
        //Test Remover Items a un Elve
        public void RemoveItems()
        {
            BagofRocks bag1 = new BagofRocks("BagofRocks", 50, 50);
            Elves elve1 = new Elves("Elfo 1");
            elve1.AddItems(bag1);
            int expected = 60;
            Assert.AreEqual(elve1.GetDamage(), expected);
            Assert.AreEqual(elve1.GetDefense(), expected);
            elve1.RemoveElement(bag1);
            int expected1 = 10;
            Assert.AreEqual(elve1.GetDamage(), expected1);
            Assert.AreEqual(elve1.GetDefense(), expected1);
        }
    }
}