using System.Reflection.Metadata.Ecma335;

namespace Izpitvane21._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int br = 0;
            int sum = 0;
            float avarage = 0;

        Console.WriteLine(string.Join(",",arr));

            for (int i = 0; i < arr.Length; i++)
            {
                br++;
                sum = sum + arr[i];
            }

            AverageArr(avarage, sum, br);

            /*b*/
            
            Console.WriteLine($"Avarage:{avarage}");
        }
        //a
        private static float AverageArr(float avarage, int sum, int br)
        {

            avarage = sum / br;
        }
        
    }
}