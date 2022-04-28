using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Wizard
    {
        private string Name { get; set;}
        private int HP { get; set;}
        private int Defense { get; set;}
        private int Attack { get; set;}

        // ItemsWizard contendrá todos los items.
        List<Object> ItemsWizard = new List<Object>();
        
        public Wizard (string name)
        {
            this.Name = name;
            this.Defense = 25;
            this.Attack = 50;
            this.HP = 100;
            this.ItemsWizard = ItemsWizard;
        }

        public void AddItem(Items item)
        {
            this.ItemsWizard.Add(item);
            this.Defense += item.GetDefense();
            this.Attack += item.GetDamage();  
        }

        public void RemoveItem(Items item)
        {
            this.ItemsWizard.Remove(item);
            this.Defense -= item.GetDefense();
            this.Attack -= item.GetDamage(); 
        }
    }
}