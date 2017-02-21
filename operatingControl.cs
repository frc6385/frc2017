using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib;

namespace FRC2017i{
	class operatingControl{
		// init VictorSP
		VictorSP motorBallReady;
		VictorSP motorBallShoot;
		VictorSP motorRobotClimb;

		public operatingControl(){
			motorBallReady=new VictorSP(RobotMap.motorBallReady);
			motorBallShoot=new VictorSP(RobotMap.motorBallShoot);
			motorRobotClimb=new VictorSP(RobotMap.motorRobotClimb);
		}

		public void resetMotors(){
			motorBallShoot.StopMotor();
			motorBallReady.StopMotor();
			motorRobotClimb.StopMotor();
		}

		public void readyBall(int clockwise,double value){
			if((value<=1.0) && (value>=-1.0)){
				motorBallReady.SetSpeed(value*clockwise);
			}else{
				Console.WriteLine("INVALID value: "+value.ToString());
			}
		}
		
		public void shootBall(double value){
			if((value<=1.0) && (value>=-1.0)){
				motorBallShoot.SetSpeed(value);
			}else{
				Console.WriteLine("INVALID value: "+value.ToString());
			}
		}

		public void robotClimb(double value){
			if((value<=1.0) && (value>=-1.0)){
				motorRobotClimb.SetSpeed(value);
			}else{
				Console.WriteLine("INVALID value: "+value.ToString());
			}
		}
	}
}
