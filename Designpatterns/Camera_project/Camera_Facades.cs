using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCameraAPI;

namespace Camera_project
{
    public class IndoorCamFacade : ICamFacade
    {
        protected ImageProcessor ImgP;
        protected SoundProcessor SoundP;
        protected CameraDriver CamDriver;

        public IndoorCamFacade()
        {
            ImgP = new ImageProcessor();
            SoundP = new SoundProcessor();
            CamDriver = new CameraDriver();
        }

        public void Start()
        {
            CamDriver.ConnectCamera();
            ImgP.StartImageReceiver();
            SoundP.StartSoundReceiver();
            SoundP.SetVolume(0.5f);
        }

        public void Stop()
        {
            ImgP.StopImageReceiver();
            SoundP.StopSoundReceiver();
            CamDriver.DisconnectCamera();
        }
    }

    public class OutdoorCamFacade : ICamFacade
    {
        protected ImageProcessor ImgP;
        protected CameraDriver CamDriver;
        protected CameraLight CamLight;
        protected MotionSensor MotSensor;


        public OutdoorCamFacade()
        {
            ImgP = new ImageProcessor();
            CamDriver = new CameraDriver();
            CamLight = new CameraLight();
            MotSensor = new MotionSensor();
        }

        public void Start()
        {
            CamDriver.ConnectCamera();
            ImgP.StartImageReceiver();
            ImgP.EnableFilter();
            CamLight.StartLight();
            MotSensor.StartMotionSensor();
        }

        public void Stop()
        {
            ImgP.StopImageReceiver();
            CamLight.StopLight();
            MotSensor.StopMotionSensor();
            CamDriver.DisconnectCamera();
        }
    }
}
