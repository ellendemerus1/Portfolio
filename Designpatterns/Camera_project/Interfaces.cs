using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_project
{
    //********INTERFACES

    public interface ICamera
    {
        void Start();
        void Stop();
        void Update(string command);
    }

    public interface ICamFacade
    {
        void Start();
        void Stop();
    }

    public interface IMonitor
    {
        void Attach(ICamera c);
        void Detach(ICamera c);
        void NotifyObservers(string command);
        void StartCameras();
        void StopCameras();
    }
}
