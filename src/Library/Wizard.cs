using System;
using System.Collections.Generic;

namespace RoleplayGame_1_start
{
    public class Wizard
    {
        private string Name { get; set;}
        private int HP { get; set;} // Puntos de vida
        private int Defense { get; set;} // Puntos de defensa
        private int Attack { get; set;} // Puntos de Ataque

        // ItemsWizard contendrá todos los elementos que posea el personaje.
        private List<Sword> SwordsList {get; set;}
        private List<SpellBook> SpellBooksList {get; set;}
        
        List<Sword> swordsList = new List<Sword>();
        List<SpellBook> spellBooksList = new List<SpellBook>();
        
        
        
        public Wizard (string name)
        {
            this.Name = name;
            this.Defense = 25;
            this.Attack = 50;
            this.HP = 100;
            this.SwordsList = swordsList;
            this.SpellBooksList = spellBooksList;
        }

        public int GetDamage
        {
            get
            {
                return this.Attack;
            }
        }

        public int GetDefense
        {
            get
            {
                return this.Defense;
            }
        }

        public void AddSword(Sword sword)
        {
            this.SwordsList.Add(sword);
            this.Defense += sword.GetDefense;
            this.Attack += sword.GetDamage;
            Console.WriteLine($"The Sword {sword.GetName} was added.");
        }

        public void RemoveSword(Sword sword)
        {
            if (SwordsList.Contains(sword))
            {
                this.SwordsList.Remove(sword);
                this.Defense -= sword.GetDefense;
                this.Attack -= sword.GetDamage;
                Console.WriteLine($"The Sword {sword.GetName} was eliminated.");
            }
            else
            {
                Console.WriteLine($"The Character {this.Name} doesn't have the sword {sword.GetName}.");
            }
        }

        public void AddSpellBook(SpellBook spellBook)
        {
            this.SpellBooksList.Add(spellBook);
            this.Defense += spellBook.GetDefense;
            this.Attack += spellBook.GetDamage;
            Console.WriteLine($"The Spell Book {spellBook.GetName} was added.");
        }

        public void RemoveSpellBook(SpellBook spellBook)
        {
            if (SpellBooksList.Contains(spellBook))
            {
                this.SpellBooksList.Remove(spellBook);
                this.Defense -= spellBook.GetDefense;
                this.Attack -= spellBook.GetDamage;
                Console.WriteLine($"The Spell Book {spellBook.GetName} was eliminated.");
            }
            else
            {
                Console.WriteLine($"The Character {this.Name} doesn't have the Spell Book {spellBook.GetName}.");
            }
        }

        // En el caso de que se agreguen Spells a un Spell Book, para que los atributos del Wizard se
        // actualizen es necesario utilizar el método UpdateSpellBook.
        public void UpdateSpellBook(SpellBook spellBook)
        {
            if (SpellBooksList.Contains(spellBook))
            {
                this.SpellBooksList.Remove(spellBook);
                this.Defense -= spellBook.GetDefense;
                this.Attack -= spellBook.GetDamage;
                
                this.SpellBooksList.Add(spellBook);
                this.Defense += spellBook.GetDefense;
                this.Attack += spellBook.GetDamage;
                Console.WriteLine($"The Spell Book {spellBook.GetName} was updated.");
            }
            else
            {
                Console.WriteLine($"The Character {this.Name} doesn't have the Spell Book {spellBook.GetName}.");
            }
        }

        public void RecieveAttack(int AttackEnemy)
        {
            if (this.HP > 0)
            {
                if(this.Defense >= AttackEnemy)
                {
                    this.HP =- (AttackEnemy - this.Defense);
                    if (this.HP <= 0)
                    {
                        this.HP = 0;
                        Console.WriteLine($"{this.Name} died.");
                    }
                    else
                    {
                        Console.WriteLine($"{this.Name} have {this.HP} HP after the attack");
                    }  
                } 
                else
                {
                    Console.WriteLine($"{this.Name} have {this.HP} HP after the attack");
                }
            }
            else
            {
                Console.WriteLine($"{this.Name} is dead.");
            }

        }

        public void Heal()
        {
            this.HP = 100;
        }
    }
}