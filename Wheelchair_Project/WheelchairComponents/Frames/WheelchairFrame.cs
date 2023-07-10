using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheelchair_Project.WheelchairComponents.Axles;
using Wheelchair_Project.WheelchairComponents.Casters;

namespace Wheelchair_Project.WheelchairComponents.Frames
{
    public abstract class WheelchairFrame : WheelchairComponent
    {
        private CasterAssembly _leftCaster;
        private CasterAssembly _rightCaster;
        private Axle _axle;

        public Axle Axle
        {
            get => _axle;
            set
            {
                _axle = value;
                FixComposite();
            }
        }

        public CasterAssembly LeftCaster
        {
            get => _leftCaster;
            set
            {
                _leftCaster = value;
                FixComposite();
            }
        }

        public CasterAssembly RightCaster
        {
            get => _rightCaster;
            set
            {
                _rightCaster = value;
                FixComposite();
            }
        }

        private void FixComposite()
        {
            Subcomponents.Clear();
            Subcomponents.Add(_axle);
            Subcomponents.Add(_leftCaster);
            Subcomponents.Add(_rightCaster);
        }
    }
}
