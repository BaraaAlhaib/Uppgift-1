using System;

class Program
{
    static void Main(string[] args)
    {

        string Input1 = "THE RAIN IN SPAIN PLAIN";
        string Input2 = "IN THE RAIN AND THE SNOW";
        string Input3 = "THE RAIN IN SPAIN IN THE PLAIN";


        bool output1 = HasDuplicates(Input1);
        bool output2 = HasDuplicates(Input2);
        bool output3 = HasDuplicates(Input3);

        if (output1)
        {
            Console.WriteLine(Input1);
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(Input1);
            Console.WriteLine("Yes");
        }

        if (output2)
        {
            Console.WriteLine(Input2);
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(Input2);
            Console.WriteLine("Yes");
        }

        if (output3)
        {
            Console.WriteLine(Input3);
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(Input3);
            Console.WriteLine("Yes");
        }
    }


    static bool HasDuplicates(string input)
    {
        string[] words = input.Split(' ');
        bool hasDuplicates = words.GroupBy(x => x).Any(g => g.Count() > 1);
        return hasDuplicates;
    }
}