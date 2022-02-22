namespace dotnet_poo.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public Hero()
        {}
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        
        public virtual string Attack(int Bonus)
        {
            return this.Name + " attack with sword with bonus attack of " + Bonus + " against ";
        }
        public void LoseHP(int Lose)
        {
            HP -= Lose;
        }
        public void IsDead()
        {
            if(HP <= 0)
            {
                Console.WriteLine(Name + " is dead");
                HP = 0;
            }
        }
        public void IsMagicOver()
        {
            if(MP <= 0)
            {
                Console.WriteLine(Name + " has 0 magic points");
                MP = 0;
            }
        }
    }
}