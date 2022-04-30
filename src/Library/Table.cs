namespace RoleplayGame_1_start
{
    public class Table
    {
        private int Defense { get; set; }
        private string Name { get; set; }
        

        public Table(string name, int defense)
        {
            this.Name = name;
            this.Defense = defense;
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