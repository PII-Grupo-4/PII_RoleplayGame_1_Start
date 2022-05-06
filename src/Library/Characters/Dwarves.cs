using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Dwarves
    {

        private string name { get; set; }
        private int hp { get; set; }
        private int attack { get; set; }
        private int defense { get; set; }
        private int hammerAdded = 0;
        private int tableAdded = 0;
        private List<Hammer> ListHammer = new List<Hammer>();
        private List<Table> ListTable = new List<Table>();

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
                    this.hp = this.GetHP() - (EnemyAttack - this.GetDefense());
                    if(this.GetHP() <=0)
                    {
                        this.hp = 0;
                        Console.WriteLine($"{this.name} died.");
                    }
                    else
                    {
                    Console.WriteLine($"{this.name} have {this.GetHP()} HP after the attack");
                    }
                }
            }

        }


        public void Add_Hammer(Hammer hammer)
        {
            this.attack = this.GetDamage() + hammer.GetDamage();
            Console.WriteLine($"{hammer.GetName()} was added .");
            ListHammer.Add(hammer);
            hammerAdded = 1;
        }

        public void Remove_Hammer(Hammer hammer)
        {
            if (hammerAdded == 1 && ListHammer.Contains(hammer))
            {
                this.attack = this.GetDamage() - hammer.GetDamage();
                ListHammer.Remove(hammer);
                Console.WriteLine($"{hammer.GetName()} was removed.");
                hammerAdded = 0;

            }
            else
            {
                Console.WriteLine($"Character {this.name} doesn't have a {hammer.GetName()} ");
            }

        }
        public void Add_Table(Table table)
        {
            this.defense = this.GetDefense() + table.GetDefense();
            ListTable.Add(table);
            Console.WriteLine($"{table.GetName()} was added .");
            tableAdded = 1;
        }

        public void Remove_Table(Table table)
        {
            if (tableAdded == 1 && ListTable.Contains(table))
            {
                this.defense = this.GetDefense() - table.GetDefense();
                ListTable.Remove(table);
                Console.WriteLine($"{table.GetName()} was removed.");
                tableAdded = 0;

            }
            else
            {
                Console.WriteLine($"Character {this.name} doesn't have a {table.GetName()} ");
            }

        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {this.name} \nAttack: {this.GetDamage()} \nDefense: {this.GetDefense()}\nHP: {this.GetHP()}");
        }
        public int GetDamage()
        {
            return this.attack;
        }
        public int GetDefense()
        {
            return this.defense;
        }
        public int GetHP()
        {
            return this.hp;
        }

        public void Heal()
        {
            this.hp = 200;
        }
    }
}