using NUnit.Framework;

namespace RoleplayGame_1_start.Test
{
    public class SpellAndSpellBook
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