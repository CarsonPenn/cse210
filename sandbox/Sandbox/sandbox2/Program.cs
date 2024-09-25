using System.Globalization;

namespace sandbox2;

class Program
{
    static void Main(string[] args)
    {
        List<double> x;
        x=[24, 25, 26] ;
        // x.Add(24.5) ;
        // x.Add(30);
 

        Console.WriteLine("Hello, World!");

        double input = -1;
        while(input !=0)
        {
            Console.Write("Enter something: ");
            string input_string = Console.ReadLine();
            input = double.Parse(input_string);
            x.Add(input);
        }
 

        foreach(double number in x)
        {
            Console.WriteLine(number);
        
        }
    }
}


// myList.Add()

// List<> myList = new 