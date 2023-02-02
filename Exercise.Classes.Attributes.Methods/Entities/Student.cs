namespace Exercise.Classes.Attributes.Methods.Entities
{
    public class Student
    {
        public double Grade1 { get; set; }
        public double Grade2 { get; set; }
        public double Grade3 { get; set; }

        public Student(double grade1, double grade2, double grade3)
        {
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
        }

        public double SumOfGrades() => Grade1 + Grade2 + Grade3;
    }
}