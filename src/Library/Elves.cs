using System;

namespace RoleplayGame_1_start
{
    public class Elves
    {
        //Definimos todos los personajes con vida (Hp) inicial de 100
        //Cada Elve iniciará con 10 de ataque y 10 de defensa
        public Elves (string name)
        {
            this.Name = name;
            this.Attack = 10;
            this.Defence = 10;
            this.Hp = 100;
        }

        private string name;
        public string Name {get; private set;}

        public int Attack {get; private set;}

        public int Defence {get; private set;}

        public int Hp {get; private set;}

        private int Damage {get;set;}
        public void Recibe_Attack (int dmg)
        {
            Damage = this.Defence - dmg;

            if (this.Hp - Damage < 0)
            {
                this.Hp = 0;
                Console.WriteLine ($"El elfo {this.name} ha muerto");
            }
        }

    }
}