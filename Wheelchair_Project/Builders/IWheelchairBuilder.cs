using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project.Builders
{
    public interface IWheelchairBuilder
    {
        public void Reset();
        public void BuildFrame();
        public void BuildWheels();
        public void BuildAxleAssembly();
        public void BuildCasterAssembly();
        public void BuildSeat();
        public void BuildFramePainter();

        public Wheelchair GetProduct();
    }
}
