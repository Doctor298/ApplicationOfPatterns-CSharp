using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelchair_Project.WheelchairComponents.Wheels;

namespace Wheelchair_Project.WheelchairComponents.Axles
{
    public class StandardAxle : Axle
    {
        public StandardAxle(MechanicalWheel leftWheel, MechanicalWheel rightWheel)
        {
            Price = 4.33f;
            Weight = 0.335f;
            Radius = 0.24f;
            Length = 28.5f;

            LeftWheel = leftWheel;
            RightWheel = rightWheel;
        }
    }
}
