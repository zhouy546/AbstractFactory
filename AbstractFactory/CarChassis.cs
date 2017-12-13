using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarChassis :IChassis
    {
        public virtual string ChassisParts
        {
            get {
                return "Chassis parts for a car";
            }
        }
    }
}
