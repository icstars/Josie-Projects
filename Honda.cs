namespace MarchFourth.Car;
    public class Honda
    {
        public string Make {get; set;} = "Honda";
        public string Model {get; set;} = "Civic";
        public int Year {get; set;} = 1995;
        public bool isInsured {get; set;} = false;

        public void Drive()
        {
            Console.WriteLine("My car is a " + Year + " " + Make + " " + Model + " and it is " + (isInsured ? "insured." : "not insured."));
        }
    }
