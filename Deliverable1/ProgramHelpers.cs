internal static class ProgramHelpers
{

    public static void Main(string[] args)
    {
      string restart = "yes";
      while (restart == "yes" || restart == "y")
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            int people = int.Parse(Console.ReadLine());

            decimal slicesperloaf = 28;
            decimal TbspperPBjar = 32;
            decimal tspperjeljar = 48;

            decimal totalSlicesNeeded = people * 2;
            decimal totalTbspNeeded = people * 2;
            decimal totaltspNeeded = people * 4;

            decimal totalLoavesNeeded = totalSlicesNeeded / slicesperloaf;
            decimal dTotalLoavesNeeded = Math.Ceiling(totalLoavesNeeded);
            decimal totalPBjarsNeeded = totalTbspNeeded / TbspperPBjar;
            decimal dTotalPBjarsNeeded = Math.Ceiling(totalPBjarsNeeded);
            decimal totaljeljarNeeded = totaltspNeeded / tspperjeljar;
            decimal dTotaljeljarNeeded = Math.Ceiling(totaljeljarNeeded);

            Console.WriteLine("You need: {0} {1} {2} slices of bread {3} {4} tablespoons of peanut butter {5} {6} teaspoons of jelly {7} {8} which is... {9} {10} {11} loaves of bread {12} {13} jars of peanut butter {14} {15} jars of jelly {16}",
                Environment.NewLine, Environment.NewLine,
                totalSlicesNeeded,
                Environment.NewLine, totalTbspNeeded,
                Environment.NewLine, totaltspNeeded,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine,
                Environment.NewLine, dTotalLoavesNeeded,
                Environment.NewLine, dTotalPBjarsNeeded,
                Environment.NewLine, dTotaljeljarNeeded,
                Environment.NewLine);
            
            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            restart = Console.ReadLine();
        }
    Console.WriteLine("Goodbye!");
    }
}