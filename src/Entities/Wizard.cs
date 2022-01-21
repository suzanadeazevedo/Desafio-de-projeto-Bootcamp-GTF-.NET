namespace ProjetoRPG.src.Entities
{
    public class Wizard : Heroes
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou uma mágia Stupefy " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma mágia Petrificus Totalus " + Bonus;
            }
        }
    }
}