namespace RoleplayGame_1_start
{
    public class BagofRocks
    {
        private int Attack { get; set; }
        private string Name { get; set; }
        private int Defense { get; set; }
        

        public BagofRocks (string name, int attack, int defense)
        {
            this.Name = name;
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