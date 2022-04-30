using System.Collections.Generic;
using System;

namespace RoleplayGame_1_start{
    public class Warrior{

        public int hp;

        private int defense;

        private int attack;

        private Shield shield;

        private Armor armor;

        private List<Armor> ListArmor = new List<Armor>();
        private List<Shield> ListShield = new List<Shield>();

        public Warrior(string name)
        {
            this.Defense = 50;
            this.Hp = 100;
            this.attack = 10;
            this.Name = name;
        }

        public int Defense{get;private set;}

        public int Attack{get;private set;} 

        public int Hp{get;private set;} 

        public string Name{get;private set;}

        public void GetInfo(){
            Console.WriteLine($"Name: {this.Name} \nAttack: {this.attack} \nDefense: {this.defense}\nHP: {this.Hp}\nItem Quantity: {this.ListArmor.Count + this.ListShield.Count}");
        }

        public void Heal()
        {
            this.Hp = 100;
        }


        public void Add_Shield(Shield item)
        {
            shield = item;
            if (ListShield.Contains(shield))
            {
                Console.WriteLine($"{this.Name} already has this item");
            }
            else
            {
                this.defense = this.defense + shield.GetDefense();
                Console.WriteLine($"{shield.GetName()} was added .");
            }
                
        }
        public void Add_Armor(Armor item)
        {
            armor = item;
            if (ListArmor.Contains(armor))
            {
                Console.WriteLine($"{this.Name} already has this item");
            }
            else
            {
                this.defense = this.defense + item.GetDefense();
                Console.WriteLine($"{item.GetName()} was added .");

            }
                
        }


        public void Remove_Armor(Armor item)
        {
            armor = item;
            if(ListArmor.Contains(armor))
            {
                ListArmor.Remove(armor);
                this.defense = this.defense - armor.GetDefense();
                Console.WriteLine($"{item.GetName()} was removed.");
            }
            else
            {
                Console.WriteLine($"Character {this.Name} doesn't have this item ");
            }

        }
        public void Remove_Shield(Shield item)
        {
            shield = item;
            if(ListShield.Contains(shield))
            {
                ListShield.Remove(shield);
                this.defense = this.defense - item.GetDefense();
                Console.WriteLine($"{item.GetName()} was removed.");
            }
            else
            {
                Console.WriteLine($"Character {this.Name} doesn't have this item ");
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