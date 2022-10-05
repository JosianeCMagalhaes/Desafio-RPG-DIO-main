namespace Projeto_RPG.src.entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int level, string HeroType) : base (Name, level, HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }  
    }
}