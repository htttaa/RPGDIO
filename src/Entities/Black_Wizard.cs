namespace Pilares_POO.src.Entities
{
    public class Black_Wizard : Hero
    {
        public Black_Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name; 
            this.Level = Level;
            this.HeroType = HeroType;           
        }

        public override string Attack()
        {
            return this.Name + " casted black magic!"; 
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " casted superefective black magic with" + Bonus + " damage points";
            }else
            {
                return this.Name + " casted weak black magic with " + Bonus + " damage points";
            }         
        }


    }
}