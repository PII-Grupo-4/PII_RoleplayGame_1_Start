namespace RoleplayGame_1_start
{
    public class Mask
    {
    private int defense { get; set; }
    private string Name { get; set; }
    
    public Mask(string Name, int defense)
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