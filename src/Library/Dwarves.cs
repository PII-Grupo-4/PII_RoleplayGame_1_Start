using System.Collections.Generic;
using System;

namespace RoleplayGame_1_start{
    public class Dwarves{
        
        private string name {get; set;}
        private int hP {get; set;}
        private int attack {get; set;}
        private int defense {get; set;}

        List<Items> ListItems = new List<Items>();
        

        public Dwarves (string name)
        {
            this.name = name;
            this.hP = 200;
            this.attack = 90;
            this.defense = 30;
        }
        public void Attack(Dwarves enemy)
        {
                if(enemy.hP > 0){
                    enemy.hP = enemy.hP - this.attack;
                    Console.WriteLine($"{enemy.name} have {enemy.hP} HP after the attack");
                } 
            
        }

        public void Receives_Attack(Dwarves enemy)
        {
                if(this.hP > 0){
                    this.hP = this.hP - enemy.GetDamage();
                    Console.WriteLine($"{this.name} have {this.hP} HP after the attack");
                } 
            
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

        public void GetInfo(){
            Console.WriteLine($"Name: {this.name} \nAttack: {this.attack} \nDefense: {this.defense}\nHP: {this.hP}\nItem Quantity: {this.ListItems.Count}");
        }
        public int GetDamage()
        {
            return this.attack;
        }
        public int GetDefense()
        {
            return this.defense;
        }
        public int Gethp()
        {
            return this.hP;
        }

        
    }
}