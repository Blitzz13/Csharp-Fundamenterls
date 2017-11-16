using System;
using System.Linq;

namespace ParkingSystem
{
    class ParkingSystem
    {
        static bool[,] parkingLot;
        static void Main(string[] args)
        {
            var parkingSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            parkingLot = new bool[parkingSize.Last(), parkingSize.First()];

            string carInitialData = Console.ReadLine();
            while (carInitialData != "stop")
            {
                var carDataArr = carInitialData.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
                int entryRow = carDataArr.ElementAt(0);
                int desiredCol = carDataArr.ElementAt(2);
                int desiredRow = carDataArr.ElementAt(1);

                int stepsCount = (desiredRow - entryRow) >= 0 ? (desiredRow - entryRow) + 1 : (entryRow - desiredRow) + 1;


                int leftPosition = 0;
                int rightPosition = 0;

                if (!parkingLot[desiredCol, desiredRow])
                {
                    parkingLot[desiredCol, desiredRow] = true;
                    stepsCount += desiredCol;
                    Console.WriteLine(stepsCount);
                    carInitialData = Console.ReadLine();
                    continue;
                }
                leftPosition = CheckLeft(desiredRow, desiredCol);
                rightPosition = CheckRigth(desiredRow, desiredCol);

                if (leftPosition <= 0 && rightPosition < 0)
                {
                    Console.WriteLine("Row {0} full", desiredRow);
                    carInitialData = Console.ReadLine();
                    continue;
                }
                if (leftPosition <= 0)
                {
                    stepsCount += rightPosition;
                    parkingLot[rightPosition, desiredRow] = true;
                }
                else if (rightPosition < 0)
                {
                    stepsCount += leftPosition;
                    parkingLot[leftPosition, desiredRow] = true;
                }
                else
                {
                    if (Math.Abs(leftPosition - desiredCol) <= Math.Abs(rightPosition - desiredCol))
                    {
                        stepsCount += leftPosition;
                        parkingLot[leftPosition, desiredRow] = true;
                    }
                    else
                    {
                        stepsCount += rightPosition;
                        parkingLot[rightPosition, desiredRow] = true;
                    }
                }

                Console.WriteLine(stepsCount);

                carInitialData = Console.ReadLine();
            }
        }

        private static int CheckRigth(int desiredRow, int desiredCol)
        {
            int resultIfAllBusy = -1;
            for (int i = desiredCol + 1; i < parkingLot.GetLength(0); i++)
            {
                if (!parkingLot[i, desiredRow])
                {
                    return i;
                }
            }

            return resultIfAllBusy;
        }

        private static int CheckLeft(int desiredRow, int desiredCol)
        {
            int resultIfAllBusy = 0;
            for (int i = desiredCol; i >= 0; i--)
            {
                if (!parkingLot[i, desiredRow])
                {
                    return i;
                }
            }

            return resultIfAllBusy;
        }
    }
}

