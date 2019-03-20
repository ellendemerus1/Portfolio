using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_project
{
    class OutdoorCamera : ICamera
    {
        protected int Id;
        private ICamFacade Facade;
        private static int _Id;

        public OutdoorCamera(ICamFacade facade)
        {
            this.Id = ++_Id;
            Facade = facade;
        }

        public void Start()
        {
            Facade.Start();
        }

        public void Stop()
        {
            Facade.Stop();
        }

        public void Update(string command)
        {
            if (command.Equals("ON"))
            {
                Console.WriteLine("Outdoor Camera " + Id + ": ON");
            }
            else if (command.Equals("OFF"))
            {
                Console.WriteLine("Outdoor Camera " + Id + ": OFF");
            }
            else
            {
                Console.WriteLine("Invalid command, please try again");
            }
        }
    }
}
