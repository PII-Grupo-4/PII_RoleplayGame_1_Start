namespace RoleplayGame_1_start
{
    public class Hammer
    {
        private int attack { get; set; }
        private string name { get; set; }
        

        public Hammer(string name, int attack)
        {
            this.name = name;
            this.attack = attack;
        }

        public int GetDamage()
        {
            return this.attack;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}