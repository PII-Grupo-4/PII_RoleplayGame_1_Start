using System;
using RoleplayGame_1_start;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarves dwarve1 = new Dwarves("Dwarve1");
            Dwarves dwarve2 = new Dwarves("Dwarve2");
            Items hammer = new Items("Hammer",50,0);
            Items table = new Items("Table",0,50);

            dwarve1.Attack(dwarve2);
            dwarve1.GetInfo();
            Console.WriteLine();

            dwarve1.Add_Element(hammer);
            dwarve1.Add_Element(table);
            dwarve1.GetInfo();
            Console.WriteLine();

            dwarve1.Receives_Attack(dwarve2);
            dwarve2.Remove_Element(hammer);
            dwarve1.Remove_Element(hammer);

            Console.WriteLine();
            Wizard wizard1 = new Wizard("Wizard1");
            Wizard wizard2 = new Wizard("Wizard2");
            wizard1.RecieveAttack(wizard2.GetDamage);
        }
    }
}
