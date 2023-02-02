using System;
using Exercise.Classes.Attributes.Methods.Entities;

namespace Exercise.Classes.Attributes.Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
        }

        public static void Exercise1()
        {
            Console.WriteLine("Employer name: ");
            var employerName = Console.ReadLine();

            Console.WriteLine("Gross Salary: ");
            var grossSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Tax: ");
            var tax = double.Parse(Console.ReadLine());

            var employer = new Employer(employerName, grossSalary, tax);
            Console.WriteLine($"Employer: {employer.Name} $ {employer.NetSalary()}");

            Console.WriteLine("Enter the percentage to increase the salary: ");
            var percent = double.Parse(Console.ReadLine());

            employer.IncreaseSalary(percent);
            Console.WriteLine($"Update data: {employer.Name} {employer.NetSalary()}");
            Console.ReadKey();
        }

        public static void Exercise2()
        {
            var gradeForApproval = 60.00;

            Console.WriteLine("Enter the student's three grades: ");
            var grade1 = double.Parse(Console.ReadLine());
            var grade2 = double.Parse(Console.ReadLine());
            var grade3 = double.Parse(Console.ReadLine());

            var student = new Student(grade1, grade2, grade3);
            var sumOfGrades = student.SumOfGrades();

            if (sumOfGrades >= 60.00)
            {
                Console.WriteLine($"Final Grade: {student.SumOfGrades().ToString("F2")}");
                Console.WriteLine($"Approve!");
                return;
            }

            Console.WriteLine($"Final Grade: {sumOfGrades.ToString("F2")}");
            Console.WriteLine("Disapproved");
            Console.WriteLine($"Missing {(gradeForApproval - sumOfGrades).ToString("F2")} points");
            Console.ReadKey();
        }

        public static void Exercise3()
        {
            Console.WriteLine("What is the dollar exchange rate? ");
            double dollarExchangeRate = double.Parse(Console.ReadLine());

            Console.WriteLine("How many dollars will you buy? ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine($"Amount to be paid in reais: {CurrencyConverter.ConvertDollarToReal(dollarExchangeRate, amount).ToString("F2")}");
            Console.ReadKey();
        }
    }
}