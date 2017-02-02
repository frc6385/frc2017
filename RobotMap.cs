using WPILib;

namespace FRC2017i{
	public class RobotMap{
		/*
			  - Motor Definition
			  ========FRONT========
			  Left4          Right2
			  Left3          Right1
			  ========REAR=========
		*/
		/* Driving Definition */
		public static int motorFrontLeft=4;
		public static int motorRearLeft=3;
		public static int motorFrontRight=2;
		public static int motorRearRight=1;
		public static bool drivingSquaredInput=true;
		public static double drivingSpeedConstant=1.00;

		/* Joystick Port Definition */
		public static int joystickDriving=0;
		/* Joystick Axis Binding Definition */
		public static int joystickDrivingLeverX=0;
		public static int joystickDrivingLeverY=1;
		public static int joystickDrivingClockwise=2;
		public static int joystickDrivingCounterClockwise=3;
		/* Joystick Button Binding Definition */
		public static int joystickDrivingStopAll=3;
	}
}
