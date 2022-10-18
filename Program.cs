/* See Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
этого числа. 

int Cutnomber (int num)
{
    int Current = (num / 10) % 10;
    return Current;
}
Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());
int Current = Cutnomber (num);
Console.WriteLine ($"Second nomber of {num} is {Current}");


Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

void Kalendar (int num)
{
    if (num==1||num==2||num==3||num==4||num==5)
    {
        Console.WriteLine("This is working day");
    }
    if (num==6||num==7)
    {
        Console.WriteLine("This is day off");
    }
    if (num <1||num>7)
    {
    Console.WriteLine("num is incorrect");
    };

}
Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());
Kalendar (num); */









