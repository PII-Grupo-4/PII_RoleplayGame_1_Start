namespace RoleplayGame_1_start
{
    public class Hammer
    {
        private int attack { get; set; }
        private string Name { get; set; }
        

        public Hammer(string Name, int attack)
        {
            this.Name = Name;
            this.attack = attack;
        }

        public int GetDamage()
        {
            return this.attack;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}