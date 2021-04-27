using System;
using System.Linq;
namespace ARRAY_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Methods in array
            //Reverse

           //  string[]students={"Ada","Jay","Ray","Gary"};
            // Console.WriteLine(students.IsFixedSize);
            // Array.Reverse(students);
            // Console.WriteLine(students[1]);

            //Using te arrray.find

        //    Console.WriteLine(Array.Find(students,(e =>e.Contains("Ga"))));
        //     Console.WriteLine(Array.Find(students,(e =>e.EndsWith("y"))));
           //  Console.WriteLine(Array.Find(students,(e =>e.StartsWith("Ga"))));

         //  Console.WriteLine(Array.FindIndex(students,0,6,(e =>e.Contains("y"))));
         //  Console.WriteLine(Array.IndexOf(students,"Ray"));

     //     int [] strangeNo={1,2,3,4,5,6};
        //  Array.Sort(strangeNo);
        //  Array.Reverse(strangeNo);

        //  foreach (var i in strangeNo)
        //  {
        //      Console.WriteLine(i);
        //  }
         
            //  Array.Clear(strangeNo, 0, 4);
            //  Console.WriteLine(strangeNo[1]);

            //Basic excerise:
           // put the following elements in an array and reverse the output
     //  ---23,47,89,64,102,90,2,5,10

//      int[] allNos={23,47,89,64,102,90,2,5,10};

//      Array.Sort(allNos);
     
//   //   Array.Reverse(allNos);

//      foreach(int number in allNos)
//      {
//      Console.WriteLine(number + 5);
//      }
//   int[] allNos={23,47,89,64,102,90,2,5,10};

//      Array.Sort(allNos);
     
  //   Array.Reverse(allNos);

    //  foreach(int number in allNos)
    //  {
    //  Console.WriteLine(number + 5);
    //  }

   int[] arrayOfNumbers = {23,47,89,64,102,90,2,5,10};

   int allNumbers = arrayOfNumbers.Sum();
   Console.WriteLine($"\nThe Total of all numbers = {allNumbers}");
    
         }

        }
    }

