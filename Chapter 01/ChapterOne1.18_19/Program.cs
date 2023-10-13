class Program
{
    static void Main(string[] args)
    {
        MyGenericClass<string> myGenenericClassOne = new MyGenericClass<string>();
        myGenenericClassOne.MyData = "String Value";
        Console.WriteLine($"This is a string {myGenenericClassOne.MyData}");

        MyGenericClass<int> myGenenericClassTwo = new MyGenericClass<int>();
        myGenenericClassTwo.MyData = 10;
        Console.WriteLine($"This is a string {myGenenericClassTwo.MyData}");
    }
}

public class MyGenericClass<T>
{
    public T MyData { get; set; }
}