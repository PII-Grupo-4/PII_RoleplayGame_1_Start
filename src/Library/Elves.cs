using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Elves
    {
        //DEFINICIÓN DE ATRIBUTOS/VARIABLES (GETERS Y SETTERS)
        public string Name {get; private set;}

        public int Attack {get; private set;}

        public int Defense {get; private set;}

        public int Hp {get; private set;}

        public int Damage {get;set;}

        //Contendrá todos los elementos que posea el personaje.
        private List<Object> ItemsElves {get; set;}
        List<Object> itemsElves = new List<Object>();

        //MÉTODO CONSTRUCTOR
        //Definimos todos los personajes con vida (Hp) inicial de 100
        //Cada Elve iniciará con 10 de ataque y 10 de defensa
        public Elves (string name)
        {
            this.Name = name;
            this.Attack = 10;
            this.Defense = 10;
            this.Hp = 100; //puntos de vida del personaje (heals point)
            this.ItemsElves = itemsElves; //lista de elementos de los items que tiene el personaje
        }

        //MÉTODOS DEL PERSONAJE         
        //Recibe_Attack corresponde al método donde el personaje es atacado
        //El método se llama desde el personaje atacado y no desde el personaje que ataca
        public void GetInfo()
        {
            Console.WriteLine($"Name: {this.Name} \nAttack: {this.Attack} \nDefense: {this.Defense}\nHP: {this.Hp}\nItem Quantity: {this.ItemsElves.Count}");
        }
        public void Receives_Attack (int dmg) 
        {
            Damage = this.Defense - dmg; //Variable para utilización en la siguiente condicional
            if (this.Hp > 0) //Evalua los HP del personaje para ser atacado
            {
                Console.WriteLine($"The Elve is attacked for {Damage} damage");
                if (Damage < 0)
                {
                    if (this.Hp + Damage <= 0)
                    {
                        this.Hp = 0;
                        Console.WriteLine ($"The Elve {this.Name} died");
                    }
                    else
                    {
                        this.Hp = this.Hp + Damage;
                        Console.WriteLine ($"The Elve {this.Name} have {this.Hp} HP");
                    }
                }
                else
                {
                    Console.WriteLine("Defense is superior to attack, it didn't cause any damage");
                }
            }
            else //si el personaje no tiene puntos de vida (HP) no es atacado
            {
                Console.WriteLine ($"The Elve {this.Name} is dead");
            }
        }
        public void AddItems(BagofRocks bagofRocks) //añade BagofRocks al personaje y actualiza sus atributos Attack y Defense
        {
            this.ItemsElves.Add(bagofRocks);
            this.Defense += bagofRocks.GetDefense();
            this.Attack += bagofRocks.GetDamage();  
        }
        public void AddItems(Helmet helmet) //añade Helmet al personaje y actualiza sus atributos Attack y Defense
        {
            this.ItemsElves.Add(helmet);
            this.Defense += helmet.GetDefense();
            this.Attack += helmet.GetDamage();
        }

        public void RemoveElement(BagofRocks bagofRocks) //Quita bagofrocks al personaje y actualiza los atributos Attack y Defense
        {
            this.ItemsElves.Remove(bagofRocks);
            this.Defense -= bagofRocks.GetDefense();
            this.Attack -= bagofRocks.GetDamage(); 
        }
        public void RemoveElement(Helmet helmet) //Quita helmet al personaje y actualiza los atributos Attack y Defense
        {
            this.ItemsElves.Remove(helmet);
            this.Defense -= helmet.GetDefense();
            this.Attack -= helmet.GetDamage(); 
        }
        public void Heal()
        {
            this.Hp = 100;
        }
    }
}