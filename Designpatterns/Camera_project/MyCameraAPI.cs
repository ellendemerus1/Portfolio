using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCameraAPI
{

    public class CameraDriver
    {
        public void ConnectCamera()
        {
            Console.WriteLine("\nCamera connected");
        }

        public void DisconnectCamera()
        {
            Console.WriteLine("Camera disconnected\n");
        }

        public void RunFailCheck()
        {
            Console.WriteLine("Running fail check...");
        }

    }

    public class ImageProcessor
    {
        public void StartImageReceiver()
        {
            Console.WriteLine("Image receiver enabled");
        }

        public void StopImageReceiver()
        {
            Console.WriteLine("\nImage receiver disabled");
        }

        public void EnableFilter()
        {
            Console.WriteLine("Filter enabled");
        }

    }

    public class SoundProcessor
    {
        public float Volume { get; private set; }


        public void StartSoundReceiver()
        {
            Console.WriteLine("Sound receiver enabled");
        }

        public void StopSoundReceiver()
        {
            Console.WriteLine("Sound receiver disabled");
        }

        public void SetVolume(float v)
        {
            Volume = v;
            Console.WriteLine("Volume set to: " + v + "\n");
        }

    }

    public class CameraLight
    {

        public void StartLight()
        {
            Console.WriteLine("Light enabled");
        }

        public void StopLight()
        {
            Console.WriteLine("Light disabled");
        }

    }

    public class MotionSensor
    {

        public void StartMotionSensor()
        {
            Console.WriteLine("Motion sensor started\n");
        }

        public void StopMotionSensor()
        {
            Console.WriteLine("Motion sensor stopped");
        }

    }
}
