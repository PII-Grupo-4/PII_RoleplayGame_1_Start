using System.Collections.Generic;
using System;

namespace RoleplayGame_1_start{
    public class Warrior{

        private int Hp;

        private int defense;

        private int attack;

        private string name;
        List<Items> ListItems = new List<Items>();

        public Warrior(string name)
        {
            this.Defense = 50;
            this.Hp = 100;
            this.Attack = 10;
            this.Name = name;
        }

        public int Defense{get;private set;}

        public int Attack{get;private set;} 

        public string Name{get;private set;}

        public void GetInfo(){
            Console.WriteLine($"Name: {this.name} \nAttack: {this.attack} \nDefense: {this.defense}\nHP: {this.Hp}\nItem Quantity: {this.ListItems.Count}");
        }


        public void Add_Element(Items item)
        {
            ListItems.Add(item);
                this.attack = this.attack + item.GetDamage();
                this.defense = this.defense + item.GetDefense();
                Console.WriteLine($"{item.GetName()} was added .");
        }

        public void Remove_Element(Items item)
        {
            if(ListItems.Count >= 1){
                ListItems.Remove(item);
                this.attack = this.attack - item.GetDamage();
                this.defense = this.defense - item.GetDefense();
                Console.WriteLine($"{item.GetName()} was removed.");
            }
            else{
                Console.WriteLine($"Character {this.name} doesn't have items ");
            }

        }

        public void Receives_Attack(int rattack)
        {
            if (this.Hp == 0)
            {
                Console.WriteLine($"{this.Name} is dead");
            }
            else if(this.Hp - (rattack - this.defense) <= 0)
            {
                this.Hp = 0;
                Console.WriteLine($"{this.Name} died.");
                 
            }
            else
            {
                this.Hp = this.Hp - (rattack - this.defense);
                Console.WriteLine($"{this.Name} have {this.Hp} HP after the attack");
            }
            

        }

        
    }
}