using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake myCake = new Cake();
            myCake.Type = "Wedding Cake";
            myCake.AddFlavor<string>("Vanilla");

            Cake myCake2 = new Cake();
            myCake2.Type = "Party Cake";
            myCake2.AddFlavor<string>("Chocolate");

            Console.WriteLine("My cake is: " + myCake.Type + "and has a flavor of: " + myCake.Flavor);
            Console.WriteLine("My cake is: " + myCake2.Type + "and has a flavor of: " + myCake2.Flavor);

        }
    }
}

public class Cake
{
    public string Flavor { get; set; }
    public string Type { get; set; }

    public void AddFlavor<T>(T parameter1)
    {
        this.Flavor = parameter1 as string;
    }
}
