namespace Pilares_POO.src.Entities
{
    public abstract class Hero //Classe abstrata: não é para utilizar, mas ser utilizada por outras classes
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name; //O this olha para as propriedades dela mesma;
            this.Level = Level;
            this.HeroType = HeroType;                      
        }

        public Hero()
        {

        }
        
        public string Name;
        public int Level;
        public string HeroType;      

        public override string ToString() //Sobreescrita de método: 
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack() //Virtual: permite que qualquer elemento filho altere o comportamento
        {
            return this.Name + " attacked with the sword!"; 
        }

    }
}