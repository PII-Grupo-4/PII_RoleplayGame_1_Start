using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Elves
    {
        //Definimos todos los personajes con vida (Hp) inicial de 100
        //Cada Elve iniciará con 10 de ataque y 10 de defensa
        public Elves (string name)
        {
            this.Name = name;
            this.Attack = 10;
            this.Defense = 10;
            this.Hp = 100;
            this.ItemsElves = itemsElves; //lista de elementos de los items que tiene el personaje
        }

        public string Name {get; private set;}

        public int Attack {get; private set;}

        public int Defense {get; private set;}

        public int Hp {get; private set;}

        private int Damage {get;set;}

        // Items ItemELves contendrá todos los elementos que posea el personaje.
        List<Object> ItemsElves {get; set;}

        List<Object> itemsElves = new List<Object>();
         
        //Recibe_Attack corresponde al método donde el personaje es atacado
        //El método se llama desde el personaje atacado y no desde el personaje que ataca
        public void Recibe_Attack (int dmg) 
        {
            Damage = this.Defense - dmg;
            if (this.Hp > 0)
            {
                if (this.Hp - Damage <= 0)
                {
                    this.Hp = 0;
                    Console.WriteLine ($"The Elve {this.Name} died");
                }
                else
                {
                    this.Hp = this.Hp - Damage;
                    Console.WriteLine ($"The Elve {this.Name} have {this.Hp} HP");
                }
            }
            else
            {
                Console.WriteLine ($"The Elve {this.Name} is dead");
            }
        }
        public void AddElement(Items item) //añade elementos al personaje y actualiza sus atributos Attack y Defense
        {
            this.ItemsElves.Add(item);
            this.Defense += item.GetDefense();
            this.Attack += item.GetDamage();  
        }

        public void RemoveElement(Items item) //Quita elementos al personaje y actualiza los atributos Attack y Defense
        {
            this.ItemsElves.Remove(item);
            this.Defense -= item.GetDefense();
            this.Attack -= item.GetDamage(); 
        }

    }
}