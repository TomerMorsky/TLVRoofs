using System;
//Tomer Morsky(ID: 322622382) and Naor Hamisha(ID: 211899703)
namespace TLVRoofs
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_BUILDINGS = 30;
            var buildingsHeights = new int[NUMBER_OF_BUILDINGS];

            for (int i = 0; i < NUMBER_OF_BUILDINGS; i++)
            {
                Console.WriteLine("Enter a number");
                buildingsHeights[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("The Array:");
            PrintArray(buildingsHeights);

            var observedBuildings = TLVRoofChecker.GetViewedBuildings(buildingsHeights);
            Console.WriteLine();
            PrintBlockedBuildings(observedBuildings);
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void PrintBlockedBuildings(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var tamplate = "Building number: {0} is blocked by building: {1}";
                Console.WriteLine(tamplate, i + 1, arr[i]);
            }
        }
    }
}
