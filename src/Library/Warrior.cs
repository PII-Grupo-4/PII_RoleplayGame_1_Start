using System;

namespace RoleplayGame_1_start{
    public class Warrior{

        private int Hp;

        private int defence;

        private int attack;

        private string name;

        public Warrior(string name)
        {
            this.Defence = 50;
            this.Hp = 100;
            this.Attack = 10;
            this.Name = name;
        }

        public int Defence{get;private set;}

        public int Attack{get;private set;} 

        public string Name{get;private set;}


        public void Add_Element()
        {
            if()
            {

            }
            else
            {

            }
        }

        public void Remove_Element()
        {

        }

        public void Recibe_Attack(int rattack)
        {
            if (this.Hp - (rattack - this.defence) < 0)
            {
                this.Hp = 0;
            }
            else
            {
                this.Hp = this.Hp - (rattack - this.defence);
            }
            

        }

        
    }
}