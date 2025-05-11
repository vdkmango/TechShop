//using Techshop;

//Laptop[] laptops = new Laptop[]
//{
//    new Laptop("", Brand.Acer, 5700, 32, 1, "600 px");
//    new Laptop("", Brand.Acer, 5700, 32, 1, "600 px");
//    new Laptop("", Brand.Acer, 5700, 32, 1, "600 px");
//    new Laptop("", Brand.Acer, 5700, 32, 1, "600 px");
//};

//try
//{
//    int x = 3;
//    int y = 2;
//    int z = x / y;
//    Console.WriteLine("Try block.");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally Block.");
//}

//int[] ints = new int[3];
//ints[4] = 4;


//using (MyResource res = new MyResource())
//{

//}
//class MyResource : IDisposable
//{

//    public void Use() => Console.WriteLine("Resource used.");
//    public void Dispose() => Console.WriteLine("Cleaning up.");
//}


using (TemporaryLogger temp = new TemporaryLogger())
{
    
}
class TemporaryLogger : IDisposable
{
    public TemporaryLogger()
    {
        Console.WriteLine("Logger Opened");
    }
    public void Dispose() => Console.WriteLine("Logger Closed");
}