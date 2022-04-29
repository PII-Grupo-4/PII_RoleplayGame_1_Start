namespace RoleplayGame_1_start
{
    public class Sword
    {
        private int Defense { get; set; }
        private string Name { get; set; }
        

        public Sword(string name, int defense)
        {
            this.Name = name;
            this.Defense = defense;
        }

        public int GetDefense
        {
            get
            {
                return this.Defense;
            }
        }
        public string GetName
        {
            get
            {
                return this.Name;
            }
        }
    }
}