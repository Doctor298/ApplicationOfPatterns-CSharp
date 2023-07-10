using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project.WheelchairComponents.Wheels
{
    public class StandardWheel : MechanicalWheel
    {
        public StandardWheel()
        {
            Price = 11.34f;
            Weight = 1.3f;
            Radius = 16f;
            isPneumatic = true;
            SpokeCount = 48;
        }
    }
}
