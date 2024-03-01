
using System.Runtime.CompilerServices;

int number1 = 214;
long number2 = 21474783649;
short number3 = 32767;
byte number4 = 255;
double number5 = 10.5;
decimal number6 = 10.7m;
bool condition = true;
char charecter = 'A';
Console.WriteLine("Number is {0}-{1}-{2}-{3}-{4}-{5}", number1, number2, number3, number4, number5, number6);
Console.WriteLine("Character is {0}", charecter);
if (number1 == 214)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
//switch (number1)
//{
//    case 10:
//         Console.WriteLine("number 10");
//            break;
//    case 214:
//        Console.WriteLine("number 214");
//        break;
//    default:
//        Console.WriteLine("Not");
//        break;
//}
if (number2 >= 0 && number2 <= 100)
{
    Console.WriteLine("between 0-100");
}
else if (number2 >= 100 && number2 <= 200)
{
    Console.WriteLine("between 101-200");
}
else if (number2 > 200 || number2 < 0)
{
    Console.WriteLine("0 dan küçük,200den büyük");
}
static void Add()
{
    Console.WriteLine("Added");
}
Add();
static int Add2(int num1, int num2)
{
    var result = num1 + num2;
    return result;
}
var result = Add2(20, 30);
Console.WriteLine(result);

string[] students = new string[3];

students[0] = "Emine";
students[1] = "Ayşe";
students[2] = "Ceren";


foreach (var student in students)
{
    Console.WriteLine(student);
}
string[,] regions = new string[3, 3]
    {
    {"İstanbul","İzmit","Balıkesir"},
    {"İzmir","Muğla","Manisa"},
    {"Antalya","Adana","Mersin"},
    };
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    { Console.WriteLine(regions[i, j]); }
    Console.WriteLine("*****");
}
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
}
forloop();
static void forloop()
{
    for (int i = 0; i <= 100; i = i + 2)
    {
        Console.WriteLine(i);
    }
}
Whileloop();

static void Whileloop()
{
    int number8 = 100;
    while (number8 >= 0)
    {

        number8--;
        Console.WriteLine("now number is{0}", number8);

    }
}
dowhleloop();

static void dowhleloop()
{
    int number7 = 10;
    do
    {
        Console.WriteLine(number7);
        number7--;
    } while (number7 >= 0);
}
if (İsPrimeNumber(7))
{
    Console.WriteLine("This is a number prime number ");
}
else {
    Console.WriteLine("This is a not a prime number");
}
static bool İsPrimeNumber(int number9)
{

    bool result = true;
    for (int i = 2; i < number9 - 1; i++)
    {
        if (number9 % i == 0)
        { 
        result = false;
            i = number9;
        }
    }
    return result;
}
enum MyEnum
{
    Pzt, Salı, Crşmb, Prşmb, Cuma, Cmt, Pazar
}
