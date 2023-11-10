//using System;

//class SquaringArray
//{
//    private int[] arr;

//    public SquaringArray(int size)
//    {
//        arr = new int[size];
//    }

//    public int this[int index]
//    {
//        get
//        {
//            if (index >= 0 && index < arr.Length)
//            {
//                return arr[index];
//            }
//            else
//            {
//                throw new IndexOutOfRangeException("Index is out of range.");
//            }
//        }
//        set
//        {
//            if (index >= 0 && index < arr.Length)
//            {
//                arr[index] = value * value;
//            }
//            else
//            {
//                throw new IndexOutOfRangeException("Index is out of range.");
//            }
//        }
//    }

//    public void DisplayArray()
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.WriteLine($"Element at index {i}: {arr[i]}");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        SquaringArray squares = new SquaringArray(5);

//        squares[0] = 2; // Sets value at index 0 to 4
//        squares[1] = 3; // Sets value at index 1 to 9

//        Console.WriteLine($"Value at index 0: {squares[0]}"); // Retrieves the squared value (4)
//        Console.WriteLine($"Value at index 1: {squares[1]}"); // Retrieves the squared value (9)

//        squares.DisplayArray(); // Displays all elements in the array

//        // Accessing an out-of-range index will throw an exception
//        try
//        {
//            squares[10] = 5; // Throws an IndexOutOfRangeException
//        }
//        catch (IndexOutOfRangeException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }

//        Console.ReadKey();
//    }
//}
