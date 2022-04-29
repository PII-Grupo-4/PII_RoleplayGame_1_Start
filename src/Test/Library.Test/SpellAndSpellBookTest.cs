using NUnit.Framework;
using System.Collections.Generic;

namespace RoleplayGame_1_start.Test
{
    public class SpellAndSpellBookTests
    {
        // Chequeamos que las clases Spell and SpellBook funcionan correctamente
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