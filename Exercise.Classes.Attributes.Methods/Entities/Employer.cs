namespace Exercise.Classes.Attributes.Methods.Entities
{
    public class Employer
    {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double Taxes { get; set; }

        public Employer(string name, double grossSalary, double taxes)
        {
            Name = name;
            GrossSalary = grossSalary;
            Taxes = taxes;
        }

        public double NetSalary() => GrossSalary - Taxes;

        public void IncreaseSalary(double percent) => GrossSalary += (GrossSalary * percent) / 100;
    }
}