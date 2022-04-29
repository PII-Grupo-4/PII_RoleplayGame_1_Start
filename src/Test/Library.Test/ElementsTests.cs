using NUnit.Framework;
using System.Collections.Generic;

namespace RoleplayGame_1_start.Test
{
    public class ElementsTests
    {
        // Test para chequear correcto funcionamiento de la clase Sword
        [Test]
        public void SpellBook()
        {
            Spell spell = new Spell("Supadupa");
            Assert.AreEqual(spell.GetSpell, "Supadupa");

            SpellBook spellBook = new SpellBook("SupaBooka");
            spellBook.AddSpell(spell);
            Assert.AreEqual(spell.GetSpell, "Supadupa");
            List<Spell> ListForTest = new List<Spell>();
            ListForTest.Add(spell);
            Assert.AreEqual(spellBook.GetSpells, ListForTest);
        }
    }
}