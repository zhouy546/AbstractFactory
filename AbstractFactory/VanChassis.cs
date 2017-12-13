using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get {
                return "Chassis parts for a van";
            }
        }
    }
}
