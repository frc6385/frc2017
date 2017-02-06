using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib;

namespace FRC2017i{
	class operatingControl{
		// init Joysticks
		Joystick driving;

		public operatingControl(){
			driving=new Joystick(RobotMap.joystickDriving);
		}
		
		public double readAxis(int port,string which){
			switch(which){
				case "drive":
					return driving.GetRawAxis(port);
					break;
				default:
					Console.WriteLine("no method for "+which);
					return 0.0;
					break;
			}
		}

		public bool readButton(int port,string which){
			switch(which){
				case "drive":
					return driving.GetRawButton(port);
					break;
				default:
					Console.WriteLine("no method for "+which);
					return false;
					break;
			}
		}
	}
}
