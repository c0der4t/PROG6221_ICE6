namespace prjICETASK6

{

    public class FestivalPlanner
    {
        public delegate void BandAnnouncementDelegate(Band band);
        public delegate void StagePerformanceDelegate();

        public BandAnnouncementDelegate RegisterBand;
        public StagePerformanceDelegate StartPerformance;

        private List<Band> registeredBands = new List<Band>();
        public int TotalRoomNeeded { get; set; }

        private int currentBand = 0;

        public FestivalPlanner()
        {
            RegisterBand += UpdateBandList;
            RegisterBand += ReserveHotelRooms;

            StartPerformance += AnnounceNextBand;
            StartPerformance += IntroduceBand;
            StartPerformance += BandPerforms;
            StartPerformance += BandExits;
        }

        private void UpdateBandList(Band bandToRegister)
        {
            registeredBands.Add(bandToRegister);
        }

        private void ReserveHotelRooms(Band bandToRegister)
        {

            int RoomSize = 2;

            if (bandToRegister.MemberCount > RoomSize)
            {
                // We need multiple rooms
                int roomsneeded = (int)Math.Ceiling((double)bandToRegister.MemberCount / 2);
                TotalRoomNeeded += roomsneeded;
            }
            else
            {
                TotalRoomNeeded++;
            }

        }

        public void AnnounceNextBand()
        {
            Console.WriteLine("Ladies and gentleman, our next band is making their way to the stage");
            Console.WriteLine($"Grab your drinks, find your seats and get ready for some {registeredBands[currentBand].Genre} music");
            Thread.Sleep(5000);
        }

        public void IntroduceBand()
        {
            Console.WriteLine("Ladies and gentleman, put your hands together and welcome our next band");
            Console.WriteLine($"{registeredBands[currentBand].Name.ToUpper()}!!");
            Thread.Sleep(5000);
        }

        public void BandPerforms()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"*{registeredBands[currentBand].Name} plays song {i + 1}*");
                Thread.Sleep(1500);
            }
        }

        public void BandExits()
        {

            Console.WriteLine($"Ladies and gentleman, for the last time, make some noise for {registeredBands[currentBand].Name}\n\n");
            Thread.Sleep(5000);
        }

        public void Simulate()
        {

            Console.WriteLine("Welcome one and all.\nWe have some awesome bands lined up for today, and here is our schedule:");

            foreach (Band band in registeredBands)
            {
                Console.WriteLine($"\n{band.Name} playing some {band.Genre} at {band.TimeSlot}");
            }

            Console.WriteLine("Enjoy your day!\n\n");
            Thread.Sleep(5000);

            for (currentBand = 0; currentBand < registeredBands.Count; currentBand++)
            {
                StartPerformance();
            }

            Thread.Sleep(10000);
            Console.WriteLine("\n\nThank you to everyone who attended today's fesitval. We will see you again next time");
        }
    }
}
