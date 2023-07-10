using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project.WheelchairComponents.Seats
{
    public abstract class WheelchairSeat : WheelchairComponent
    {
        protected float BackHeight { get; set; }

        protected float Width { get; set; }

        protected float SeatThickness { get; set; }
    }
}
