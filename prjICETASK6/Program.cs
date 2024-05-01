namespace prjICETASK6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            FestivalPlanner beerFestival = new FestivalPlanner();

            beerFestival.RegisterBand(new Band("LowKey Love", "Pop",2, DateTime.Parse("2024-05-01 10:00:00")));
            beerFestival.RegisterBand(new Band("Soothingly Smooth", "Jazz", 7, DateTime.Parse("2024-05-01 15:00:00")));
            beerFestival.RegisterBand(new Band("Foo Fighters", "Rock", 5, DateTime.Parse("2024-05-01 20:00:00")));

            Console.WriteLine("Press any key to simulate the festival...");
            Console.ReadLine();

            beerFestival.Simulate();

            Console.WriteLine("Press any key to close the festival...");
            Console.ReadLine();

        }
    }
}
