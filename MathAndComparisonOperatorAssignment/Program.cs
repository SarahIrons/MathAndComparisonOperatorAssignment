using System;
class PayRate
{
    public float hourlyRate { get; set; }
    public float hours { get; set; }
    public float income => hours * hourlyRate * 52;

}
namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            var payRateA = new PayRate();
            var payRateB = new PayRate();
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate:");
            payRateA.hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            payRateA.hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual income:$" + payRateA.income);
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate:");
            payRateB.hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            payRateB.hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual income:$ " + payRateB.income);
            Console.WriteLine("Does  Person 1 make more than Person 2?");
            Console.Write(payRateA.income > payRateB.income);
        }
    }
}
