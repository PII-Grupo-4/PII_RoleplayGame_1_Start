using System.Collections.Generic;
using System;

namespace RoleplayGame_1_start
{
    public class Dwarves
    {

        private string name { get; set; }
        private int hp { get; set; }
        private int attack { get; set; }
        private int defense { get; set; }

        private List<Items> ListItems = new List<Items>();


        public Dwarves(string name)
        {
            this.name = name;
            this.hp = 200;
            this.attack = 90;
            this.defense = 30;
        }

        public void Receives_Attack(int EnemyAttack)
        {
            if (this.hp > 0)
            {
                if (EnemyAttack >= (this.GetDefense()))
                {
                    this.hp = this.hp - (EnemyAttack - this.GetDefense());
                    if(this.hp <=0)
                    {
                        this.hp = 0;
                        Console.WriteLine($"{this.name} died.");
                    }
                    else
                    {
                    Console.WriteLine($"{this.name} have {this.hp} HP after the attack");
                    }
                }
            }

        }


        public void Add_Element(Items item)
        {
            ListItems.Add(item);
            this.attack = this.GetDamage() + item.GetDamage();
            this.defense = this.GetDefense() + item.GetDefense();
            Console.WriteLine($"{item.GetName()} was added .");
        }

        public void Remove_Element(Items item)
        {
            if (ListItems.Count >= 1)
            {
                ListItems.Remove(item);
                this.attack = this.GetDamage() - item.GetDamage();
                this.defense = this.GetDefense() - item.GetDefense();
                Console.WriteLine($"{item.GetName()} was removed.");
            }
            else
            {
                Console.WriteLine($"Character {this.name} doesn't have items ");
            }

        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {this.name} \nAttack: {this.GetDamage()} \nDefense: {this.GetDefense()}\nHP: {this.hp}\nItem Quantity: {this.ListItems.Count}");
        }
        public int GetDamage()
        {
            return this.attack;
        }
        public int GetDefense()
        {
            return this.defense;
        }
    }
}