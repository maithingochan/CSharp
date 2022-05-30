using System;

namespace population_management
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People("Đoan Thanh Ha", "Ba Đình", "1", "Đà Nẵng", new DateTime(2001,10,16));
            Address Ad1 = new Address("pham chau trinh", "1", "hue");
            Address Ad2 = new Address("pham chau trinh", "3", "hue");
            Console.WriteLine(people.toString());
            Console.WriteLine(people.createEmail());
        }
    }
}
