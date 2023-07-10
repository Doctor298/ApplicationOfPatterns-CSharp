using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheelchair_Project.Builders
{
    public class WheelchairBuilderDirector
    {
        private IWheelchairBuilder _builder;
        private static WheelchairBuilderDirector? _instance;

        public WheelchairBuilderDirector(IWheelchairBuilder builder)
        {
            _builder = builder;
        }

        public static WheelchairBuilderDirector? GetInstance(IWheelchairBuilder builder)
        {
            if (_instance == null)
            {
                _instance = new WheelchairBuilderDirector(builder);
            }

            return _instance;

        }

        public Wheelchair Build()
        {
            _builder.BuildSeat();
            _builder.BuildFrame();
            _builder.BuildAxleAssembly();
            _builder.BuildCasterAssembly();
            _builder.BuildFramePainter();

            return _builder.GetProduct();
        }
    }
}
