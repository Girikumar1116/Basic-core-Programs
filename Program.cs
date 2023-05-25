namespace CFp_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a problem number from 1 to 28");
            int problem=Int32.Parse(Console.ReadLine());
            switch(problem) 
            {

                case 1:new  Display_FriendsName(); break;
                case 2:new Square_SumDiff(); break;  
                case 3:new String_Upper_Lower_case();break
                case 4:new print_10(); break;
                case 5:new Persons_FullName(); break;
                case 6:new Average();break;
                case 7: new Circles_Perimeter_Area(); break;
                case 8:new GivenDate_NextDay();break;
                case 9:new Execution_Time();break;
                case 10:new DivisibleBy_7_Not_5();break;
                case 11:new Factorial();break;
                case 12:new Print_100_WithoutLoop();break;
                case 13:new Quadratic_Roots();break;
                case 14:new Numbers_factors();break;
                case 15:new PresentOrNone();break;
                case 16:new ArithmeticExpression();break;
                case 17:new Longest_Substring();break;
                case 18:new Delete_pos_Array();break;
                case 19:new Second_Largest();break;
                case 20:new Remove_Duplicates();break;
                case 21:new SmallestGap();break;
                case 22:new Days_Years_Months_Weeks();break;
                case 23:new Without_Math();break;
                case 24:new Prime_Numbers();break;
                case 25:new Inheritance();break;
                case 26:new Degree_kelvin_Fahrenheit();break;
                case 27:new Arr_Sum();break;
                case 28:new FileCreate();break;

            }
        }
    }
}