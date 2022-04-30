using NUnit.Framework;
using System.Collections.Generic;

namespace RoleplayGame_1_start.Test
{
    public class ElementsTests
    {
        // Chequeamos que las clases Spell and SpellBook funcionan correctamente. En la última parte del test
        // verificamos que se cumpla el requisito de que el libro aumente su poder en base a cuantos hechizos
        // posea.
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
            Assert.AreEqual(spellBook.GetDamage, 10);
            Assert.AreEqual(spellBook.GetDefense, 5);
            spellBook.RemoveSpell(spell);
            Assert.AreEqual(spellBook.GetDamage, 0);
            Assert.AreEqual(spellBook.GetDefense, 0);
        }
        
    }
}