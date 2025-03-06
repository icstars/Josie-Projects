namespace MarchFourth.Occupation
{
    public class Student
    {
        public string Organization = "UMKC";
        public int Salary = 0;
        public bool picksNose = false;
        public void Jump()
        {
            Console.WriteLine("I'm a college student at " + Organization + ", and I'm sad to report that I get paid " + Salary + " dollars per year.");
        }
    }
}