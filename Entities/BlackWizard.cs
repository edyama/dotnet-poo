namespace dotnet_poo.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + "/385 " + this.MP + "/641 ";
        }
        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " launch super effective black magic with bonus attack of " + Bonus + " against ";
            }
            else
            {
                return this.Name + " launch weak black magic with bonus attack of " + Bonus + " against ";
            }

            MP -= Bonus;
        }
    }
}