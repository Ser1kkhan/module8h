//using System;

//class UtilityPaymentCalculator
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Utility Payment Calculator");

//        // Input room area, number of residents, season, and discounts
//        Console.Write("Enter room area (in square meters): ");
//        double roomArea = double.Parse(Console.ReadLine());

//        Console.Write("Enter the number of residents: ");
//        int numberOfResidents = int.Parse(Console.ReadLine());

//        Console.Write("Enter the season (1 for autumn, 2 for winter): ");
//        int season = int.Parse(Console.ReadLine());

//        Console.Write("Is the resident a veteran of labor? (y/n): ");
//        bool isVeteranLabor = Console.ReadLine().ToLower() == "y";

//        Console.Write("Is the resident a war veteran? (y/n): ");
//        bool isWarVeteran = Console.ReadLine().ToLower() == "y";

//        // Utility tariffs
//        double heatingTariff = season == 2 ? 2.0 : 1.5; // Higher tariff in winter
//        double waterTariff = 5.0;
//        double gasTariff = 4.0;
//        double repairTariff = 1.0;

//        // Calculate costs
//        double heatingCost = roomArea * heatingTariff;
//        double waterCost = numberOfResidents * waterTariff;
//        double gasCost = numberOfResidents * gasTariff;
//        double repairCost = roomArea * repairTariff;

//        double totalCost = heatingCost + waterCost + gasCost + repairCost;

//        // Apply discounts
//        double discount = 0.0;
//        if (isVeteranLabor) discount += totalCost * 0.3;
//        if (isWarVeteran) discount += totalCost * 0.5;

//        double discountedTotal = totalCost - discount;

//        // Display the results in a table
//        Console.WriteLine("\nUtility Payments:");
//        Console.WriteLine("--------------------------------------------------------");
//        Console.WriteLine("| Type            | Amount     | Discount    | Total      |");
//        Console.WriteLine("--------------------------------------------------------");
//        Console.WriteLine($"| Heating         | ${heatingCost:F2}  |            | ${heatingCost:F2}  |");
//        Console.WriteLine($"| Water           | ${waterCost:F2}   |            | ${waterCost:F2}   |");
//        Console.WriteLine($"| Gas             | ${gasCost:F2}     |            | ${gasCost:F2}     |");
//        Console.WriteLine($"| Repair          | ${repairCost:F2}  |            | ${repairCost:F2}  |");
//        Console.WriteLine("--------------------------------------------------------");
//        Console.WriteLine($"| Total           | ${totalCost:F2}  | ${discount:F2} | ${discountedTotal:F2} |");
//        Console.WriteLine("--------------------------------------------------------");

//        Console.WriteLine($"Total utility payment: ${discountedTotal:F2}");

//        Console.ReadKey();
//    }
//}
