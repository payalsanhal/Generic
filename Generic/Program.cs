using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // create a GenericCollection to hold integers
        GenericCollection<int> intArray = new GenericCollection<int>();
        intArray.Add(1);

        // create a GenericCollection to hold strings
        GenericCollection<string> stringArray = new GenericCollection<string>();
        stringArray.Add("Humber");

        int x = 1;
        int y = 2;

        // specifying parameter types
        SwapValue<int>(ref x, ref y);


        // without specifying parameter types
        SwapValue(ref x, ref y);


        //string first = "Joe";
        //string last = "Smith";
        //SwapValue<string>(ref first, ref last);


        Console.WriteLine("x={0}, y={1}", x, y);
    }



    // generic method with a contraint
    static void SwapValue<T>(ref T x, ref T y) where T : struct
    {
        Console.WriteLine("Generic method used.");
        T temp;
        temp = x;
        x = y;
        y = temp;
    }


    // overriden SwapValue specialized for int
    static void SwapValue(ref int x, ref int y)
    {

        Console.WriteLine("Non generic method used");
        int temp;
        temp = x;
        x = y;
        y = temp;
    }


}


// Using generics you can have one class handle mutiple data types
public class GenericCollection<T>
{
    private T[] _items = new T[50];

    private int _numitems = 0;

    public void Add(T item)
    {
        if (_numitems + 1 < 50)
        {
            _items[_numitems] = item;
            _numitems++;
        }
    }
}



