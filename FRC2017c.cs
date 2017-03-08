﻿using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.Commands;
using WPILib.LiveWindow;
using WPILib.SmartDashboard;
using FRC2017c.Subsystems;
using FRC2017c.Commands;

namespace FRC2017c{
	public class FRC2017c:IterativeRobot{
		public static readonly ExampleSubsystem exampleSubsystem=new ExampleSubsystem();
		public static OI oi;

		Command autonomousCommand;
		SendableChooser chooser;

		public override void RobotInit(){
			oi=new OI();
			autonomousCommand=new ExampleCommand();
			chooser=new SendableChooser();
			chooser.AddDefault("Default Auto",new ExampleCommand());
			SmartDashboard.PutData("Chooser",chooser);
		}

		public override void DisabledPeriodic(){
			Scheduler.Instance.Run();
		}

		public override void AutonomousInit(){
			autonomousCommand=(Command)chooser.GetSelected();

			/*
            string autoSelected = SmartDashboard.GetString("Auto Selector", "Default");
            switch(autoSelected)
            {
            case "My Auto":
                autonomousCommand = new MyAutoCommand();
                break;
            case "Default Auto"
            default:
                autonomousCommand = new ExampleCommand();
                break;
            }
            */
			// schedule the autonomous command (example)
			if(autonomousCommand!=null)autonomousCommand.Start();
		}

		public override void AutonomousPeriodic(){
			Scheduler.Instance.Run();
		}

		public override void TeleopInit(){
			if(autonomousCommand!=null)autonomousCommand.Cancel();
		}
		
		public override void DisabledInit(){

		}

		public override void TeleopPeriodic(){
			Scheduler.Instance.Run();
		}

		public override void TestPeriodic(){
			LiveWindow.Run();
		}
	}
}
