namespace ChapterOneOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperatorExample();
            AssignmentOperatorExample();
            EqualOperatorExample();
            OrOperatorExample();
            AndOperatorExample();
            UnaryOperatorExample();
            TernaryOperatorexample();
            CompoundOperatorExample();
        }

        static void ArithmeticOperatorExample()
        {
            int number1 = 50;
            int number2 = 25;

            int totalSubstraction = number1 - number2; // 25
            int totalAddition = number1 - number2; // 75
            int totalMultiplication = number1 * number2; //1.250
            int totalDivision = number1 / number2; // 2

            Console.WriteLine("Total substraction: " + totalSubstraction);
            Console.WriteLine("Total addition: " + totalAddition);
            Console.WriteLine("Total multiplication: " + totalMultiplication);
            Console.WriteLine("Total division: " + totalDivision);

        }

        static void AssignmentOperatorExample()
        {
            string myMessage = "My variable is assigned with this value";

            int myNumber = 5;

            int x, y, z;

            x = y = z = 10;

            Console.WriteLine("My message: " + myMessage);
            Console.WriteLine("My Number: " + myNumber);
            Console.WriteLine("Variable X: " + x);
            Console.WriteLine("Variable Y: " + y);
            Console.WriteLine("Variable Z: " + z);

        }

        static void EqualOperatorExample()
        {
            DateTime today = DateTime.Now;

            if (today.Day == 4)
            {
                Console.WriteLine("This is the day number four");
            }
        }

        static void OrOperatorExample()
        {
            var currentDayOfWeek = DateTime.Now.DayOfWeek;

            if (currentDayOfWeek == DayOfWeek.Monday || currentDayOfWeek == DayOfWeek.Tuesday)
            {
                //MY CUSTOM LOGIC IMPLEMENTATION
            }
        }

        static void AndOperatorExample()
        {
            var currentDayOfWeek = DateTime.Now.DayOfWeek;
            var currentHour = DateTime.Now.Hour;

            if (currentDayOfWeek == DayOfWeek.Saturday || currentHour > 0)
            {
                //MY CUSTOM LOGIC IMPLEMENTATION
            }
        }

        static void UnaryOperatorExample()
        {
            int numberExample = 25;

            numberExample++; //Variable has the value 26
            numberExample--; //Variable has the value 25 again
            numberExample--; //Variable has the value 24
        }

        static void TernaryOperatorexample()
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;

            string message = dayOfWeek == DayOfWeek.Monday ? "Today is Monday" : "Today is not Monday";

            Console.WriteLine(message);
        }

        static void CompoundOperatorExample()
        {
            int firstExample = 25;
            firstExample += 10; // 25 + 10

            int secondExample = 15;
            secondExample *= 5;  //15 * 5 
        }
    }
}