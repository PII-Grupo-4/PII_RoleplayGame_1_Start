namespace RoleplayGame_1_start
{
    public class Table
    {
        private int defense { get; set; }
        private string name { get; set; }
        

        public Table(string name, int defense)
        {
            this.name = name;
            this.defense = defense;
        }
        public int GetDefense()
        {
            return this.defense;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}