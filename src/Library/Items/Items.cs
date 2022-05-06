namespace RoleplayGame_1_start
{
    public class Items
    {
        private int Attack { get; set; }
        private int Defense { get; set; }
        private string Name { get; set; }
        

        public Items(string Name, int attack, int defense)
        {
            this.Name = Name;
            this.Attack = attack;
            this.Defense = defense;
        }

        public int GetDamage()
        {
            return this.Attack;
        }
        public int GetDefense()
        {
            return this.Defense;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}