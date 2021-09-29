using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testingSortingTimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        { 
            double total = 0;
            using (StreamWriter file =
           new StreamWriter(@"C:\Users\4matt\OneDrive - York College\CS\project\testingSortingTimeComplexity\timeFolder\tests.txt", false))
            {
                file.WriteLine("");
            }
            for (int x = 0; x< 1000; x++)
            {
                int arraySize = 7000;   //sets the size of the array to the number in the array size text box chosen by the user
                int[] arrayData = new int[arraySize];   //creates the array with the size made above
                int min = 1;    //sets min number to 1
                int max = 100;     //sets max number to 100

                Random randNum = new Random();  //initialises the random class
                for (int k = 0; k < arrayData.Length; k++)  //for the length of the array
                {
                    arrayData[k] = randNum.Next(min, max);  //generates a random number between 1 and 100 for each position in the array. for example size 4: 3,87,14,8
                }

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Reset();
                stopwatch.Start();
                int temp;
                for (int i = 0; i < arrayData.Length - 1; i++) //loop will repeat as many times as length of array -1
                {
                    for (int j = 0; j < arrayData.Length - 1; j++) //loop will repeat as many times as length of array -1
                    {
                        if (arrayData[j] > arrayData[j + 1])    //if first number is larger than second number
                        {
                            temp = arrayData[j];    //sets temp to the first (larger) number
                            arrayData[j] = arrayData[j + 1];     //sets the first number to the second (smaller) number
                            arrayData[j + 1] = temp;    //sets the second number to the temp number (first number) which comletes the swap
                        }
                    }
                }
                stopwatch.Stop();
                double time = stopwatch.ElapsedMilliseconds;

                total += time;

                string say = "Time in ms: " + time + "\n";
                Console.WriteLine(say+" ");

                using (StreamWriter file =
                         new StreamWriter(@"C:\Users\4matt\OneDrive - York College\CS\project\testingSortingTimeComplexity\timeFolder\tests.txt", true))
                {
                    file.Write(time+" ");
                }
                
            }
            double averageTime = total / 1000;
            

            //string displayArray = string.Join(",", arrayData);
            //Console.WriteLine(displayArray);
            Console.WriteLine("done");
            Console.WriteLine("Average time in ms was "+ averageTime);
            Process.Start("notepad", @"C:\Users\4matt\OneDrive - York College\CS\project\testingSortingTimeComplexity\timeFolder\tests.txt");
            Console.ReadLine();

        }
    }
}