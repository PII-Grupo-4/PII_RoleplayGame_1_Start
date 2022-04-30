using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Orc
    {
        private string Name {get; set;}
        private int Attack {get;set;}
        private int Defense {get;set;}
        private int HP {get;set;}
        
        List<Bow> BowList = new List<Bow>();
        List<Mask> MaskList = new List<Mask>();

        public Orc (string name)
        {
        this.Name = name;
        this.Defense = 50;
        this.Attack = 25;
        this.HP = 100;
        }
        

        public void Receives_Attack(int EnemyAttack)
        {
        this.HP=this.HP-(this.Defense-EnemyAttack);
        if (this.HP<=0)
        {
            this.HP=0;
            Console.WriteLine ($"The Orc {this.Name} has died");

        }
        else
        {
            this.HP=this.HP;
            Console.WriteLine ($"After the attack, the Orc {this.Name} have {this.HP} HP");
        }
        }

         public void AddBow(Bow bow)
        {
            this.BowList.Add(bow);
            this.Defense = this.Defense+ Bow.GetDefense();
            this.Attack = this.Attack + Bow.GetDamage();
            Console.WriteLine($"The Bow {Bow.GetName()} was added.");
        }

        public void AddMask(Mask mask)
        {
            this.MaskList.Add(mask);
            this.Defense = this.Defense + Bow.GetDefense();
            this.Attack= this.Attack + Bow.GetDamage();
            Console.WriteLine($"The mask {Mask.GetName()} was added");
        }
        
        
        public void RemoveBow(Bow bow)
        {
            if(BowList.Count >= 1)
            {
                BowList.Remove(bow);
                this.Attack = this.Attack - Bow.GetDamage();
                this.Defense = this.Defense - Bow.GetDefense();
                Console.WriteLine($"{Bow.GetName()} was removed.");
            }
            else{
                Console.WriteLine($"Orc {this.Name} doesn't have any Bows ");
            }
        }
        public void RemoveMask(Mask mask)
        {
            if(MaskList.Count >= 1)
            {
                MaskList.Remove(mask);
                this.Attack = this.Attack - Mask.GetDamage();
                this.Defense = this.Defense - Mask.GetDefense();
                Console.WriteLine($"{Mask.GetName()} was removed.");
            }
            else
            {
                Console.WriteLine($"Orc {this.Name} doesn't have any Masks ");
            }
        }
         public int GetDamage()
        {
            return this.Attack;
        }
        public int GetDefense()
        {
            return this.Defense;
        }
        public int GetHP()
        {
            return this.HP;
        }

    }

}