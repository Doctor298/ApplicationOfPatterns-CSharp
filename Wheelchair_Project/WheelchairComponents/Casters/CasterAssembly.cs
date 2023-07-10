using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelchair_Project.WheelchairComponents.Wheels;

namespace Wheelchair_Project.WheelchairComponents.Casters
{
    public abstract class CasterAssembly : WheelchairComponent
    {
        private MechanicalWheel _wheel;

        protected MechanicalWheel Wheel
        {
            get => _wheel;
            set
            {
                _wheel = value;
                Subcomponents.Clear();
                Subcomponents.Add(value);
            }
        }

        protected string Swivel { get; set; }

        public string MountingType { get; set; }

        public float LoadCapacity { get; set; }
    }
}
