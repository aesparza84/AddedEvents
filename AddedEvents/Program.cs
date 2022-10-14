namespace AddedEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane a = new Airplane(33);

            Airplane b = new Airplane(1);
            Airplane c = new Airplane(2);
            Airplane d = new Airplane(3);

            Airport airport = new Airport();

            Console.WriteLine($"Plane {a.code} current ALT: {a.currentAlt}ft");
            Console.WriteLine(a.TakeOff());                                        //uses event handler to take off
            a.startEngine();                                                      //engine uses start handler
             Console.WriteLine(a.TakeOff());
            Console.WriteLine($"Plane {a.code} current ALT: {a.currentAlt}ft");
            Console.WriteLine();

            Console.WriteLine("Testing allTakeOff method");
            airport.planes.Add(b);
            airport.planes.Add(c);
            airport.planes.Add(d);     
            airport.AllTakeOff();                                               //uses takeOff with FlyUp event to take off all planes
            Console.WriteLine($"Plane {b.code} is {b.currentAlt}ft");
            Console.WriteLine($"Plane {c.code} is {c.currentAlt}ft");
            Console.WriteLine($"Plane {d.code} is {d.currentAlt}ft");

        }
    }
}