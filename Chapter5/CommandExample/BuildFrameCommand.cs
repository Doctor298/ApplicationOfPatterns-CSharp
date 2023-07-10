using BumbleBikesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class BuildFrameCommand : ICommand
    {
        private AssemblyLineReceiver assemblyLineReceiver;

        private IPaintableBicycle bicycle;

        public BuildFrameCommand(AssemblyLineReceiver assemblyLineReceiver, IPaintableBicycle bicycle)
        {
            this.assemblyLineReceiver = assemblyLineReceiver;
            this.bicycle = bicycle;
        }

        public void Execute()
        {
            assemblyLineReceiver.DoBusinessLogic(bicycle);
        }
    }
}
