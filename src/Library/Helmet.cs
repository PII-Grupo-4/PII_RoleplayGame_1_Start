namespace RoleplayGame_1_start
{
    public class Helmet
    {
        private int Defense { get; set;}
        private string Name { get; set;}

        private int Attack{ get; set;}       

        public Helmet (string name, int attack, int defense)
        {
            this.Name = name;
            this.Defense = defense;
            this.Attack = attack;
        }

        public int GetDefense()
        {
            return this.Defense;
        }
        public int GetDamage()
        {
            return this.Attack;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}