using System;

class Program {
  public static void Main (string[] args) {
    const double baseRate = 200.00;
    const double hourlyRate = 150.00;
    const double mileRate = 2.00;
    Console.WriteLine("how many hours?");
    double hours = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("how many miles?");
    double miles = Convert.ToDouble(Console.ReadLine());
    double total =(miles * mileRate) + (hours * hourlyRate) + baseRate;
    Console.WriteLine("total price for this job is {0}", total);
  }
}