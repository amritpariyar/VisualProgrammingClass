using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

  //private, protected, internal, public, sealed, abstract
  internal class StudentInfo
  {
    //fields
    private string name;
    private int age;

    //properties
    public string Name
    {
      get
      {
        return "Mister "+ name;
      }
      set
      {
        name = value;
      }
    }
    //public string Name { get; set; }
    public int Age
    {
      get
      {
        return age;
      }
      set
      {
        age = value;
      }
    }

    public string GetInfo()
    {
      return $"Name: {Name}, Age: {Age}";
    }

    //constructor
    //public StudentInfo(string name, int age)
    //{
    //  Name = name;
    //  Age = age;
    //}

    //methods
    //destructor
  }
}
