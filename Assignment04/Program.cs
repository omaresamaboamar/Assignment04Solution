
#region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

//Console.WriteLine("Enter Your Number");
//int.TryParse(Console.ReadLine(), out int number);

//for (int i=1; i<=number; i++)
//{
//    Console.WriteLine(i);
//}

#endregion
#region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

//Console.WriteLine("Enter Your Number");
//int.TryParse(Console.ReadLine(), out int number);
//for (int i=1; i<=12;i++)
//{
//    Console.WriteLine(number*i);
//}

#endregion
#region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
//Console.WriteLine("Enter Your Number");
//int.TryParse(Console.ReadLine(), out int number);
//for (int i = 1; i <= number; i++)
//{
//    if (i % 2 == 0)
//        {
//            Console.WriteLine(i);
//        }
//}
#endregion
#region 4- Write a program that takes two integers then prints the power.
//Console.WriteLine("enter Num1");
//int.TryParse(Console.ReadLine(), out int num1);
//Console.WriteLine("enter Num2");
//int.TryParse(Console.ReadLine(), out int num2);
//Console.WriteLine(Math.Pow(num1, num2));
#endregion
#region 6- Write a program to input the month number and print the number of days in that month.

//Console.WriteLine("Enter Month Number:");

//int monthNumber = int.Parse(Console.ReadLine());
//int days;

//switch (monthNumber)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        days = 31;
//        break;
//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        days = 30;
//        break;
//    case 2:
//        days = 28;
//        break;
//    default:
//        Console.WriteLine("Invalid Month Number");
//        return;
//}
//Console.WriteLine("Days in Month: " + days);

#endregion
#region 10- Write a program in C# Sharp to convert a decimal number into binary without using an array.
Console.WriteLine("Enter a number to convert:");
int.TryParse(Console.ReadLine(),out int number);

Console.Write("The Binary is ", number);
Convert(number);
Console.WriteLine();

static void Convert(int number)
{
    if (number == 0)
    {
        Console.Write("0");
        return;
    }

    if (number > 1)
    {
        Convert(number / 2);
    }

    Console.Write(number % 2);
}
#endregion