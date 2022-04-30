namespace RoleplayGame_1_start
{
    public class Hammer
    {
        private int Attack { get; set; }
        private string Name { get; set; }
        

        public Hammer(string name, int attack)
        {
            this.Name = name;
            this.Attack = attack;
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