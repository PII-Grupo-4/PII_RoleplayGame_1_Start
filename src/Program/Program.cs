using System;
using RoleplayGame_1_start;

namespace Program
{
    class Program
    {
        /* 
        #Parte 3
            - Obtener el valor total de ataque de un personaje.
            - Obtener el valor total de defensa de un personaje.
                Para obtener los valores totales de defensa y ataque totales de los personajes decidimos utilizar 
                métodos getters dentro de cada clase. Los totales están formados por la suma de los atributos
                de los personajes y los atributos de los elementos.
            - Atacar a un personaje (disminuir su vida en cierta cantidad)
                Para atacar a un personaje (disminuir la vida), decidimos que sea un método de la clase que
                recibe el ataque, ya que la misma se verá modificada, teniendo el daño del personaje que ataca
                como parámetro. Para obtener el daño total de un personaje, como se nombro anteriormente, utilizamos
                un método get. Decidimos tomar esta desición porque para realizarla necesitamos saber 3 datos (daño, 
                vida y defensa) y modificar 1 o ninguno(vida), la clase que recibe el daño conoce 2 y puede modificar
                con libertad la vida, por lo tanto es la más experta para relizar la responsabilidad. Para remendar
                su desconocimiento utilizamos el getter.
            - Curar a un personaje (recuperar su vida inicial)
                En la parte de curar al personaje, decidimos crear un método en los personajes en el que se puedan
                curar a sí mismos.
        */
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

            /*----------------------------------------------------------------------------------------------*/
            //Orc

            /*----------------------------------------------------------------------------------------------*/
            //Elves
        }
    }
}
