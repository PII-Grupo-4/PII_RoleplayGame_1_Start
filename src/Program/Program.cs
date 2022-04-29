using System;
using RoleplayGame_1_start;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------------------------------------------------------------*/
            //Dwarves
            Dwarves dwarve1 = new Dwarves("Dwarve1");
            Dwarves dwarve2 = new Dwarves("Dwarve2");
            Hammer hammer = new Hammer("Hammer", 50);
            Hammer hammer2 = new Hammer("Hammer2", 50);
            Table table = new Table("Table", 50);

            dwarve1.GetInfo();
            Console.WriteLine();

            dwarve1.Add_Hammer(hammer);
            dwarve1.Add_Table(table);
            Console.WriteLine();

            dwarve1.GetInfo();
            Console.WriteLine();

            dwarve1.Remove_Hammer(hammer2);
            dwarve2.Remove_Hammer(hammer);
            dwarve1.Remove_Hammer(hammer);

            dwarve1.Receives_Attack(100);
            dwarve1.Receives_Attack(300);

            /*----------------------------------------------------------------------------------------------*/
            // Wizard
            Console.WriteLine();
            Wizard wizard1 = new Wizard("Wizard1");
            Wizard wizard2 = new Wizard("Wizard2");
            wizard1.RecieveAttack(wizard2.GetDamage);

            /*----------------------------------------------------------------------------------------------*/
            //Warrior
            Warrior warrior1 = new Warrior("WarriorPlayer1");
            Warrior warrior2 = new Warrior("WarriorPlayer2");
            Items shield = new Items("GodShield", 1, 110);
            Items armor = new Items("Rookie Fragile Armor", 0, 5);

            warrior1.Add_Element(shield);
            warrior1.Add_Element(armor);
            warrior1.GetInfo();
            Console.WriteLine();

            warrior1.Receives_Attack(warrior2.Attack);
            warrior2.Remove_Element(armor);
            warrior1.Remove_Element(shield);
        }
    }
}
