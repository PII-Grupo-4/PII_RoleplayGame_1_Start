using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    // Se decidio crear la clase Spell, ya que SpellBook pose la responsabilidad de conocer los
    // los hechizos, pero si le agregamos la responsabilidad a su vez de crear los hechizos, en el caso
    // que en un futuro quieramos agregar otros tipos de hechizos, le estaríamos agregando una responsabilidad
    // (causa de cambio extra). Por lo tanto, para respetar el SRP terminamos creando Spell.
    public class Spell
    {
        private string TheSpell{get; set;}

        public Spell(string spell)
        {
            this.TheSpell = spell;
        }

        public string GetSpell
        {
            get
            {
                return this.TheSpell;
            }
        }

    }
}