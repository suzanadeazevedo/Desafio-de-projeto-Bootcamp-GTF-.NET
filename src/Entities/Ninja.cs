namespace ProjetoRPG.src.Entities
{
    public class Ninja : Heroes
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com o seu poderoso golpe Mortal Kombat Fatality";
        }
    }
}