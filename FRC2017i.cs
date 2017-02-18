using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.SmartDashboard;

namespace FRC2017i{
	public class FRC2017i : IterativeRobot{
		const string defaultAuto="Default";
		const string customAuto="My Auto";
		string autoSelected;
		SendableChooser chooser;
		// init custom classes
		drivingControl driveCtl;
		operatingControl operateCtl;
		operatorInterface opIf;

		public override void RobotInit(){
			Console.WriteLine("Hello, FRC2017!");
			Console.WriteLine("TrueMoe RobotCode 2017i");
			chooser=new SendableChooser();
			chooser.AddDefault("Default Auto",defaultAuto);
			chooser.AddObject("My Auto",customAuto);
			SmartDashboard.PutData("Chooser",chooser);

			driveCtl=new drivingControl();
			operateCtl=new operatingControl();
			opIf=new operatorInterface();
		}
		
		public override void AutonomousInit(){
			autoSelected=(string)chooser.GetSelected();
			//autoSelected = SmartDashboard.GetString("Auto Selector", defaultAuto);
			Console.WriteLine("Auto selected: "+autoSelected);
		}
		
		public override void AutonomousPeriodic(){
			switch(autoSelected){
				case customAuto:
					//Put custom auto code here
					break;
				case defaultAuto:
				default:
					//Put default auto code here
					break;
			}
		}
		
		public override void TeleopPeriodic(){
			driveCtl.arcadeDrive(-1*opIf.readAxis(RobotMap.joystickDrivingLeverX,"drive")*RobotMap.drivingSpeedConstant,opIf.readAxis(RobotMap.joystickDrivingLeverY,"drive")*RobotMap.drivingSpeedConstant,RobotMap.drivingSquaredInput);

			if(opIf.readAxis(RobotMap.joystickDrivingBallReadyClockwise,"drive")>0.02){
				operateCtl.readyBall(1,opIf.readAxis(RobotMap.joystickDrivingBallReadyClockwise,"drive")*RobotMap.ballReadySpeedConstant);
			}else{
				operateCtl.readyBall(1,0);
			}

			if(opIf.readAxis(RobotMap.joystickDrivingBallReadyCounterClockwise,"drive")>0.02){
				operateCtl.readyBall(-1,opIf.readAxis(RobotMap.joystickDrivingBallReadyCounterClockwise,"drive")*RobotMap.ballReadySpeedConstant);
			}else{
				operateCtl.readyBall(-1,0);
			}
			
			if(opIf.readButton(RobotMap.joystickDrivingBallShoot,"drive")){
				operateCtl.shootBall(RobotMap.ballShootSpeedConstant);
			}

			if(opIf.readButton(RobotMap.joystickDrivingRobotClimb,"drive")){
				operateCtl.robotClimb(RobotMap.robotClimbSpeedConstant);
			}
			
			if(opIf.readButton(RobotMap.joystickDrivingStopAll,"drive")){
				operateCtl.resetMotors();
				driveCtl.resetMotors();
			}
		}
	}
}
