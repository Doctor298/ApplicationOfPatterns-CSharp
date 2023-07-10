using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelchair_Project.Painters;
using Wheelchair_Project.WheelchairComponents.Axles;
using Wheelchair_Project.WheelchairComponents.Casters;
using Wheelchair_Project.WheelchairComponents.Frames;
using Wheelchair_Project.WheelchairComponents.Seats;
using Wheelchair_Project.WheelchairComponents.Wheels;

namespace Wheelchair_Project.Builders
{
    public class PlanoWheelchairBuilder : IWheelchairBuilder
    {
        private PlanoWheelchair _wheelchair;

        public PlanoWheelchairBuilder()
        {
            Reset();

        }

        public void Reset()
        {
            _wheelchair = new PlanoWheelchair();

        }

        public void BuildFrame()
        {
            _wheelchair.Frame = new PlanoWheelchairFrame();
        }

        public void BuildWheels()
        {
            _wheelchair.RightWheel = new StandardWheel();
            _wheelchair.LeftWheel = new StandardWheel();
            _wheelchair.Casters = new PlanoCasterAssembly(new CasterWheel());
        }


        public void BuildAxleAssembly()
        {
            var leftWheel = new StandardWheel();
            var rightWheel = new StandardWheel();
            var axle = new StandardAxle(leftWheel, rightWheel);
            _wheelchair.Frame.Axle = axle;
        }

        public void BuildCasterAssembly()
        {
            var planoCasterWheel = new CasterWheel();
            var casterAssembly = new PlanoCasterAssembly(planoCasterWheel);
            _wheelchair.Frame.LeftCaster = casterAssembly;
            _wheelchair.Frame.RightCaster = casterAssembly;
        }

        public void BuildSeat()
        {
            _wheelchair.Seat = new PlanoSeat();

        }

        public void BuildFramePainter()
        {
            var painter = new PlanoWheelchairPainter
            {
                PaintColorName = "Green-Eyed Judy",
                Cyan = 79,
                Magenta = 22,
                Yellow = 100,
                Black = 8
            };

            _wheelchair.FramePainter = painter;
            _wheelchair.FramePainter.MixPaint();
            _wheelchair.FramePainter.PaintFrame();
        }

        public Wheelchair GetProduct()
        {
            return _wheelchair;
        }
    }
}
