
namespace HelloWorld {
    // Our class name is Program
    public class Program
    {

        // ------ FUNCTIONS ------


        private static bool GT10(int val)
        {
            return val > 10;
        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                // We are throwing an exception because
                // you can't divide by zero
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        private static void SayHello()
        {
            // Defines a variable that will store a string
            // of characters
            string name = "";

            Console.Write("What is your name : ");

            // Save the input the user provides
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }

        // If you assign a value then it is optional to
        // pass
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        // ----- OUT PARAMETER -----
        // A parameter marked with out must be assigned
        // a value in the method
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // ----- PASS BY REFERENCE -----
        // If a variable is passed by reference changes
        // to its value in the method effect it outside
        // of the method
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // ----- PARAMS -----
        // The params array must be the last parameter
        // in the list
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        // ----- NAMED PARAMETERS -----
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        // ----- METHOD OVERLOADING -----
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                cc, (int)cc);
        }

        // ------ END OF FUNCTIONS ------

        // ------ ENUMS ------
        // An enum is a custom data type with
        // key value pairs. They allow you to
        // use symbolic names to represent data
        // The first number is 0 by default unless
        // you change it
        // You can define the underlying type
        // or leave it as int as default

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        // Execution begins in the main function
        // static means this function can run without
        // creating an object
        // void means that this function doesn't return a value
        // args represent data that can be passed to our program
        // from the command line as an array of strings
        static void Main(string[] args)
        {

            // Replace a string
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            // Clear a string builder
            sb2.Clear();

            sb2.Append("Random Text");

            // Are objects equal
            Console.WriteLine(sb.Equals(sb2));

            // Insert at an index
            sb2.Insert(11, " that's Great");

            Console.WriteLine("Insert : {0}", sb2.ToString());

            // Remove number of characters starting at index
            sb2.Remove(11, 7);

            Console.WriteLine("Remove : {0}", sb2.ToString());

            // ---------- FUNCTIONS / METHODS ----------
            // Functions are used to avoid code duplication, provides
            // organization and allows use to simulate different
            // systems
            // <Access Specifier> <Return Type> <Method Name>(Parameters)
            // { <Body> }

            // Access Specifier determines whether the function can
            // be called from another class
            // public : Can be accessed from another class
            // private : Can't be accessed from another class
            // protected : Can be accessed by class and derived classes

            SayHello();

            // ----- PASSING BY VALUE -----
            // By default values are passed into a method
            // and not a reference to the variable passed
            // Changes made to those values do not effect the
            // variables outside of the method
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}",
                GetSum(x, y));

            // Even though the value for x changed in
            // method it remains unchanged here
            Console.WriteLine("x = {0}",
                x);

            // ----- OUT PARAMETER -----
            // You can pass a variable as an output
            // variable even without assigning a
            // value to it
            int solution;

            // A parameter passed with out has its
            // value assigned in the method
            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}",
                solution);

            // ----- PASS BY REFERENCE -----
            int num3 = 10;
            int num4 = 20;

            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num3, num4);

            Swap(ref num3, ref num4);

            Console.WriteLine("After Swap num1 : {0} num2 : {1}", num1, num2);

            // ----- PARAMS -----
            // You are able to pass a variable amount
            // of data of the same data type into a
            // method using params. You can also pass
            // in an array.
            Console.WriteLine("1 + 2 + 3 = {0}",
                GetSumMore(1, 2, 3));

            // ----- NAMED PARAMETERS -----
            // You can pass values in any order if
            // you used named parameters
            PrintInfo(zipCode: 15147,
                name: "Derek Banas");

            // ----- METHOD OVERLOADING -----
            // You can define methods with the same
            // name that will be called depending on
            // what data is sent automatically
            Console.WriteLine("5.0 + 4.0 = {0}",
                GetSum2(5.0, 4.5));

            Console.WriteLine("5 + 4 = {0}",
                GetSum2(5, 4));

            Console.WriteLine("5 + 4 = {0}",
                GetSum2("5", "4"));


            // ---------- DATETIME & TIMESPAN ----------

            // Used to define dates
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            // You can change values
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            // TimeSpan
            // Used to define a time
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            // Change values
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            // ----- ENUM -----
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

            // Waits for input from the user if you run the
            // ConsoleApp1.exe instead of instantly closing
            // The executable is in bin/Debug/net6.0
            Console.Read();
        }
    }
}
