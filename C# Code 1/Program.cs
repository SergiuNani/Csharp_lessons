
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

            // Copy part of an array to another
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray,
                startInd, length);

            PrintArray(destArray, "Copy");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", m);
            }

            // ----- IF / ELSE / -----
            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || !

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            }
            else
            {
                Console.WriteLine("Go to college");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            // Ternary Operator
            // Assigns the 1st value if true and otherwise
            // the 2nd
            bool canDrive = age >= 16 ? true : false;

            // Switch is used when you have limited options
            // The only way to use ranges is to stack
            // the possible values
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    // You can also jump out of a switch
                    // with goto
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("Elementary, Middle, High School");

            // To compare strings use Equals
            string name2 = "Derek";
            string name3 = "Derek";

            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are Equal");
            }

            // ----- WHILE LOOP -----
            // You use the while loop when you want to execute
            // as long as a condition is true

            // This while loop will print odd numbers between
            // 1 and 10
            int i = 1;
            while (i <= 10)
            {
                // % (Modulus) returns the remainder of a
                // division. If it returns 0 that means the
                // value is even
                if (i % 2 == 0)
                {
                    i++;

                    // Continue skips the rest of the code and
                    // starts execution back at the top of the
                    // while
                    continue;
                }

                // Break jumps completely out of the loop
                if (i == 9) break;

                Console.WriteLine(i);
                i++;
            }

            // ----- DO WHILE LOOP -----
            // Use do while when you must execute the code
            // at least once

            // Generate a random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num : ", secretNumber);

            do
            {
                Console.Write("Enter a number between 1 & 10 : ");

                // Use Convert to switch the string into an int
                // Other Convert options : ToBoolean, ToByte,
                // ToChar, ToDecimal, ToDouble, ToInt64,
                // ToString, and they can convert from any
                // type to any other type
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it is was {0}",
                secretNumber);


            // ----- EXCEPTION HANDLING -----
            // We use exception handling to catch errors
            // that could crash our program
            double num1 = 5;
            double num2 = 0;

            // Code that could cause an error is surrounded
            // by a try block
            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    DoDivision(num1, num2));
            }

            // We catch the error and warn the user
            // rather then crash the program
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't Divide by Zero");

                // Get additonal info on the exception
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

            }

            // This is the default catch all for exceptions
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            // finally always runs and provides for clean up
            finally
            {
                Console.WriteLine("Cleaning Up");
            }

            // ----- STRINGBUILDER -----
            // Each time you change a string you are actually
            // creating a new string which is inefficient
            // when you are working with large blocks of text
            // StringBuilders actually change the text
            // rather then make a copy

            // Create a StringBuilder with a default size
            // of 16 characters, but it grows automatically
            StringBuilder sb = new StringBuilder("Random Text");

            // Create a StringBuilder with a size of 256
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            // Get max size
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // Get length
            Console.WriteLine("Length : {0}", sb2.Length);

            // Add text to StringBuilder
            sb2.AppendLine("\nMore important text");

            // Define culture specific formating
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // Append a format string
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            // Output StringBuilder
            Console.WriteLine(sb2.ToString());

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
