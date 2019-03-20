using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_project
{
    public class Monitor : IMonitor
    {
        private List<ICamera> _cameras;

        public Monitor()
        {
            _cameras = new List<ICamera>();
        }

        public void Attach(ICamera camera)
        {
            _cameras.Add(camera);
        }

        public void Detach(ICamera camera)
        {
            _cameras.Remove(camera);
        }

        public void StartCameras()
        {
            foreach (ICamera camera in _cameras)
            {
                camera.Start();
            }
        }

        public void StopCameras()
        {
            foreach (ICamera camera in _cameras)
            {
                camera.Stop();
            }
        }
        
        public void NotifyObservers(string command)
        {
            foreach (ICamera camera in _cameras)
            {
                camera.Update(command);
            }
        }
    }
}
