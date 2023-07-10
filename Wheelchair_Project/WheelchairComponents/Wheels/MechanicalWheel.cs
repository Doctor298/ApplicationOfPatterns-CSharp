using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project.WheelchairComponents.Wheels
{
    public abstract class MechanicalWheel : WheelchairComponent
    {
        protected float Radius { get; set; }

        protected int SpokeCount { get; set; }

        protected bool isPneumatic { get; set; }
    }
}
