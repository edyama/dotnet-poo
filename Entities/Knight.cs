namespace dotnet_poo.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + "/749 " + this.MP + "/72 ";
        }
    }
}