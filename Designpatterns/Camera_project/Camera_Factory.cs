using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_project
{
    public class CameraFactory
    {
        public static ICamera CreateCamera(string obj, ICamFacade camFacade)
        {
            if (obj.Equals("IN"))
            {
                return new IndoorCamera(new IndoorCamFacade());
            }

            else if (obj.Equals("OUT"))
            {
                return new OutdoorCamera(new OutdoorCamFacade());
            }
            else
                Console.WriteLine("Invalid command, please try again");
            return null;
        }
    }
}
