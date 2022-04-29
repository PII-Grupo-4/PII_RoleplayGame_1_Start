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
        List<Items> ListItems = new List<Items>();

        public Orc (string name)
        {
        this.Name = name;
        this.Defense = 30;
        this.Attack = 45;
        this.HP = 100;
        }
        public void Attack_Enemy(Orc enemy)
        {
        enemy.HP= enemy.HP-(enemy.Defense-this.Attack);
        if (enemy.HP<0)
            {
            enemy.HP=0;
            }
        else
            {
            enemy.HP=enemy.HP;
            }
        }

        public void Enemy_Attack(Orc enemy)
        {
        this.HP=this.HP-(this.Defense-enemy.Attack);
        if (this.HP<0)
        {
            this.HP=0;
        }
        else
        {
            this.HP=this.HP;
        }
        }

         
        public void AddElement(Items item)
        {
                ListItems.Add(item);
                this.Attack = this.Attack + item.GetDamage();
                this.Defense = this.Defense + item.GetDefense();
                Console.WriteLine($"{item.GetName()} was added .");
        }

        public void RemoveElement(Items item)
        {
            if(ListItems.Count >= 1){
                ListItems.Remove(item);
                this.Attack = this.Attack - item.GetDamage();
                this.Defense = this.Defense - item.GetDefense();
                Console.WriteLine($"{item.GetName()} was removed.");
            }
            else{
                Console.WriteLine($"Character {this.Name} doesn't have items ");
            }

            
           

        }

    }

}