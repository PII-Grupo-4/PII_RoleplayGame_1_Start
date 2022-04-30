namespace RoleplayGame_1_start
{
    public class Mask
    {
    private int Defense { get; set; }
    private string Name { get; set; }

    private int Damage {get;set;}
    
    public Mask(string Name, int defense, int damage)
        {
        this.Name = Name;
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