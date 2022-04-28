namespace RoleplayGame_1_start
{
    public class Armor
    {
        private int defense { get; set; }
        private string Name { get; set; }
        

        public Armor(string Name, int defense)
        {
            this.Name = Name;
            this.defense = defense;
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