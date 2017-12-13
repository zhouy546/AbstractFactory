using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarGlassware : IGlassware
    {
        public virtual string GlasswarePart
        {
            get {
                return "Window Glassware parts for a car";
            }
        }
    }
}
