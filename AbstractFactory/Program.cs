using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            string whatToMake = "car";
            AbstractVehicleFactory factory = null;
            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else {
                factory = new VanFactory();
            }

            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();
            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswarePart);
            Console.ReadKey();
        }
    }
}
