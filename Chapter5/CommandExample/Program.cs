using BumbleBikesLibrary;
using BumbleBikesLibrary.PaintableBicycle;
using BumbleBikesLibrary.PaintableBicycle.CommonPaintJobs;
using FacadeExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var blackPaintJob = new BlackPaintJob();
            var standardMountainBike = new PaintableMountainBike(blackPaintJob);
            var robotArmFacade = new RobotArmFacade(new WelderAttachmentApi(), new BuffingApi(), new GrabbingApi());

            var cmd = new BuildFrameCommand(new AssemblyLineReceiver(robotArmFacade), standardMountainBike);

            var sender = new Sender(cmd);
            sender.DoCommand();
        }
    }
}
