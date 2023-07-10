using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelchair_Project.WheelchairComponents.Wheels;

namespace Wheelchair_Project.WheelchairComponents.Casters
{
    public class PlanoCasterAssembly : CasterAssembly
    {
        public PlanoCasterAssembly(MechanicalWheel wheel)
        {
            LoadCapacity = 300.0f;
            MountingType = "STEM";
            Weight = 0.443f;
            Price = 4.32f;
            Wheel = wheel;
        }
    }
}
