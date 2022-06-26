using System;

namespace CodexMarsTerrain
{
   public class Program
    {
        public static void Main(string[] args)
        {

            String[] marsPlateau = Console.ReadLine().Split("*"); //5*5
            char[] direction = Console.ReadLine().ToCharArray(); //FFRFLFLF
            RobotNavigation robot = new RobotNavigation();
            Tuple<String, String> moveRobot = robot.moveRobot(marsPlateau, direction);
            Console.WriteLine(moveRobot.Item1+","+ moveRobot.Item2);
            Console.ReadLine();

        }
    }
}
