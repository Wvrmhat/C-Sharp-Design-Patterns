using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeBase BasicCake = new Cake("Vanilla");

            CakeBase ChocolateCake = new Cake("Chocolate");
            ChocolateCake = new ChocGanacheDecorator(ChocolateCake);

            CakeBase VanillaCake = new Cake("Vanilla");
            VanillaCake = new FrostingDecorator(VanillaCake);
            VanillaCake = new SprinklesDecorator(VanillaCake);

            CakeBase StrawberryCake = new Cheesecake("Strawberry Cheesecake");
            StrawberryCake = new StrawberryDecorator(StrawberryCake);

            CakeBase Umicake = new Cake("Umika's cake");
            Umicake = new ChocGanacheDecorator(Umicake);
            Umicake = new ChocolateSauceDecorator(Umicake);


            Console.WriteLine(BasicCake.Details());
            Console.WriteLine(BasicCake.Cost());
            Console.WriteLine("---------------------------------");

            Console.WriteLine(ChocolateCake.Details());
            Console.WriteLine(ChocolateCake.Cost());
            Console.WriteLine("---------------------------------");

            Console.WriteLine(VanillaCake.Details());
            Console.WriteLine(VanillaCake.Cost());
            Console.WriteLine("---------------------------------");

            Console.WriteLine(StrawberryCake.Details());
            Console.WriteLine(StrawberryCake.Cost());
            Console.WriteLine("---------------------------------");

            Console.WriteLine(Umicake.Details());
            Console.WriteLine("Free just for you dear, with extra love and magic <3");
        




            Console.ReadLine();
        }
    }
}
