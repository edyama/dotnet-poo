namespace dotnet_poo.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + "/601 " + this.MP + "/482 ";
        }
        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " launch super effective white magic with bonus attack of " + Bonus + " against ";
            }
            else
            {
                return this.Name + " launch weak white magic with bonus attack of " + Bonus + " against ";
            }

            MP -= Bonus;
        }
    }
}