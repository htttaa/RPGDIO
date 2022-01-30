using System;
using Pilares_POO.src.Entities;

namespace Pilares_POO
{
    class Program
    {
        static void Main(string[] args)
        {            
            Knight arus = new Knight("Arus", 23, "Knight"); //Instanciando um objeto de uma classe;
            Wizard wizard = new Wizard("Jennica", 27, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 33, "Ninja");
            Black_Wizard black_wizard = new Black_Wizard("Topapa", 64, "Black Wizard");
            
            Console.WriteLine(wizard.Attack(1));                      
        }
    }
}
