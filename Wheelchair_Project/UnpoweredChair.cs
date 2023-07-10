using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelchair_Project.WheelchairComponents;

namespace Wheelchair_Project
{
    public abstract class UnpoweredChair : Wheelchair
    {
        public WheelchairComponent RightWheel { get; set; }

        public WheelchairComponent LeftWheel { get; set; }

        public WheelchairComponent Casters { get; set; }
    }
}
