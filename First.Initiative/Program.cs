using System;

namespace First.Initiative
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Keko yöntem
            //var fn1 = "Can";
            //var ln1 = "Perk";
            //var a1 = 32;

            //var fn2 = "Ali";
            //var ln2 = "Veli";
            //var a2 = 3;
            
            //var fn3 = "Ahmet";
            //var ln3 = "Deli";
            //var a3 = 2;
            //Az Cool yöntem
            var h1 = new Human();
            h1.firstName = "Can";
            h1.lastName = "Perk";
            h1.age = 32;

            var h2 = new Human();
            h2.lastName = "Kahraman";
            h2.age = 25;
            h2.firstName = "Sergen";

            var h3 = new Human();
            h3.age = 19;
            h3.firstName = "Yunus Emre";
            h3.lastName = "Ertuğrul";


            Console.WriteLine($"{h1.firstName} {h1.lastName}, {h1.age}");
            Console.WriteLine("{0} {1}, {2}", h2.firstName, h2.lastName, h2.age);
            Console.WriteLine(h3.firstName + " " + h3.lastName + ", " + h3.age);

            Console.ReadLine();
            
            
            
            
            
            
            
            
            
            
            
            //Diğer instance alma yöntemleri
            //Human h2 = new Human();
            //First.Initiative.Human h3 = new First.Initiative.Human();
        }
    }
}
