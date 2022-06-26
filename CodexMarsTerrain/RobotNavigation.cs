using System;
using System.Collections.Generic;
using System.Text;

namespace CodexMarsTerrain
{
    public class RobotNavigation
    {
        int row, column, currentRow = 1, currentcolumn = 1;
        char[] direction;
        string currrentPole = "N";
        string[] mapPole = { "N", "E", "S", "W" };
        Boolean terminate = false;

        public void moveLeft()
        {
            switch (currrentPole)
            {
          
                case "N":
                    currrentPole = mapPole[3]; //W
                    break;
                case "E":
                    currrentPole = mapPole[0]; //N
                    break;
                case "S":
                    currrentPole = mapPole[1]; //E
                    break;
                case "W":
                    currrentPole = mapPole[2]; //S
                    break;
                default:
                    break;

            }

        }
        public void moveRight()
        {
            switch (currrentPole)
            {

                case "N":
                    currrentPole = mapPole[1]; //E
                    break;
                case "E":
                    currrentPole = mapPole[2]; //S
                    break;
                case "S":
                    currrentPole = mapPole[3]; //W
                    break;
                case "W":
                    currrentPole = mapPole[0]; //N
                    break;
                default:
                    break;
            }

        }

        public void moveFront(String poleDir)
        {
            switch (poleDir)
            {
                case "N":
                    if (currentRow < row)
                    {

                        currentRow = currentRow+1;
                    }
                    else
                    {
                        terminate = true;
                    }
                    break;
                case "E":
                    if (currentcolumn < column)
                    {
                        currentcolumn = currentcolumn+1;
                    }
                    else
                    {
                        terminate = true;
                    }
                    break;
                case "S":
                    if (currentRow > 1)
                    {
                        currentRow = currentRow - 1;

                    }
                    else
                    {
                        terminate = true;
                    }
                    break;
                case "W":
                    if (currentcolumn > 1)
                    {

                        currentcolumn = currentcolumn - 1;
                    }
                    else
                    {
                        terminate = true;
                    }
                    break;
                default:
                    break;

            }

        }

        public Tuple<String, String> moveRobot(String[] marsPlateau, char[] direction)
        {
            this.column = Int32.Parse(marsPlateau[0]);
            this.row = Int32.Parse(marsPlateau[1]);
            this.direction = direction;
            foreach (char dir in direction)
            {
              //  Console.WriteLine(dir + "row:"+currentRow + "cm:"+currentcolumn);

                switch (dir.ToString())
                {
                    case "F":
                        moveFront(currrentPole);
                        break;
                    case "L":
                        moveLeft();
                        break;
                    case "R":
                        moveRight();
                        break;
                    default:
                        break;
                }

                if (terminate == true)
                {
                    Console.WriteLine("robot reaches the limits of the plateau the command was ignored.");
                    terminate = false;

                }
                    

            }
            string retunValue = currentcolumn.ToString() + "," + currentRow.ToString(); 
            return Tuple.Create(retunValue, currrentPole);
        }
    }
}
