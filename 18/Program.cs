﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ex18
{
    static void Main(string[] args)
    {

        List<string> listOfString = new List<string>();
        listOfString.Add("m");
        listOfString.Add("n");
        listOfString.Add("o");
        listOfString.Add("p");
        listOfString.Add("q");


        
        

        var _result1 = from x in listOfString
                       select x;
        Console.Write("Here is the list of items : \n");
        foreach (var tchar in _result1)
        {
            Console.WriteLine("Char: {0} ", tchar);
        }

        listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));


        var _result = from z in listOfString
                      select z;
        Console.Write("\nHere is the list after removing the item 'p' from the list : \n");
        foreach (var rChar in _result)
        {
            Console.WriteLine("Char: {0} ", rChar);
        }

        
    }
}
