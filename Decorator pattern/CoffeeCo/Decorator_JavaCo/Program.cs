using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageComponent firstDrink = new Drink("Coffee ");
            firstDrink = new Milk(firstDrink, 2);
            firstDrink = new Sugar(firstDrink, 1);

            BeverageComponent Tea = new Drink("Tea ");
            Tea = new Lemon(Tea);

            BeverageComponent frothedCoffee = new Drink("Coffee ");
            frothedCoffee = new Milk(frothedCoffee, 1);
            frothedCoffee = new Sugar(frothedCoffee, 2);

            BeverageComponent hotChoc = new Drink("Hot chocolate ");
            hotChoc = new Toppings(hotChoc, 3); 

            BeverageComponent blkCoffee = new Drink("Black Coffee ");
            blkCoffee = new Milk(blkCoffee, 0);
            blkCoffee = new Sweetener(blkCoffee, 1);

            BeverageComponent sHotChoc = new Drink("Hot Chocolate with");
            sHotChoc = new Sugar(sHotChoc, 1);


            Console.WriteLine(firstDrink.Details());
            Console.WriteLine(Tea.Details());
            Console.WriteLine(frothedCoffee.Details());
            Console.WriteLine(hotChoc.Details());
            Console.WriteLine(blkCoffee.Details());
            Console.WriteLine(sHotChoc.Details());

            Console.ReadLine();

        }
    }
}
