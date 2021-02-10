using System;

namespace Learn_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediumIceCream = new MediumIceCream();
            var iceCreamWithChocolate = new IceCreamWithChocolate(mediumIceCream);
            var iceCreamWithSmarties = new IceCreamWithSmarties(iceCreamWithChocolate);
            
            Console.WriteLine(iceCreamWithSmarties.GetPrice());
            Console.ReadKey();
        }
    }

}
