using NUnit.Framework;
using System.Collections.Generic;

namespace RoleplayGame_1_start.Test
{
    [TestFixture]
    public class WizardTests
    {
        private SpellBook spellBook0;
        private Sword sword0;
        private Wizard wizard0;
        private Wizard wizard1;

        [SetUp]
        public void SetUp()
        {
            Spell spell = new Spell("Supadupa");
            spellBook0 = new SpellBook("SupaBooka");
            spellBook0.AddSpell(spell);

            sword0 = new Sword("Swipi", 0, 20);

            wizard0 = new Wizard("Wizirta");

            wizard1 = new Wizard("Wizir");
            wizard1.AddSword(sword0);
        }


        // El test SpellBookToWizard verifica que el SpellBook se agrega correctamente, modificando
        // con eficacia los atributos correspondientes. También se testea la función UpdateSpellBook
        [Test]
        public void SpellBookToWizard()
        {
            Assert.AreEqual(wizard0.GetDamage, 50);
            Assert.AreEqual(wizard0.GetDefense, 25);

            // Agrego SpellBook
            wizard0.AddSpellBook(spellBook0);
            Assert.AreEqual(wizard0.GetDamage, (50+10));
            Assert.AreEqual(wizard0.GetDefense, (25+5));

            // Agrego Hechizo y actualizo el SpellBook
            Spell spell1 = new Spell("barabaralu");
            wizard0.AddSpellToWizardBook(spellBook0, spell1);
            Assert.AreEqual(wizard0.GetDamage, (60+10));
            Assert.AreEqual(wizard0.GetDefense, (30+5));

            // Elimino Hechizo y actualizo el SpellBook
            wizard0.RemoveSpellToWizardBook(spellBook0, spell1);
            Assert.AreEqual(wizard0.GetDamage, (70-10));
            Assert.AreEqual(wizard0.GetDefense, (35-5));

            // Elimino un SpellBook
            wizard0.RemoveSpellBook(spellBook0);
            Assert.AreEqual(wizard0.GetDamage, (60-10));
            Assert.AreEqual(wizard0.GetDefense, (30-5));


            //  Vuelvo a Eliminar el mismo SpellBook (como no se elimina, ya que no está, 
            //      debe dar los mismo valores que el anterior)
            wizard0.RemoveSpellBook(spellBook0);
            Assert.AreEqual(wizard0.GetDamage, (60-10));
            Assert.AreEqual(wizard0.GetDefense, (30-5));

        }

        // Testeo el comportamiento de recibir un ataque
        // Damage de wizard1 = 50(defauld) + 20(Sword)
        // Hp de wizard0 = 100(default)
        // Defensa de wizard0 = 25(default) + 5(SpellBook con 1 Spell)
        // Daño recibido por wizard0 = 100 - (70 - 30) = 60
        [Test]
        public void RecieveAttackTest()
        {
            wizard0.AddSpellBook(spellBook0);
            Assert.AreEqual(wizard1.GetDamage, 70);
            Assert.AreEqual(wizard0.GetHP, 100);
            Assert.AreEqual(wizard0.GetDefense, 30);

            wizard0.RecieveAttack(wizard1.GetDamage);
            Assert.AreEqual(wizard0.GetHP, 60);

            // Volvemos a atacar dos veces para matarlo
            wizard0.RecieveAttack(wizard1.GetDamage);
            wizard0.RecieveAttack(wizard1.GetDamage);
            Assert.AreEqual(wizard0.GetHP, 0);
        }
        
    }
}