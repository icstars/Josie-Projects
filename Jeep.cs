namespace MarchFourth.Car;
    public class Jeep
    {
        public string Model = "Cherokee";
        public int Year = 2015;
        public bool isInsured = true;
        public void Drive()
        {
            Console.WriteLine("My car is a " + Year + Model + " and it is " + isInsured + "insured." + "not insured.");
        }
    }