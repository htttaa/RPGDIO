namespace Pilares_POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name; 
            this.Level = Level;
            this.HeroType = HeroType;            
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " double slashed attack with " + Bonus + " damage points";
            }else
            {
                return this.Name + " single slashed attack with " + Bonus + " damage points";
            }         
        }  
  
    }
}