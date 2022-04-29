using NUnit.Framework;

namespace Test.Library
{
    public class SpellAndSpellBookTests
    {
        // Chequeamos que las clases Spell and SpellBook funcionan correctamente
        [Test]
        public void SpellBook()
        {
            Spell spell = new Spell("Supadupa");
            Assert.AreEqual(spell.GetSpell, "Supadupa");
        }

    }

}