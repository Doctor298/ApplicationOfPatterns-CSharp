using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelchair_Project.Painters;
using Wheelchair_Project.WheelchairComponents;
using Wheelchair_Project.WheelchairComponents.Frames;
using Wheelchair_Project.WheelchairComponents.Seats;

namespace Wheelchair_Project
{
    public abstract class Wheelchair : WheelchairComponent, IManufacturable
    {
        private WheelchairSeat _seat;
        private WheelchairFrame _frame;

        public string ModelName { get; set; }

        public int Year { get; }

        public string SerialNumber { get; }

        public string? BuildStatus { get; set; }

        public WheelchairSeat Seat
        {
            get => _seat;
            set
            {
                _seat = value;
                FixComposite();
            }
        }

        public IFramePainter FramePainter { get; set; }

        public WheelchairFrame Frame
        {
            get => _frame;
            set
            {
                _frame = value;
                FixComposite();
            }
        }

        private void FixComposite()
        {
            Subcomponents.Clear();
            Subcomponents.Add(_frame);
            Subcomponents.Add(_seat);
        }

        protected Wheelchair()
        {
            ModelName = string.Empty;
            SerialNumber = Guid.NewGuid().ToString();
            Year = DateTime.Now.Year;
        }

    }
}
