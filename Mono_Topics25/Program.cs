using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mono_Topics25
{
    public class Program
    {
        event GreetByLanguage greet;
        static void Main(string[] args)
        {
            Program program = new Program();

            GreetByLanguage englishGreeting = program.EnglishGreeting;
            GreetByLanguage spanishGreeting = program.SpanishGreeting;

            
            program.greet += englishGreeting;
            program.greet += spanishGreeting;
            program.OnGreet("Tomislav");
            Console.ReadLine();


        }
        delegate void GreetByLanguage(string name);
        void OnGreet(string name)
        {
            if(greet != null)
            {
                greet(name);
            }
        }
        void EnglishGreeting(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        // Metoda za španjolski pozdrav
        void SpanishGreeting(string name)
        {
            Console.WriteLine("¡Hola, " + name + "!");
        }
    }
}
