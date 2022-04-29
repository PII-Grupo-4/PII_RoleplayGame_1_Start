namespace RoleplayGame_1_start
{
    public class Sword
    {
        private string Name { get; set; }
        private int Defense { get; set; }
        private int Damage { get; set; }
        

        public Sword(string name, int defense, int damage)
        {
            this.Name = name;
            this.Defense = defense;
            this.Damage = damage; 
        }

        public string GetName
        {
            get
            {
                return this.Name;
            }
        }

        public int GetDefense
        {
            get
            {
                return this.Defense;
            }
        }

        public int GetDamage
        {
            get
            {
                return this.Damage;
            }
        }
    }
}