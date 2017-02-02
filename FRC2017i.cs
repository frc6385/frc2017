﻿using System;
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
		// init Joystick
		Joystick joystickDriving;
		drivingControl driveCtl;

		public override void RobotInit(){
			Console.WriteLine("Hello, FRC2017!");
			Console.WriteLine("TrueMoe RobotCode 2017i");
			chooser=new SendableChooser();
			chooser.AddDefault("Default Auto",defaultAuto);
			chooser.AddObject("My Auto",customAuto);
			SmartDashboard.PutData("Chooser",chooser);

			joystickDriving=new Joystick(RobotMap.joystickDriving);
			driveCtl=new drivingControl();
		}

		// This autonomous (along with the sendable chooser above) shows how to select between
		// different autonomous modes using the dashboard. The senable chooser code works with
		// the Java SmartDashboard. If you prefer the LabVIEW Dashboard, remove all the chooser
		// code an uncomment the GetString code to get the uto name from the text box below
		// the gyro.
		//You can add additional auto modes by adding additional comparisons to the switch
		// structure below with additional strings. If using the SendableChooser
		// be sure to add them to the chooser code above as well.
		public override void AutonomousInit(){
			autoSelected=(string)chooser.GetSelected();
			//autoSelected = SmartDashboard.GetString("Auto Selector", defaultAuto);
			Console.WriteLine("Auto selected: "+autoSelected);
		}

		/// <summary>
		/// This function is called periodically during autonomous
		/// </summary>
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
			double x=joystickDriving.GetRawAxis(RobotMap.joystickDrivingLeverX);
			double y=joystickDriving.GetRawAxis(RobotMap.joystickDrivingLeverY);
			Console.WriteLine("X:"+x.ToString()+"  Y:"+y.ToString());
		}
	}
}
