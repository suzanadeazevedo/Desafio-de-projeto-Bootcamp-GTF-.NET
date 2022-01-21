namespace ProjetoRPG.src.Entities
{
    public class BlackWizard : Heroes
    {
        public BlackWizard(string Name, int Level, string HeroType)
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
            if (Bonus > 99)
            {
                return this.Name + " Lançou uma mágia Avada Kedrava " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma mágia Cruciatus " + Bonus;
            }
        }
    }

}
