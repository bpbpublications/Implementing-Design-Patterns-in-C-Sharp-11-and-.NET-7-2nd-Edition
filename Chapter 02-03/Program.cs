//Figure 1.41

global using DesignPatternBook.Chapter1;

//Figure 1.46

int [] myList = new int [] { 1, 2, 3 };

Console.WriteLine(myList is [1, 2, 3]);  //true
Console.WriteLine(myList is [1]);  //false



//Figure 1.47


string rawMessage = """
    This is a message with new line, whitespace 
    and other characters, 
    including "quotes" as part of the content


""";

Console.WriteLine(rawMessage);





//Figure 1.13

string myMessage = "I'm reading the Design Patterns with .NET book";
double dotNetVersion = 7.0;

Console.WriteLine($"My Message { myMessage}");
Console.WriteLine($".NET Version: {dotNetVersion}");


//Figure 1.14

bool featureEnabled = true;
Console.WriteLine($"Feature enabled: {featureEnabled}");

//Figure 1.15

decimal dollarValue = 3.5m; //Dollar value
decimal price = 103.45m; //Product price
float floatValue = 1.07f; //Float value
double scale = 67.5; //Double value

Console.WriteLine($"Dollar value: {dollarValue}");
Console.WriteLine($"Price: {price}");
Console.WriteLine($"Float value: {floatValue}");
Console.WriteLine($"Scale: {scale}");

//Figure 1.16

string[] daysOfWeek = { 
    "Monday",
    "Tuesday",
    "Wednesday",
    "Friday",
    "Saturday",
    "Sunday"
};

//Figure 1.17

List<string> daysOfWeekList = new List<string>();
daysOfWeekList.Add("Monday");
daysOfWeekList.Add("Tuesday");
daysOfWeekList.Add("Wednesday");
daysOfWeekList.Add("Thursday");
daysOfWeekList.Add("Friday");
daysOfWeekList.Add("Saturday");
daysOfWeekList.Add("Sunday");






//Figure 1.19

MyGenericClass<string> myGenericClassOne = new MyGenericClass<string>();
myGenericClassOne.MyData = "String Value";
Console.WriteLine($"This is a string:{myGenericClassOne.MyData}");

MyGenericClass<int> myGenericClassTwo = new MyGenericClass<int>();
myGenericClassTwo.MyData = 10;
Console.WriteLine($"This is an integer:{myGenericClassTwo.MyData}");

////Figure 1.21

//int timesExecuted = 0;

//while(timesExecuted < 25)
//{
//    Console.WriteLine($"Time(s) executed:{timesExecuted}");
//    timesExecuted++;
//}


////Figure 1.22

//timesExecuted = 0;

//do
//{
//    Console.WriteLine($"Time(s) executed:{timesExecuted}");
//    timesExecuted++;

//}
//while (timesExecuted < 25);


//Figure 1.23

for(int timesExecuted = 0; timesExecuted < 10; timesExecuted++)
{
    Console.WriteLine($"Time(s) executed:{timesExecuted}");
}


//Figure 1.24

List<string> daysOfWeekCollection = new List<string>();
daysOfWeekCollection.Add("Monday");
daysOfWeekCollection.Add("Tuesday");
daysOfWeekCollection.Add("Wednesday");
daysOfWeekCollection.Add("Thursday");
daysOfWeekCollection.Add("Friday");
daysOfWeekCollection.Add("Saturday");
daysOfWeekCollection.Add("Sunday");

foreach(string day in daysOfWeekCollection)
{
    Console.WriteLine($"Day of Week: {day}");
}


//Figure 1.25

int number1 = 50;
int number2 = 25;

int totalSubstraction = number1 - number2; //25
int totalAddition = number1 + number2; // 75
int totalMultiplication = number1 * number2; //1,250
int totalDivision = number1 / number2; //2

Console.WriteLine($"Total subtraction: {totalSubstraction}");
Console.WriteLine($"Total addition: {totalAddition}");
Console.WriteLine($"Total multiplication: {totalMultiplication}");
Console.WriteLine($"Total division: {totalDivision}");


//Figure 1.26

string customMessage = "The variable is assigned with this value";
int number = 5;
int x, y, z;

x = y = z = 10;

Console.WriteLine($"Custom message: {customMessage}");
Console.WriteLine($"Number value: {number}");
Console.WriteLine($"Variable x: {x}");
Console.WriteLine($"Variable y: {y}");
Console.WriteLine($"Variable z: {z}");


//Figure 1.27

DateTime today = DateTime.Now;

if(today.Day == 4)
{
    Console.WriteLine("This is the day number four");
}



//Figure 1.28

DateTime currentDay = DateTime.Now;

if(currentDay.DayOfWeek == DayOfWeek.Monday)
{
    Console.WriteLine("Today is Monday");
}

if(currentDay.Day != 25)
{
    Console.WriteLine("Day is different from 25");
}

if(currentDay.Day < 25)
{
    Console.WriteLine("Day is less than 25");
}

if (currentDay.Day > 25)
{
    Console.WriteLine("Day is greater than 25");
}

if (currentDay.Day <= 25)
{
    Console.WriteLine("Day is equal or less than 25");
}

if (currentDay.Day >= 25)
{
    Console.WriteLine("Day is equal or greater than 25");
}



//Figure 1.29

var currentDayOfWeek = DateTime.Now.DayOfWeek;

if(currentDayOfWeek == DayOfWeek.Monday || currentDayOfWeek == DayOfWeek.Tuesday)
{
    //HERE GOES ANY CUSTOM IMPLEMENTATION IF THE CONDITION IS TRUE
}



//Figure 1.30

var dayOfWeekNow = DateTime.Now.DayOfWeek;
var currentHour = DateTime.Now.Hour;


if(dayOfWeekNow == DayOfWeek.Saturday &&  currentHour > 6)
{
    //HERE GOES ANY CUSTOM IMPLEMENTATION IF THE CONDITION IS TRUE

}


//Figure 1.31

int numberExample = 25;

numberExample++; //variable has now the value of 26

numberExample--; //variable has now the value of 25 again

numberExample--; //variable has now the value of 24



//Figure 1.32

string message = DateTime.Now.DayOfWeek == DayOfWeek.Monday ?
    "Today is Monday" : "Today is not Monday";




//Figure 1.33

int firstExample = 25;
firstExample += 10; //25 + 10

int secondExample = 15;
secondExample *= 5; // 15 * 5

//Figure 1.34

var currentMonth = DateTime.Now.Month;

if(currentMonth == 1)
{
    Console.WriteLine("This is the month of January");
}
else
{
    Console.WriteLine("This is NOT the month of January");
}

if (DateTime.Now.Day == 1)
    Console.WriteLine("Today is the first day of the month");


//Figure 1.35

switch (DateTime.Now.Month)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
}

//Figure 1.36

if(DateTime.Now.Month == 1)
{
    Console.WriteLine("January");
}
else
{
    if(DateTime.Now.Month == 2)
    {
        Console.WriteLine("February");
    }
    else
    {
        if(DateTime.Now.Month == 3)
        {
            Console.WriteLine("March");
        }
        else
        {
            if( DateTime.Now.Month == 4)
            {
                Console.WriteLine("April");
            }
        }
    }
}

//Figure 1.37, Figure 1.38 and Figure 1.39

try
{
    int age = int.Parse(Console.ReadLine());

    if (age < 0)
    {
        throw new ArgumentOutOfRangeException("The age must be greater than 0");
    }

    SavePerson();
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"A valid value for the age need to be provided. Error details: {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Unexpected error. Details: {ex.Message}");
}
finally
{
    CloseDatabaseConnection();
}



void CloseDatabaseConnection()
{
    //Custom implementation to close database connection
}

void SavePerson()
{
    //Custom implementation to save a user on the database
}







//Figure 1.18

public class MyGenericClass<T>
{
    public T? MyData { get; set; }
}


//Figure 1.20

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Creation { get; set; }
    public Author Author { get; set; }
    public string Summary { get; set; }
    public int IsbnNumber { get; set; }
}



public class Author
{
   
}


//Figure 1.44
public class MyGenericAttribute<T> : Attribute { }


//Figure 1.45

public class MyGenericClass
{
    [MyGenericAttribute<string>()]
    public string Method() => default;
}





