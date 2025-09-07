using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class ArrayLab
  {
    //pascal case PascalCase
    //camel case  camelCase
    //snake case  snake_case
    //upper case  UPPER_CASE
    //lower case  LOWER_CASE
    public void myArray()
    {
      int[] myArray = new int[] { 12, 34, 56, 7, 89, 90, 120 };

      int[] myArray2 = new int[5]; //declaration and instantiation
      myArray2[0] = 23;
      myArray2[1] = 45;
      myArray2[2] = 67;
      myArray2[3] = 89;
      myArray2[4] = 90;

      char[] myArray3 = new char[] { 'a', 'b', 'c', 'd', 'e' };
      string[] myArray4 = new string[] { "apple", "banana", "cherry", "date" };

      /* for(int i=0; i< myArray.Length; i++)
      {
          Console.WriteLine(myArray[i]);
      } */

      int index = 0;
      foreach (var item in myArray)
      {
        int itemValue = item; //12
        Console.Write("{0}:{1} == {2}\t", itemValue, index, itemValue + index);
        index++;

        // 0:12  1:34  2:56 3:7  4:89  5:90 6:120
        //12:0 34:1 56:2 7:3 89:4 90:5 120:6
      }

    }

    public void DynamicSetArray()
    {
      int[] myArray = new int[3];

      for (int i = 0; i < 3; i++)
      {
        string userInput = Console.ReadLine();
        int userValue = int.Parse(userInput);
        myArray[i] = userValue;
      }

      foreach (var item in myArray)
      {
        Console.Write("{0}\t", item);
      }

    }

    public void DynamicCharArray()
    {
      char[] myArray = new char[6];

      for (int i = 0; i < myArray.Length; i++)
      {
        string userInput = Console.ReadLine();
        char userValue = (char)userInput[0];
        myArray[i] = userValue;
      }

      int[] myArray2 = new int[] { 5, 3, 8, 1, 2 };
      Array.Sort(myArray2);

      //Array
      //List
      //Dictionary {key, value}
      //Enumerable
      // s u n d a y
      // y a d n u s
      // a d n s u y
      char[] sortedArray = myArray.Reverse().ToArray();
      Array.Sort(sortedArray);

      foreach (var item in sortedArray)
      {
        Console.Write(item);
      }

    }

    public void SearchArray()
    {
      int[] myArray = new int[] { 12, 34, 56, 7, 89, 90, 120 };
      Console.WriteLine("Enter search value:");

      string userInput = Console.ReadLine();
      int searchValue = int.Parse(userInput);
      bool isFound = false;

      int index = 0;
      foreach (var item in myArray)
      {
        if (item == searchValue)
        {
          isFound = true;
          break;
        }

        index++;
      }
      //Ctrl+ k + c  //comment
      //Ctrl+ k + u  //uncomment
      //Ctrl+ k + d  //format code
      if (isFound)
      {
        Console.WriteLine("Value found in index: " + index);
        Console.WriteLine("Value found in index: {0}", index);
        Console.WriteLine($"Value found in index: {index}");
      }
      else
      {
        Console.WriteLine("Value not found");
      }
    }

  }
}
