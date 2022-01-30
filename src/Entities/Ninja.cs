namespace Pilares_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name; 
            this.Level = Level;
            this.HeroType = HeroType;            
        }

        public override string Attack()
        {
            return this.Name + " threw nunchakus!"; 
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " threw all nunchakus on target with " + Bonus + " damage points";
            }else
            {
                return this.Name + " threw only one nunchaku on target with " + Bonus + " damage points";
            }         
        }


    }
}