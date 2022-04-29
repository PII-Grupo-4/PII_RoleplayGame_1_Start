using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class SpellBook
    {
        private string Name {get; set;}
        private int Defense { get; set; }
        private int Damage { get; set; }
        private List<Spell> Spells {get; set;}

        List<Spell> spells = new List<Spell>();

        public SpellBook(string NameBook)
        {
            this.Name = NameBook;
            this.Spells = spells;
            this.Defense = 0;
            this.Damage = 0;
        }
        // Detalle: Primero se debe crear el libro, y recien una vez creado se pueden agregar hechizos.
        public void AddSpell(Spell spell)
        {
            this.Spells.Add(spell);
            this.Damage += 10;
            this.Defense += 5;
        }

        public void RemoveSpell(Spell spell)
        {
            this.Spells.Remove(spell);
            this.Damage -= 10;
            this.Defense -= 5;
        }

        public List<Spell> GetSpells
        {
            get
            {
                return this.Spells;
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

        public string GetName
        {
            get
            {
                return this.Name;
            }
        }
    }
}