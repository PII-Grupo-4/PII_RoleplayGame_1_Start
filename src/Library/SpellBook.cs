using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class SpellBook
    {
        private string Name {get; set;}
        private List<Spell> Spells {get; set;}

        List<Spell> spells = new List<Spell>();

        public SpellBook(string NameBook)
        {
            this.Name = NameBook;
            this.Spells = spells;
        }
        // Detalle: Primero se debe crear el libro, y recien una vez creado se pueden agregar hechizos.
        public void AddSpell(Spell spell)
        {
            this.Spells.Add(spell);
        }

        public void RemoveSpell(Spell spell)
        {
            this.Spells.Remove(spell);
        }

        public List<Spell> GetSpells
        {
            get
            {
                return this.Spells;
            }
        }
    }
}