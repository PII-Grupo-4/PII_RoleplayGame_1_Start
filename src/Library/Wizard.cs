using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Wizard
    {
        private string Name { get; set;}
        private int HP { get; set;} // Puntos de vida
        private int Defense { get; set;} // Puntos de defensa
        private int Attack { get; set;} // Puntos de Ataque

        // ItemsWizard contendrá todos los elementos que posea el personaje.
        private List<Object> ItemsWizard {get; set;}
        List<Object> itemsWizard = new List<Object>();
        
        public Wizard (string name)
        {
            this.Name = name;
            this.Defense = 25;
            this.Attack = 50;
            this.HP = 100;
            this.ItemsWizard = itemsWizard;
        }

        public int GetDamage
        {
            get
            {
                return this.Attack;
            }
        }

        public int GetDefense
        {
            get
            {
                return this.Defense;
            }
        }

        public void AddElement(Items item)
        {
            this.ItemsWizard.Add(item);
            this.Defense += item.GetDefense();
            this.Attack += item.GetDamage();  
        }

        public void RemoveElement(Items item)
        {
            this.ItemsWizard.Remove(item);
            this.Defense -= item.GetDefense();
            this.Attack -= item.GetDamage(); 
        }

        public void RecieveAttack(int AttackEnemy)
        {
            if (this.HP > 0)
            {
                if(this.Defense >= AttackEnemy)
                {
                    this.HP =- (AttackEnemy - this.Defense);
                    if (this.HP <= 0)
                    {
                        this.HP = 0;
                        Console.WriteLine($"{this.Name} died.");
                    }
                    else
                    {
                        Console.WriteLine($"{this.Name} have {this.HP} HP after the attack");
                    }  
                } 
                else
                {
                    Console.WriteLine($"{this.Name} have {this.HP} HP after the attack");
                }
            }
            else
            {
                Console.WriteLine($"{this.Name} is dead.");
            }
        }
    }
}