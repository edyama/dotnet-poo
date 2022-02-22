namespace dotnet_poo.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + "/574 " + this.MP + "/89 ";
        }
        public override string Attack(int Bonus)
        {
            return this.Name + " attack with sword with bonus attack of " + Bonus + " against ";
        }
    }
}