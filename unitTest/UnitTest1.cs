using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodexMarsTerrain;
using System;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String expected = "1,4,W";
            String[] marsPlateau = "5*5".Split("*"); //5*5
            char[] direction = "FFRFLFLF".ToCharArray(); //FFRFLFLF
            RobotNavigation robot = new RobotNavigation();
            Tuple<String, String> moveRobot = robot.moveRobot(marsPlateau, direction);
            String actual = moveRobot.Item1+","+ moveRobot.Item2;
            Assert.AreEqual(expected, actual);
        }
    }
}
