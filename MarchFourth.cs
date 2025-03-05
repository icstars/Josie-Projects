using MarchFourth.People;
using MarchFourth.Occupation;
using MarchFourth.Car;

namespace MarchFourth
{
        class MarchFourth
        {
                static void Main(string[] args)
                {
                        Sabrina sabrina = new Sabrina();
                        {
                                sabrina.Name = "Sabrina";
                                sabrina.Age = 23;
                                sabrina.isRightHanded = true;    
                        };
                        sabrina.Jump();  
                        
                        Honda honda = new Honda(); 
                        {
                                honda.Model = "Civic";
                                honda.Year = 1995; 
                                honda.isInsured = false; 
                                
                        };   
                        honda.Drive();

                        Student student = new Student();
                        {
                                student.Organization = "UMKC";
                                student.Salary = 0;
                                student.picksNose = false;    
                        }
                        student.Jump();
                }
        }
}
