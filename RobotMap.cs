﻿using WPILib;

namespace FRC2017i{
	public class RobotMap{
		/*
			  - Motor Definition
			  ========FRONT========
			  Left4          Right2
			  Left3          Right1
			  ========REAR=========
		*/
		public static int motorFrontLeft=4;
		public static int motorRearLeft=3;
		public static int motorFrontRight=2;
		public static int motorRearRight=1;
		public static int motorBallReady=6;
		public static int motorBallShoot=5;

		/* Driving Definition */
		public static bool drivingSquaredInput=true;
		public static double drivingSpeedConstant=0.6;

		/* Joystick Port Definition */
		public static int joystickDriving=0;
		/* Joystick Axis Binding Definition */
		public static int joystickDrivingLeverX=0;
		public static int joystickDrivingLeverY=1;
		public static int joystickDrivingBallReadyClockwise=2;
		public static int joystickDrivingBallReadyCounterClockwise=3;
		/* Joystick Button Binding Definition */
		public static int joystickDrivingStopAll=3;
		public static int joystickDrivingBallShoot=2;
	}
}
