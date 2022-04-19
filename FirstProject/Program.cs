using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class Program
{

    //static void Main()
    //{
    //    Task task = new Task(CallMethod);
    //    task.Start();
    //    task.Wait();
    //    Console.ReadLine();
    //}

    //static async void CallMethod()
    //{
    //    string filePath = "E:\\sampleFile.txt";
    //    Task<int> task = ReadFile(filePath);

    //    Console.WriteLine(" Other Work 1");
    //    Console.WriteLine(" Other Work 2");
    //    Console.WriteLine(" Other Work 3");

    //    int length = await task;
    //    Console.WriteLine(" Total length: " + length);

    //    Console.WriteLine(" After work 1");
    //    Console.WriteLine(" After work 2");
    //}

    //static async Task<int> ReadFile(string file)
    //{
    //    int length = 0;

    //    Console.WriteLine(" File reading is stating");
    //    using (StreamReader reader = new StreamReader(file))
    //    {
    //        // Reads all characters from the current position to the end of the stream asynchronously
    //        // and returns them as one string.
    //        string s = await reader.ReadToEndAsync();

    //        length = s.Length;
    //    }
    //    Console.WriteLine(" File reading is completed");
    //    return length;
    //}
    static void Main(string[] args)
    {
        Console.WriteLine("Task exicution Begins");
        Method3();
        Method1();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("loop Is running stepNumber : " + i);
        }
        Console.ReadLine();
    }
    public static async void Method1()
    {
        var value = await Method2();
        Console.WriteLine("output of Method2 : " + value); ;
    }
    public static Task<int> Method2()
    {
        return Task.Run(() =>
        {
            Thread.Sleep(5000);
            return 1;
        });
    }
    public static async void Method3()
    {
        var value = await Method4();
        Console.WriteLine("Method3 is Working :" + value);
    }
    public static Task<string> Method4()
    {

        return Task.Run(() =>
        {
            Thread.Sleep(4000);
            return "Method with high Time 6000! ";
        });
    }

}