using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Camera_project
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonitor insidemonitor = new Monitor();
            IMonitor outsidemonitor = new Monitor();

            ICamera indoorCam1 = CameraFactory.CreateCamera("IN", new IndoorCamFacade());
            ICamera indoorCam2 = CameraFactory.CreateCamera("IN", new IndoorCamFacade());
            ICamera outdoorCam1 = CameraFactory.CreateCamera("OUT", new OutdoorCamFacade());
            ICamera outdoorCam2 = CameraFactory.CreateCamera("OUT", new OutdoorCamFacade());

            insidemonitor.Attach(indoorCam1);
            insidemonitor.Attach(indoorCam2);
            outsidemonitor.Attach(outdoorCam1);
            outsidemonitor.Attach(outdoorCam2);

            insidemonitor.StartCameras();
            insidemonitor.NotifyObservers("ON");

            outsidemonitor.StartCameras();
            outsidemonitor.NotifyObservers("ON");

            Thread.Sleep(3000);

            insidemonitor.StopCameras();
            insidemonitor.NotifyObservers("OFF");

            outsidemonitor.StopCameras();
            outsidemonitor.NotifyObservers("OFF");

            Console.ReadLine();


        }
    }
}
