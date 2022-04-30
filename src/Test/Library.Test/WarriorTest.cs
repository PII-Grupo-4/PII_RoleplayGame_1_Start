using NUnit.Framework;
using RoleplayGame_1_start;

namespace Test.Library
{

    [TestFixture]
    public class WarriorTest
    {
        Warrior warriorT = new Warrior("Warrior_Test");

        [Test]
        public void Receives_AttackTest()
        {
            
            warriorT.Receives_Attack(100);
            int expected = 50;
            Assert.AreEqual(warriorT.Hp, expected);
        }
        public void Receives_AttackTestKill()
        {
            Warrior warriorT = new Warrior("Warrior_Test");
            warriorT.Receives_Attack(200);
            int expected = 0;
            Assert.AreEqual(warriorT.Hp, expected);
        }

        public void Add_ArmorTest()
        {
            Armor armor = new Armor("Armor_Test", 5);
            int defenseTest = warriorT.Defense + armor.GetDefense();
            warriorT.Add_Armor(armor);
            Assert.AreEqual(warriorT.Defense, defenseTest);
        }

        public void Add_DuplicateArmorTest()
        {
            Armor armor = new Armor("Armor_Test", 5);
            warriorT.Add_Armor(armor);
            int defenseTest = warriorT.Defense;
            warriorT.Add_Armor(armor);
            Assert.AreEqual(warriorT.Defense, defenseTest);
        }

        public void Remove_ArmorTest()
        {
            Armor armor = new Armor("Armor_Test", 5);
            warriorT.Add_Armor(armor);
            int defenseTest = warriorT.Defense;
            warriorT.Remove_Armor(armor);
            Assert.AreNotEqual(warriorT.Defense, defenseTest);
        }

        public void Remove_NotAddedArmorTest()
        {
            Armor armor = new Armor("Armor_Test", 5); 
            int defenseTest = warriorT.Defense;
            warriorT.Remove_Armor(armor);    
            Assert.AreEqual(warriorT.Defense, defenseTest);      

        }

        public void Add_ShieldTest()
        {
            Shield shield = new Shield("Shield_Test", 110);
            int defenseTest = warriorT.Defense + shield.GetDefense();
            warriorT.Add_Shield(shield);
            Assert.AreEqual(warriorT.Defense, defenseTest);


        }

        public void Add_DuplicateShieldTest()
        {
            Shield shield = new Shield("Shield_Test", 110);
            warriorT.Add_Shield(shield);
            int defenseTest = warriorT.Defense;
            warriorT.Add_Shield(shield);
            Assert.AreEqual(warriorT.Defense, defenseTest);


        }

        public void Remove_ShieldTest()
        {
            Shield shield = new Shield("Shield_Test", 110);
            warriorT.Add_Shield(shield);
            int defenseTest = warriorT.Defense;
            warriorT.Remove_Shield(shield);
            Assert.AreNotEqual(warriorT.Defense, defenseTest);
          
        }

        public void Remove_NotAddedShieldTest()
        {
            Shield shield = new Shield("Shield_Test", 110);
            int defenseTest = warriorT.Defense;
            warriorT.Remove_Shield(shield);
            Assert.AreEqual(warriorT.Defense, defenseTest);
          
        }
    }
}