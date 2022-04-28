using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Items
    {
        private int attack { get; set; }
        private int defense { get; set; }
        private string Name { get; set; }
        

        public Items(string Name, int attack, int defense)
        {
            this.Name = Name;
            this.attack = attack;
            this.defense = defense;
        }

        public int GetDamage()
        {
            return this.attack;
        }
        public int GetDefense()
        {
            return this.defense;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}