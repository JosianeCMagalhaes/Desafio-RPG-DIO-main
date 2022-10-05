namespace Projeto_RPG.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType) : base (Name, level, HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name = " Used magic.";
        } 

        public string Attack(int Bonus) {

            if (Bonus > 6) {
                return this.Name + " Used Super effective magic with attack bonus of " + Bonus;

            } else {
                return this.Name + " Used weak magic with bonus of " + Bonus; 
            }
        }
    }
}