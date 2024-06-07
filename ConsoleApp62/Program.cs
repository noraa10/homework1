using System;
using System.ComponentModel;

class Program
{

    /*Write a C# Sharp program to compute the sum of the two numerical values.
 If the two values are the same, return triple their sum.
 Sample Input:
 1, 2
 3, 2
 2, 2
 Expected Output:
 3
 5
 12
 */

    public static int sum(int num1, int num2)
    {
        int sum = num1 + num2;
        if (num1 == num2)
        {
            return sum * 3;
        }
        else
        {
            return sum;
        }
    }


    /*
 Write a C# Sharp program to get the absolute difference between n and 51.
If n is broader than 51 return triple the absolute difference.
Sample Input:
53
30
51
Expected Output:
6
21
0
  */
    public static int border(int n)
    {
        if (n > 53)
        {
            int res1 = 53 - n;
            int final_res1 = Math.Abs(res1) * 3;
            return final_res1;
        }
        else
        {
            int res1 = 53 - n;
            return Math.Abs(res1);
        }
    }
    /* Write a C# Sharp program to check two given integers, and return true if
   one of them is 30 or if their sum is 30.
   Sample Input:
   30, 0
   25, 5
   20, 30
   20, 25
   Expected Output:
   True
   True
   True
   False
   */
    public static bool CheckIntegers(int n1, int n2)
    {
        if ((n1 == 30 || n2 == 30) || (n1 + n2 == 30))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /*. Write a C# Sharp program to check a given integer and return true if it is
    within 10 of 100 or 200.
    Sample Input:
    103
    90
    89
    Expected Output:
    True
    True
    False
    */
    public static bool IsWithinRange(int num)
    {
        // Check if the absolute difference between the input number and 100 is less than or equal to 10
        if (Math.Abs(num - 100) <= 10)
        {
            return true;
        }
        // Check if the absolute difference between the input number and 200 is less than or equal to 10
        else if (Math.Abs(num - 200) <= 10)
        {
            return true;
        }
        // If the number is not within 10 of either 100 or 200, return false
        else
        {
            return false;
        }
    }

    /*. Write a C# Sharp program to create a string where 'if' is added to the front
   of a given string. If the string already begins with 'if', return it unchanged.
   Sample Input:
   "if else"
   "else"
   Expected Output:
   if else
   if else*/

    public static string AddIfToString(string str)
    {
        if (str.StartsWith("if"))
        {
            return str;
        }
        else
        {
            return "if" + str;

        }
    }

    /* Write a C# Sharp program to remove the character at a given position in the
    string. The given position will be in the range 0..(string length -1) inclusive.
    Sample Input:
    "Python", 1
    "Python", o
    "Python", 4
    Expected Output:
    Pthon
    ython
    Pythn*/

    public static string RemoveCharAtPosition(string str2, int position)
    {
        // Check if the position is within the valid range
        if (position < 0 || position >= str2.Length)
        {
            throw new ArgumentOutOfRangeException("position", "The position must be within the range of the string length.");
        }

        // Remove the character at the specified position
        return str2.Remove(position, 1);
    }

    /* Write a C# Sharp program to exchange the first and last characters in a
  given string and return the new string.
  Sample Input:
  "abcd"
  "a"
  "xy"
  Expected Output:
  dbca
  a
  yx*/

    public static string ExchangeFirstLast(string str3)
    {
        if (str3.Length < 2)
        {
            return str3;
        }

        char first1 = str3[0];
        char last1 = str3[str3.Length - 1];

        return last1 + str3.Substring(1, str3.Length - 2) + first1;


    }

    /*. Write a C# Sharp program to create a string which is 4 copies of the 2 front
    characters of a given string. If the given string length is less than 2 return the
    original string.
    Sample Input:
    "C Sharp"
    "JS"
    "a"
    Expected Output:
    C C C C
    JSJSJSJS
    a*/
    public static string Copies_str(string str4)
    {
        if (str4.Length < 2)
        {
            return str4;
        }
        string first2 = str4.Substring(0, 1);
        string new_str4 = first2 + first2 + first2 + first2;
        return new_str4;
    }

    /*Write a C# Sharp program to create a string with the last char added at the
      front and back of a given string of length 1 or more.
      Sample Input:
      "Red"
      "Green"
      "1"
      Expected Output:
      dRedd
      nGreenn
      111
  */
    public static string addstr_frontback(string str5)
    {
        if (str5.Length <= 1)
        {
            return str5;
        }
        string lastChar = str5.Substring(str5.Length - 1);
        return lastChar + str5 + lastChar;
    }

    /*. Write a C# Sharp program to check if a given positive number is a multiple
of 3 or 7.
Sample Input:
3
14
12
37
Expected Output:
True
True
True
False*/
    public static bool IsMultipleOf3Or7(int num)
    {
        return (num % 3 == 0 || num % 7 == 0);
    }


    /* Write a C# Sharp program to create a string taking the first 3 characters of
a given string. Return the string with the 3 characters added at both the front
and back. If the given string length is less than 3, use whatever characters are
there.
  Sample Input:
"Python"
"JS"
"Code"
Expected Output:
PytPythonPyt
JSJSJS
CodCodeCod  */
    public static string CreateString(string str6)
    {
        string first3;
        if (str6.Length >= 3)
        {
            first3 = str6.Substring(0, 3);
        }
        else
        {
            first3 = str6;
        }
        return first3 + str6 + first3;
    }

    /*. Write a C# Sharp program to check if a given string starts with 'C#' or not.
Sample Input:
"C# Sharp"
"C#"
"C++"
Expected Output:
True
True
False
*/
    public static bool StartsWithCSharp(string str7)
    {
        return str7.StartsWith("C#");
    }

    /*. Write a C# Sharp program that checks whether one temperature is less
    than 0 and another is greater than 100.
    Sample Input:
    120, -1
    -1, 120
    2, 120
    Expected Output:
    True
    True
    False
    */
    public static bool CheckTemperatureRange(double temp1, double temp2)
    {
        return (temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0);
    }

    /* Write a C# Sharp program to check two given integers whether either of
    them is in the range 100..200 inclusive.
    Sample Input:
    100, 199
    250, 300
    105, 190
    Expected Output:
    True
    False
    True*/
    public static bool InRange100to200(int num1, int num2)
    {
        return (num1 >= 100 && num1 <= 200) || (num2 >= 100 && num2 <= 200);
    }
    /*. Write a C# Sharp program to check whether three given integer values are
in the range 20..50 inclusive. Return true if 1 or more of them are in the said
range otherwise false.
Sample Input:
11, 20, 12
30, 30, 17
25, 35, 50
15, 12, 8
Expected Output:
True
True
True
False*/
    public static bool InRange20to50(int num1, int num2, int num3)
    {
        return (num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50);
    }
    /* Write a C# Sharp program to check if a string 'yt' appears at index 1 in a
    given string. If it appears return a string without 'yt' otherwise return the
    original string.
    Sample Input:
    "Python"
    "ytade"
    "jsues"
    Expected Output:
    Phon
    ytade
    jsues*/
    public static string RemoveYt(string input)
    {
        if (input.Length >= 2 && input.Substring(1, 2) == "yt")
        {
            return input.Substring(0, 1) + input.Substring(3);
        }
        else
        {
            return input;
        }
    }
    /*Write a C# Sharp program to check the largest number among three given
integers.
Sample Input:
1,2,3
1,3,2
1,1,1
1,2,2
Expected Output:
3
3
1
2*/

    public static int FindLargestNumber(int num1, int num2, int num3)
    {
        return Math.Max(Math.Max(num1, num2), num3);
    }

    /* Write a C# Sharp program to check which number is closest to 100 among
    two given integers. Return 0 if the two numbers are equal.
    Sample Input:
    78, 95
    95, 95
    99, 70
    Expected Output:
    95
    0
    99*/
    public static int FindClosestTo100(int num1, int num2)
    {
        int diff1 = Math.Abs(num1 - 100);
        int diff2 = Math.Abs(num2 - 100);
        if (diff1 == diff2)
        {
            return 0;
        }
        else
        {
            return (diff1 < diff2) ? num1 : num2;
        }
    }

    /*Write a C# Sharp program to check whether two given integers are in the
    range 40..50 inclusive, or they are both in the range 50..60 inclusive.
    Sample Input:
    78, 95
    25, 35
    40, 50
    55, 60
    Expected Output:
    False
    False
    True
    True
    */
    public static bool InRangeOrRange(int num1, int num2)
    {
        return (num1 >= 40 && num1 <= 50 && num2 >= 40 && num2 <= 50) || (num1 >= 50 && num1 <= 60 && num2 >= 50 && num2 <= 60);
    }
    /*Write a C# Sharp program to check if a given string contains between 2
and 4 'z' characters.
Sample Input:
"frizz"
"zane"
"Zazz"
"false"
"zzzz"
"ZZZZ"
Expected Output:
True
False
True
False
True
False
*/
    public static bool ContainsZCount(string input)
    {
        int zCount = input.Count(c => c == 'z');
        return zCount >= 2 && zCount <= 4;
    }

    /*. Write a C# Sharp program to check if two given non-negative integers
    have the same last digit.
    Sample Input:
    123, 456
    12, 512
    7, 87
    12, 45
    Expected Output:
    False
    True
    True*/

    public static bool SameLastDigit(int num1, int num2)
    {
        return num1 % 10 == num2 % 10;
    }

    /*Write a C# Sharp program to convert the last 3 characters of a given string
to uppercase. If the length of the string is less than 3, then uppercase all the
characters.
Sample Input:
"Python"
"Javascript"
"js"
"PHP"
Expected Output:
PytHON
JavascrIPT
JS
PHP
*/
    public static string UppercaseLastThree(string input)
    {
        if (input.Length < 3)
        {
            return input.ToUpper();
        }
        else
        {
            return input.Substring(0, input.Length - 3) + input.Substring(input.Length - 3).ToUpper();
        }
    }

    /*. Write a C# Sharp program to create a string which is n (non-negative
integer) copies of a given string.
Sample Input:
"JS", 2
"JS", 3
"JS", 1
Expected Output:
JSJS
JSJSJS
JS
*/
    public static string RepeatString(string input, int n)
    {
        return string.Concat(Enumerable.Repeat(input, n));
    }

    /*. Write a C# Sharp program to accept two integers and check whether they
    are equal or not.
    Test Data :
    Input 1st number: 5
    Input 2nd number: 5
    Expected Output :
    5 and 5 are equal*/

    public static void CheckEquality(int num1, int num2)
    {
        if (num1 == num2)
        {
            Console.WriteLine($"{num1} and {num2} are equal");
        }
        else
        {
            Console.WriteLine($"{num1} and {num2} are not equal");
        }
    }

    /*. Write a C# Sharp program to check whether a given number is even or odd.
Test Data : 15
Expected Output :
15 is an odd integer*/

    public static void EvenOrOdd(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is an even integer");
        }
        else
        {
            Console.WriteLine($"{num} is an odd integer");
        }
    }
    /*. Write a C# Sharp program to check whether a given number is positive or
negative.
Test Data : 14
Expected Output :
14 is a positive number
     */
    public static void CheckPositiveNegative(int num)
    {
        if (num > 0)
        {
            Console.WriteLine($"{num} is a positive number");
        }
        else if (num < 0)
        {
            Console.WriteLine($"{num} is a negative number");
        }
        else
        {
            Console.WriteLine($"{num} is zero");
        }
    }

    /* Write a C# Sharp program to find out whether a given year is a leap year or
not.
Test Data : 2016
Expected Output :
2016 is a leap year.*/
    public static void CheckLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
    /*Write a C# Sharp program to read the age of a candidate and determine
whether it is eligible for casting his/her own vote.
Test Data : 21
Expected Output:
Congratulation! You are eligible for casting your vote*/
    public static void CheckVotingEligibility(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("Congratulation! You are eligible for casting your vote.");
        }
        else
        {
            Console.WriteLine($"Sorry, you are not eligible for casting your vote. You need to be at least 18 years old, but you are only {age} years old.");
        }
    }

    /*Write a C# Sharp program to read the value of an integer m and display the
value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less
than 0.
Test Data : -5
Expected Output:
The value of n = -1*/

    public static int DisplayValue(int m)
    {
        if (m > 0)
        {
            return 1;
        }
        else if (m == 0)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    /*Write a C# Sharp program to accept a person's height in centimeters and
categorize them according to their height.
Test Data : 135
Expected Output :
The person is Dwarf.*/
    public static void CategorizeHeight(double heightInCm)
    {
        if (heightInCm < 150)
        {
            Console.WriteLine("The person is Dwarf.");
        }
        else if (heightInCm >= 150 && heightInCm < 170)
        {
            Console.WriteLine("The person is of Average height.");
        }
        else if (heightInCm >= 170 && heightInCm < 195)
        {
            Console.WriteLine("The person is Tall.");
        }
        else
        {
            Console.WriteLine("The person is Giant.");
        }
    }
    /*8. Write a C# Sharp program to find the largest of three numbers.
Test Data :
Input the 1st number :25
Input the 2nd number :63
Input the 3rd number :10
Expected Output :
The 2nd Number is the greatest among three
    */

    public static int FindLargestNumber22(int num1, int num2, int num3)
    {
        int largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }

        if (num3 > largest)
        {
            largest = num3;
        }

        return largest;
    }

    /* Write a C# Sharp program to accept a coordinate point in an XY coordinate
system and determine in which quadrant the coordinate point lies.
Test Data :
Input the value for X coordinate :7
Input the value for Y coordinate :9
Expected Output :
The coordinate point (7,9) lies in the First quadrant.*/

    public static void DetermineQuadrant(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
        }
        else
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is at the origin.");
        }
    }

    /*11. Write a C# Sharp program to calculate the root of a quadratic equation.
Test Data :
Input the value of a : 1
Input the value of b : 5
Input the value of c : 7
Expected Output :
Root are imaginary;
No Solution.
*/
    public class QuadraticEquation
    {
        public static void SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                Console.WriteLine("Roots are imaginary.");
                Console.WriteLine("No Solution.");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Roots are real and same: {root}");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Roots are real and different: {root1}, {root2}");
            }
        }
        /*. Write a C# Sharp program to read roll no, name and marks of three
subjects and calculate the total, percentage and division.
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784 
 Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
       */
        public class StudentMarks
        {
            public static void CalculateStudentMarks(int rollNumber, string name, int physics, int chemistry, int computerApp)
            {
                int totalMarks = physics + chemistry + computerApp;
                double percentage = (totalMarks * 1.0 / 300) * 100;
                string division = GetDivision(percentage);

                Console.WriteLine("\nRoll No : " + rollNumber + ", Name of Student : " + name);
                Console.WriteLine("Marks in Physics : " + physics);
                Console.WriteLine("Marks in Chemistry : " + chemistry);
                Console.WriteLine("Marks in Computer Application : " + computerApp);
                Console.WriteLine("Total Marks = " + totalMarks);
                Console.WriteLine("Percentage = " + percentage.ToString("0.00"));
                Console.WriteLine("Division = " + division);
            }

            private static string GetDivision(double percentage)
            {
                if (percentage >= 60)
                    return "First";
                else if (percentage >= 50)
                    return "Second";
                else
                    return "Third";
            }
            /*. Write a C# Sharp program to read temperature in centigrade and display a
           suitable message according to the temperature state below:
           Temp < 0 then Freezing weather
           Temp 0-10 then Very Cold weather
           Temp 10-20 then Cold weather
           Temp 20-30 then Normal in Temp
           Temp 30-40 then Its Hot
           Temp >=40 then Its Very Hot
           Test Data :
           42
           Expected Output :
           Its very hot.*/
            public class TemperatureChecker
            {
                public static string CheckTemperatureState(double temperature)
                {
                    if (temperature < 0)
                        return "Freezing weather";
                    else if (temperature >= 0 && temperature <= 10)
                        return "Very Cold weather";
                    else if (temperature > 10 && temperature <= 20)
                        return "Cold weather";
                    else if (temperature > 20 && temperature <= 30)
                        return "Normal in Temp";
                    else if (temperature > 30 && temperature <= 40)
                        return "Its Hot";
                    else
                        return "Its Very Hot";
                }
                /*. Write a C# Sharp program to check whether a triangle is Equilateral,
                Isosceles or Scalene.
                Test Data :
                50 50 60
                Expected Output :
                This is an isosceles triangle.
                 */
                public class TriangleChecker
                {
                    public static string CheckTriangleType(double side1, double side2, double side3)
                    {
                        // Check if the three sides form a valid triangle
                        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                            return "The given sides do not form a valid triangle.";

                        // Check if the triangle is equilateral
                        if (side1 == side2 && side2 == side3)
                            return "This is an equilateral triangle.";

                        // Check if the triangle is isosceles
                        if (side1 == side2 || side1 == side3 || side2 == side3)
                            return "This is an isosceles triangle.";

                        // If the triangle is not equilateral or isosceles, it must be scalene
                        return "This is a scalene triangle.";
                    }

                    /*. Write a C# Sharp program to check whether an alphabet letter is a vowel
                   or a consonant.
                  Test Data :
                    k
                   Expected Output :*/
                    public class VowelChecker
                    {
                        public static string CheckVowelOrConsonant(char letter)
                        {
                            // Convert the letter to lowercase for case-insensitive checking
                            letter = char.ToLower(letter);

                            // Check if the letter is a vowel
                            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                                return "yes";
                            else if (letter >= 'a' && letter <= 'z')
                                return "no";
                            else
                                return "Invalid input. Please enter a single letter.";
                        }

                        /*Write a C# Sharp program to calculate profit and loss on a transaction.
                       Test Data :
                       500 700
                      Expected Output :
                      You can book your profit amount : 200*/
                        static void CalculateProfitLoss()
                        {
                            // Get the cost price and selling price from the user
                            Console.Write("Enter the cost price: ");
                            double costPrice = double.Parse(Console.ReadLine());

                            Console.Write("Enter the selling price: ");
                            double sellingPrice = double.Parse(Console.ReadLine());

                            // Calculate the profit or loss
                            double profitOrLoss = sellingPrice - costPrice;

                            // Display the result
                            if (profitOrLoss > 0)
                            {
                                Console.WriteLine($"You can book your profit amount: {profitOrLoss}");
                            }
                            else if (profitOrLoss < 0)
                            {
                                Console.WriteLine($"You have a loss of: {-profitOrLoss}");
                            }
                            else
                            {
                                Console.WriteLine("You have broken even on this transaction.");
                            }
                        }
                    }


                    /*. Write a C# Sharp program to read any day number as an integer and
                   display the name of the day as a word.
                  Test Data :
                   4
                    Expected Output :
                  Thursday*/
                    static void DisplayDayOfWeek()
                    {
                        // Get the day number from the user
                        Console.Write("Enter a day number (1-7): ");
                        int dayNumber = int.Parse(Console.ReadLine());

                        // Display the name of the day
                        switch (dayNumber)
                        {
                            case 1:
                                Console.WriteLine("Sunday");
                                break;
                            case 2:
                                Console.WriteLine("Monday");
                                break;
                            case 3:
                                Console.WriteLine("Tuesday");
                                break;
                            case 4:
                                Console.WriteLine("Wednesday");
                                break;
                            case 5:
                                Console.WriteLine("Thursday");
                                break;
                            case 6:
                                Console.WriteLine("Friday");
                                break;
                            case 7:
                                Console.WriteLine("Saturday");
                                break;
                            default:
                                Console.WriteLine("Invalid day number");
                                break;
                        }
                    }

                    /*. Write a program in C# Sharp to read any digit, display in the word.
                    Test Data :
                    4
                   Expected Output :
                    Four
                    */
                    static void DisplayDigitInWords()
                    {
                        // Get the digit from the user
                        Console.Write("Enter a digit (0-9): ");
                        int digit = int.Parse(Console.ReadLine());

                        // Display the digit in words
                        switch (digit)
                        {
                            case 0:
                                Console.WriteLine("Zero");
                                break;
                            case 1:
                                Console.WriteLine("One");
                                break;
                            case 2:
                                Console.WriteLine("Two");
                                break;
                            case 3:
                                Console.WriteLine("Three");
                                break;
                            case 4:
                                Console.WriteLine("Four");
                                break;
                            case 5:
                                Console.WriteLine("Five");
                                break;
                            case 6:
                                Console.WriteLine("Six");
                                break;
                            case 7:
                                Console.WriteLine("Seven");
                                break;
                            case 8:
                                Console.WriteLine("Eight");
                                break;
                            case 9:
                                Console.WriteLine("Nine");
                                break;
                            default:
                                Console.WriteLine("Invalid digit");
                                break;
                        }
                    }
                    /*. Write a program in C# Sharp to read any Month Number in integer and
                  display the number of days for this month.
                   Test Data :7
                   Expected Output:
                  Month have 31 days*/
                    class ReadMonth
                    {
                        static void DisplayMonthDays()
                        {
                            // Get the month number from the user
                            Console.Write("Enter a month number (1-12): ");
                            int monthNumber = int.Parse(Console.ReadLine());

                            // Display the number of days in the month
                            switch (monthNumber)
                            {
                                case 1: // January
                                case 3: // March
                                case 5: // May
                                case 7: // July
                                case 8: // August
                                case 10: // October
                                case 12: // December
                                    Console.WriteLine("Month has 31 days");
                                    break;
                                case 4: // April
                                case 6: // June
                                case 9: // September
                                case 11: // November
                                    Console.WriteLine("Month has 30 days");
                                    break;
                                case 2: // February
                                    Console.WriteLine("Month has 28 or 29 days");
                                    break;
                                default:
                                    Console.WriteLine("Invalid month number");
                                    break;
                            }
                        }






                        /*. Write a C# Sharp program that calculates the area of geometrical shapes
                        using a menu-driven approach.
                       Test Data :
                       Input your choice : 1
                        Input radius of the circle : 5
                      Expected Output :
                        The area is : 78.500000*/

                        static void CalculateCircleArea()
                        {
                            Console.Write("Enter the radius of the circle: ");
                            double radius = double.Parse(Console.ReadLine());
                            double circleArea = Math.PI * radius * radius;
                            Console.WriteLine($"The area of the circle is: {circleArea:F6}");
                        }

                        /*Write a C# Sharp program to find the length of a string without using a
                        library function.
                        Test Data :
                        Input the string : halalAlmashakl.com
                        Expected Output :
                        Length of the string is : 15*/

                        public static int CalculateStringLength(string str)
                        {
                            int length = 0;
                            foreach (char c in str)
                            {
                                length++;
                            }
                            return length;
                        }

                        /*Write a C# Sharp program to separate individual characters from a string.
                        */
                        public static void SeparateCharacters(string inputString)
                        {
                            foreach (char c in inputString)
                            {
                                Console.WriteLine(c);
                            }
                        }


                        /*. Write a program in C# Sharp to print individual characters of the string in
                        reverse order.*/
                        public static void PrintCharactersReverse(string inputString)
                        {
                            for (int i = inputString.Length - 1; i >= 0; i--)
                            {
                                Console.WriteLine(inputString[i]);
                            }
                        }

                        /*. Write a program in C# Sharp to count the total number of words in a string.
                        Test Data :
                        Input the string : This is halalAlmashakl.com  Expected Output :
                        Total number of words in the string is : 3
                        */
                        static int CountWords(string inputString)
                        {
                            // Initialize the word count to 1 (assuming at least one word)
                            int wordCount = 1;

                            // Iterate through the input string
                            for (int i = 0; i < inputString.Length; i++)
                            {
                                // Check if the current character is a space
                                if (inputString[i] == ' ')
                                {
                                    // If it is, increment the word count
                                    wordCount++;
                                }
                            }

                            // Return the total number of words
                            return wordCount;
                        }

                        /* Write a program in C# Sharp to compare two strings without using a string
                       library functions.
                       Test Data :
                       Input the 1st string : This is first string
                       Input the 2nd string : This is first string
                       Expected Output :
                       The length of both strings are equal and
                       also, both strings are equal.
                       */
                        static void CompareStrings()
                        {
                            // Prompt the user to enter the first string
                            Console.Write("Input the 1st string: ");
                            string str1 = Console.ReadLine();

                            // Prompt the user to enter the second string
                            Console.Write("Input the 2nd string: ");
                            string str2 = Console.ReadLine();

                            // Compare the lengths of the two strings
                            if (str1.Length == str2.Length)
                            {
                                // Compare the characters of the two strings
                                bool areEqual = true;
                                for (int i = 0; i < str1.Length; i++)
                                {
                                    if (str1[i] != str2[i])
                                    {
                                        areEqual = false;
                                        break;
                                    }
                                }

                                // Display the result
                                if (areEqual)
                                {
                                    Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
                                }
                                else
                                {
                                    Console.WriteLine("The length of both strings are equal but the strings are not equal.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The length of both strings are not equal.");
                            }
                        }
                        /*Write a program in C# Sharp to count the number of alphabets, digits and
                        special characters in a string.
                        Test Data :
                        Input the string : Welcome to halalAlmashakl.com
                        Expected Output :
                        Number of Alphabets in the string is : 21
                        Number of Digits in the string is : 1
                        Number of Special characters in the string is : 4*/
                        static void CountCharacters()
                        {
                            // Prompt the user to enter a string
                            Console.Write("Input the string: ");
                            string inputString = Console.ReadLine();

                            // Initialize the counters
                            int alphabetCount = 0;
                            int digitCount = 0;
                            int specialCharCount = 0;

                            // Iterate through the input string
                            foreach (char c in inputString)
                            {
                                if (char.IsLetter(c))
                                {
                                    alphabetCount++;
                                }
                                else if (char.IsDigit(c))
                                {
                                    digitCount++;
                                }
                                else
                                {
                                    specialCharCount++;
                                }
                            }

                            // Display the results
                            Console.WriteLine($"Number of Alphabets in the string is: {alphabetCount}");
                            Console.WriteLine($"Number of Digits in the string is: {digitCount}");
                            Console.WriteLine($"Number of Special characters in the string is: {specialCharCount}");
                        }

                        /*Write a C# Sharp program to sort a string array in ascending order.
                        Test Data :
                        Input the string : this is a string
                        Expected Output :
                        After sorting the string appears like :
                        a g h i i i n r s s s t t  */

                        static void SortStringArray()
                        {
                            // Prompt the user to enter a string
                            Console.Write("Input the string: ");
                            string inputString = Console.ReadLine();

                            // Split the input string into an array of substrings
                            string[] stringArray = inputString.Split(' ');

                            // Sort the string array in ascending order
                            Array.Sort(stringArray);

                            // Display the sorted string array
                            Console.WriteLine("After sorting the string appears like:");
                            foreach (string word in stringArray)
                            {
                                Console.Write($"{word} ");
                            }
                            Console.WriteLine();
                        }

                        /*. Write a C# Sharp program to check whether a given substring is present in
                       the given string.
                       Test Data :
                       Input the string : This is a Test String
                       Input the substring to search : Test
                       Expected Output :
                       The substring exists in the string*/

                        static void CheckSubstring()
                        {
                            // Prompt the user to enter the main string
                            Console.Write("Input the string: ");
                            string mainString = Console.ReadLine();

                            // Prompt the user to enter the substring to search
                            Console.Write("Input the substring to search: ");
                            string subString = Console.ReadLine();

                            // Check if the substring is present in the main string
                            if (mainString.Contains(subString))
                            {
                                Console.WriteLine("The substring exists in the string");
                            }
                            else
                            {
                                Console.WriteLine("The substring does not exist in the string");
                            }
                        }

                        /*Write a program in C# Sharp to check the username and password.
                        Test Data :
                        Input a username: uesr
                        Input a password: pass
                        Input a username: abcd
                        Input a password: 1234
                        Expected Output :
                        Password entered successfully!*/

                        static void CheckUsernameAndPassword()
                        {
                            // Define the valid username and password
                            string validUsername = "abcd";
                            string validPassword = "1234";

                            // Prompt the user to enter the username and password
                            Console.Write("Input a username: ");
                            string inputUsername = Console.ReadLine();
                            Console.Write("Input a password: ");
                            string inputPassword = Console.ReadLine();

                            // Check if the input username and password match the valid ones
                            if (inputUsername == validUsername && inputPassword == validPassword)
                            {
                                Console.WriteLine("Password entered successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid username or password.");
                            }
                        }

                        /*Write a C# Sharp program to check whether a character is an alphabet
                        and not and if so, check for the case.
                        Test Data :
                        Input a character: Z
                        Expected Output :
                        The character is uppercase.*/

                        static void CheckCharacterCase()
                        {
                            // Prompt the user to enter a character
                            Console.Write("Input a character: ");
                            char inputChar = Console.ReadLine()[0];

                            // Check if the input character is an alphabet
                            if (char.IsLetter(inputChar))
                            {
                                // Check the case of the input character
                                if (char.IsUpper(inputChar))
                                {
                                    Console.WriteLine("The character is uppercase.");
                                }
                                else
                                {
                                    Console.WriteLine("The character is lowercase.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The input is not an alphabet.");
                            }
                        }

                        /*Write a program in C# Sharp to display the first 10 natural numbers.*/
                        static void DisplayFirstTenNaturalNumbers()
                        {
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine();
                        }
                        /*Write a C# Sharp program to find the sum of the first 10 natural numbers.*/
                        static void FindSumOfFirstTenNaturalNumbers()
                        {
                            int sum = 0;
                            for (int i = 1; i <= 10; i++)
                            {
                                sum += i;
                            }
                            Console.WriteLine("The first 10 natural number is :");
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine("\nThe Sum is : " + sum);
                        }

                        /*Write a C# Sharp program that displays the sum of n natural numbers.*/
                        static void FindSumOfNaturalNumbers(int n)
                        {
                            int sum = 0;
                            Console.Write("The first " + n + " natural number is : ");
                            for (int i = 1; i <= n; i++)
                            {
                                sum += i;
                                Console.Write(i + " ");
                            }
                            Console.WriteLine("\nThe Sum is : " + sum);
                        }
                       
                        /*Write a program in C# Sharp to display the multiplication table of a given integer.
                       csharp
                      */
                        static void DisplayMultiplicationTable(int number)
                        {
                            Console.WriteLine("Input the number (Table to be calculated) : " + number);
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine(number + " X " + i + " = " + (number * i));
                            }
                        }
                        /*Write a program in C# Sharp to print Floyd's Triangle.*/
                        static void PrintFloydsTriangle(int rows)
                        {
                            int num = 1;
                            for (int i = 1; i <= rows; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write(num + " ");
                                    num++;
                                }
                                Console.WriteLine();
                            }
                        }
                        /*Write a program in C# Sharp to display a right angle triangle with an asterisk.*/
                        static void PrintRightAngleTriangleWithAsterisk(int rows)
                        {
                            for (int i = 1; i <= rows; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }








     
     /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      



                        static void Main(string[] args)
                        {
                            Console.WriteLine(sum(1, 2)); // Output: 3
                            Console.WriteLine(sum(3, 2)); // Output: 5
                            Console.WriteLine(sum(2, 2)); // Output: 12

                            /////////////////////////////////////////////////

                            Console.WriteLine(border(55));// output : 6

                            ////////////////////////////////////////////////

                            Console.WriteLine(CheckIntegers(30, 0)); // Output: True

                            //////////////////////////////////////////////

                            Console.WriteLine(IsWithinRange(103)); // Output: True
                            Console.WriteLine(IsWithinRange(90)); // Output: True
                            Console.WriteLine(IsWithinRange(89)); // Output: False

                            ////////////////////////////////////////////////

                            Console.WriteLine(AddIfToString("if else")); // Output: if else
                            Console.WriteLine(AddIfToString("else")); // Output: if else

                            //////////////////////////////////////////////

                            Console.WriteLine(RemoveCharAtPosition("Python", 1)); // Output: Pthon

                            ///////////////////////////////////////////////

                            Console.WriteLine(ExchangeFirstLast("abcd")); // Output: dbca
                            Console.WriteLine(ExchangeFirstLast("a"));   // Output: a

                            ////////////////////////////////////////////

                            Console.WriteLine(Copies_str("c sharp"));
                            Console.WriteLine(Copies_str("a"));

                            /////////////////////////////////////////////

                            Console.WriteLine(addstr_frontback("Green"));   // Output: nGreenn
                            Console.WriteLine(addstr_frontback("1"));       // Output: 111

                            ////////////////////////////////////////////

                            Console.WriteLine(IsMultipleOf3Or7(12));    // Output: True
                            Console.WriteLine(IsMultipleOf3Or7(37));    // Output: False

                            /////////////////////////////////////////////

                            Console.WriteLine(CreateString("JS"));       // Output: JSJSJS
                            Console.WriteLine(CreateString("Code"));     // Output: CodCodeCod

                            ///////////////////////////////////////////

                            //  Check if a given string starts with 'C#'
                            Console.WriteLine("1. Check if a given string starts with 'C#':");
                            Console.WriteLine(StartsWithCSharp("C# Sharp"));
                            Console.WriteLine(StartsWithCSharp("C++"));
                            Console.WriteLine();

                            //  Check if one temperature is less than 0 and another is greater than 100
                            Console.WriteLine("2. Check if one temperature is less than 0 and another is greater than 100:");
                            Console.WriteLine(CheckTemperatureRange(120, -1));
                            Console.WriteLine(CheckTemperatureRange(2, 120));
                            Console.WriteLine();

                            //  Check if either of two integers is in the range 100..200 inclusive
                            Console.WriteLine("3. Check if either of two integers is in the range 100..200 inclusive:");
                            Console.WriteLine(InRange100to200(100, 199));
                            Console.WriteLine(InRange100to200(250, 300));
                            Console.WriteLine();

                            //  Check if one or more of three integers are in the range 20..50 inclusive
                            Console.WriteLine("4. Check if one or more of three integers are in the range 20..50 inclusive:");
                            Console.WriteLine(InRange20to50(11, 20, 12));
                            Console.WriteLine(InRange20to50(15, 12, 8));
                            Console.WriteLine();

                            //  Check if 'yt' appears at index 1 in a given string, and return the string without 'yt' if it does
                            Console.WriteLine("5. Check if 'yt' appears at index 1 in a given string, and return the string without 'yt' if it does:");
                            Console.WriteLine(RemoveYt("Python"));
                            Console.WriteLine(RemoveYt("jsues"));
                            Console.WriteLine();

                            //  Find the largest of three integers
                            Console.WriteLine("6. Find the largest of three integers:");
                            Console.WriteLine(FindLargestNumber(1, 2, 3));
                            Console.WriteLine(FindLargestNumber(1, 1, 1));
                            Console.WriteLine();

                            //  Find the number closest to 100 between two integers, or return 0 if they are equal
                            Console.WriteLine("7. Find the number closest to 100 between two integers, or return 0 if they are equal:");
                            Console.WriteLine(FindClosestTo100(78, 95));
                            Console.WriteLine(FindClosestTo100(99, 70));
                            Console.WriteLine();

                            //  Check if two integers are in the range 40..50 inclusive, or both in the range 50..60 inclusive
                            Console.WriteLine("8. Check if two integers are in the range 40..50 inclusive, or both in the range 50..60 inclusive:");
                            Console.WriteLine(InRangeOrRange(25, 35));
                            Console.WriteLine(InRangeOrRange(55, 60));
                            Console.WriteLine();

                            // Check if a given string contains between 2 and 4 'z' characters
                            Console.WriteLine("9. Check if a given string contains between 2 and 4 'z' characters:");
                            Console.WriteLine(ContainsZCount("frizz"));
                            Console.WriteLine(ContainsZCount("ZZZZ"));
                            Console.WriteLine();

                            //  Check if two non-negative integers have the same last digit
                            Console.WriteLine("10. Check if two non-negative integers have the same last digit:");
                            Console.WriteLine(SameLastDigit(123, 456));
                            Console.WriteLine(SameLastDigit(12, 45));
                            Console.WriteLine();

                            // Convert the last 3 characters of a given string to uppercase, or uppercase all characters if the length is less than 3
                            Console.WriteLine("11. Convert the last 3 characters of a given string to uppercase, or uppercase all characters if the length is less than 3:");
                            Console.WriteLine(UppercaseLastThree("Python"));
                            Console.WriteLine(UppercaseLastThree("js"));
                            Console.WriteLine();

                            //  Create a string which is n (non-negative integer) copies of a given string
                            Console.WriteLine("12. Create a string which is n (non-negative integer) copies of a given string:");
                            Console.WriteLine(RepeatString("JS", 2));
                            Console.WriteLine(RepeatString("JS", 1));
                            Console.WriteLine();

                            //////////////////////////////////////////////////////

                            Console.Write("Input 1st number: ");
                            int num1 = int.Parse(Console.ReadLine());

                            Console.Write("Input 2nd number: ");
                            int num2 = int.Parse(Console.ReadLine());

                            CheckEquality(num1, num2);

                            /////////////////////////////////////////////////////
                            Console.Write("Enter a number: ");
                            int userInput = int.Parse(Console.ReadLine());

                            EvenOrOdd(userInput);
                            //////////////////////////////////////////////

                            Console.Write("Enter a number: ");
                            int userInput1 = int.Parse(Console.ReadLine());

                            CheckPositiveNegative(userInput);

                            ///////////////////////////////////////////////
                            Console.Write("Enter a year: ");
                            int userInput2 = int.Parse(Console.ReadLine());

                            CheckLeapYear(userInput);
                            ////////////////////////////////////////////////

                            Console.Write("Enter your age: ");
                            int userAge = int.Parse(Console.ReadLine());

                            CheckVotingEligibility(userAge);

                            //////////////////////////////////////////////////
                            Console.Write("Enter the value of m: ");
                            int userInput3 = int.Parse(Console.ReadLine());

                            int n = DisplayValue(userInput);
                            Console.WriteLine($"The value of n = {n}");
                            ///////////////////////////////////////////////
                            Console.Write("Enter the person's height in centimeters: ");
                            double userHeight = double.Parse(Console.ReadLine());

                            CategorizeHeight(userHeight);
                            /////////////////////////////////////////////////
                            Console.Write("Input the 1st number: ");
                            int firstNumber = int.Parse(Console.ReadLine());

                            Console.Write("Input the 2nd number: ");
                            int secondNumber = int.Parse(Console.ReadLine());

                            Console.Write("Input the 3rd number: ");
                            int thirdNumber = int.Parse(Console.ReadLine());

                            int largestNumber = FindLargestNumber(firstNumber, secondNumber, thirdNumber);
                            Console.WriteLine($"The largest number is: {largestNumber}");
                            /////////////////////////////////////////////////////
                            Console.Write("Input the value for X coordinate: ");
                            int xCoordinate = int.Parse(Console.ReadLine());

                            Console.Write("Input the value for Y coordinate: ");
                            int yCoordinate = int.Parse(Console.ReadLine());

                            DetermineQuadrant(xCoordinate, yCoordinate);

                            ////////////////////////////////////////////////////////


                            Console.Write("Input the value of a: ");
                            double a = double.Parse(Console.ReadLine());

                            Console.Write("Input the value of b: ");
                            double b = double.Parse(Console.ReadLine());

                            Console.Write("Input the value of c: ");
                            double c = double.Parse(Console.ReadLine());

                            SolveQuadraticEquation(a, b, c);
                            //////////////////////////////////////////
                            Console.Write("Input the Roll Number of the student: ");
                            int rollNumber = int.Parse(Console.ReadLine());

                            Console.WriteLine("Input the Name of the Student: ");
                            string name = Console.ReadLine();

                            Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
                            string[] marksInput = Console.ReadLine().Split();
                            int physicsMarks = int.Parse(marksInput[0]);
                            int chemistryMarks = int.Parse(marksInput[1]);
                            int computerAppMarks = int.Parse(marksInput[2]);

                            CalculateStudentMarks(rollNumber, name, physicsMarks, chemistryMarks, computerAppMarks);
                            ////////////////////////////////////////////////////////
                            Console.Write("Enter the temperature in Celsius: ");
                            string temperatureState = CheckTemperatureState(6);
                            Console.WriteLine(temperatureState + ".");
                            ////////////////////////////////////////////////////////////
                            Console.Write("Enter the three sides of the triangle (separated by spaces): ");
                            string[] sides = Console.ReadLine().Split();
                            double side1 = double.Parse(sides[0]);
                            double side2 = double.Parse(sides[1]);
                            double side3 = double.Parse(sides[2]);

                            string triangleType = CheckTriangleType(side1, side2, side3);
                            Console.WriteLine(triangleType);
                            ///////////////////////////////////////////////////////////
                         /*   Console.Write("Enter a letter: ");
                            string input = Console.ReadLine();

                            if (input.Length == 1 && char.IsLetter(input[0]))   // Check if the input is a single letter
                            {
                                char letter = input[0];
                                string result = CheckVowelOrConsonant(letter);
                                Console.WriteLine(result);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a single letter.");
                            }
                            */
                            ////////////////////////////////////////////////////////////
                          //  ProfitLossCalculator.Run();
                            //ProfitLossCalculator.CalculateProfitLoss();

                            Console.WriteLine("Press Enter to exit...");// Wait for the user to press Enter before exiting
                            Console.ReadLine();
                            //////////////////////////////////////////////////////////
                            DisplayDayOfWeek();
                            //////////////////////////////////////////////////////////
                            DisplayDigitInWords();

                            /////////////////////////////////////////////////////////
                            DisplayMonthDays();
                            ///////////////////////////////////////////////////////
                            CalculateCircleArea();
                            ///////////////////////////////////////////////////////////
                            string inputString = "halalAlmashakl.com";
                            int stringLength = CalculateStringLength(inputString);
                            Console.WriteLine($"Length of the string is: {stringLength}");
                            /////////////////////////////////////////////////////////////
                            string inputString3 = "halalAlmashakl.com";
                            SeparateCharacters(inputString);
                            ////////////////////////////////////////////////////////////
                            string inputString4 = "halalAlmashakl.com";
                            PrintCharactersReverse(inputString);
                            /////////////////////////////////////////////////////////////
                            // Call the CountWords function and display the result
                            int totalWords = CountWords("This is halalAlmashakl.com");
                            Console.WriteLine($"The total number of words is: {totalWords}");
                            /////////////////////////////////////////////////////////////
                            CompareStrings();
                            ////////////////////////////////////////////////////////////
                            // var conn = new CopyString();
                            //  CopyString();
                            ///////////////////////////////////////////////////////////
                            SortStringArray();
                            ////////////////////////////////////////////////////////////
                           CheckSubstring();
                            ///////////////////////////////////////////////////////
                            CheckUsernameAndPassword();
                            ////////////////////////////////////////////////////////////
                            CheckCharacterCase();
                            //////////////////////////////////////////////////////////
                            DisplayFirstTenNaturalNumbers();
                            ////////////////////////////////////////////////////////////
                            FindSumOfFirstTenNaturalNumbers();
                            /////////////////////////////////////////////////////////
                            FindSumOfNaturalNumbers(7);

                            /////////////////////////////////////////////////
                            FindSumOfNaturalNumbers(7);
                            /////////////////////////////////////////////////////////
                            DisplayMultiplicationTable(15);

                            /////////////////////////////////////////////////////////

                            PrintFloydsTriangle(5);
                            ////////////////////////////////////////////////
                            PrintRightAngleTriangleWithAsterisk(4);
                            /////////////////////////////////////////////////////////
 
                        }



                    }
                }
            }
        }
    }
}

