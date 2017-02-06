using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib;

namespace FRC2017i{
	class drivingControl{
		// init VictorSP
		VictorSP motorFrontLeft;
		VictorSP motorFrontRight;
		VictorSP motorRearLeft;
		VictorSP motorRearRight;
		// init RobotDrive
		RobotDrive drive;

		public drivingControl(){
			motorFrontLeft=new VictorSP(RobotMap.motorFrontLeft);
			motorFrontRight=new VictorSP(RobotMap.motorFrontRight);
			motorRearLeft=new VictorSP(RobotMap.motorRearLeft);
			motorRearRight=new VictorSP(RobotMap.motorRearRight);

			drive=new RobotDrive(motorFrontLeft,motorRearLeft,motorFrontRight,motorRearRight);
		}

		public void resetMotors(){
			motorFrontLeft.StopMotor();
			motorFrontRight.StopMotor();
			motorRearLeft.StopMotor();
			motorRearRight.StopMotor();
			drive.StopMotor();
		}

		public void drivingMotorControlRaw(string where,double value){
			switch(where){
				case "left":
					motorFrontLeft.SetRaw((int)(value*2000));
					motorRearLeft.SetRaw((int)(value*2000));
					break;
				case "right":
					motorFrontRight.SetRaw((int)(value*2000));
					motorRearRight.SetRaw((int)(value*2000));
					break;
				default:
					Console.WriteLine("no method for "+where);
					break;
			}
		}

		public void arcadeDrive(double x,double y,bool squared){
			drive.ArcadeDrive(y,x,squared);
		}
	}
}
