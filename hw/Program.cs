// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static System.Console;
Main();
int ValidateInput(string iInvite, bool iPositive=true)
{
    WriteLine(iInvite);
    bool isValid=false;
    int output= new int();
    while (!isValid)
    {
        string bufferStr=ReadLine()!;
        isValid=Int32.TryParse(bufferStr, out output);
        if (!isValid)
            {
                WriteLine("Ещё хочу :)");
            }        
        if (iPositive)
        {
            isValid=output > 0 ? true: false;
            if (output<0)
            {
                WriteLine("Только положительные");
            }
        }
    }
    return output;
}

void Break()
{
    Console.BackgroundColor = ConsoleColor.Blue;
    WriteLine("Enter для продолжения");
    Console.BackgroundColor = ConsoleColor.Black;
    ReadLine();
    Console.Clear();
}

string NumberLIneRecursion(int iBase,int iIndex=0)
{
    if (iIndex==iBase)
    {
        return string.Empty;
    }
    else return $"{NumberLIneRecursion(iBase,++iIndex)} {iIndex}";
}

void Main()
{
    Console.Clear();
    string[] external_todo= File.ReadLines($"../README.MD").ToArray();
    WriteLine(external_todo[1]);//t1 1
    int recursionBase=ValidateInput("Откуда считаем?");
    WriteLine(NumberLIneRecursion(recursionBase));
    Break();
    WriteLine(external_todo[21]);//t2 8
    Break();
    WriteLine(external_todo[28]);//t3 15
    Break();
}