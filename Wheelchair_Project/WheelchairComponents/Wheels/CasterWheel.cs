using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project.WheelchairComponents.Wheels
{
    public class CasterWheel : MechanicalWheel
    {
        public CasterWheel()
        {
            Price = 5.21f;
            Weight = 0.753f;
            Radius = 6f;
            isPneumatic = true;
            SpokeCount = 24;
        }
    }
}
