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
			motorFrontLeft.SafetyEnabled=false;
			motorFrontRight.SafetyEnabled=false;
			motorRearLeft.SafetyEnabled=false;
			motorRearRight.SafetyEnabled=false;
			motorFrontLeft=new VictorSP(RobotMap.motorFrontLeft);
			motorFrontRight=new VictorSP(RobotMap.motorFrontRight);
			motorRearLeft=new VictorSP(RobotMap.motorRearLeft);
			motorRearRight=new VictorSP(RobotMap.motorRearRight);

			drive.SafetyEnabled=false;
			drive=new RobotDrive(motorFrontLeft,motorRearLeft,motorFrontRight,motorRearRight);
		}

		public void controlForward(double x){
			motorFrontLeft.Set(x);
			motorRearLeft.Set(x);
			motorFrontRight.Set(x);
			motorRearRight.Set(x);
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
					motorFrontLeft.SetSpeed(value);
					motorRearLeft.SetSpeed(value);
					break;
				case "right":
					motorFrontRight.SetSpeed(value);
					motorRearRight.SetSpeed(value);
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
