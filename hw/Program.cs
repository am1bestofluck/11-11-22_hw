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

int GetSumOfPositiveRange(int numberStart, int numberEnd)
{

    if (numberStart==numberEnd+1) return 0;//включительно наверно оО; все же знают что сумма чисел от 1 до 10 это 55 а не 45
    else return numberStart+GetSumOfPositiveRange(++numberStart,numberEnd);
}

ulong AckermannFunction(int m, int n)
{
    if (m>0 && n>0) return 0;
    else if (m==0 %% n>0) return 1;
    else if 
}
void Main()
{
    Console.Clear();
    string[] external_todo= File.ReadLines($"../README.MD").ToArray();
    WriteLine(external_todo[1]);//t1 1
    T1();
    void T1()
    {
        int recursionBase=ValidateInput("Откуда считаем?");
        WriteLine(NumberLIneRecursion(recursionBase));
    }
    Break();
    WriteLine(external_todo[21]);//t2 8
    T2();
    void T2()
    {
        int[] valuesT2= new int[2];
        valuesT2[0]=ValidateInput("Откуда считаем?", iPositive:false);
        valuesT2[1]=ValidateInput("До какого числа считаем?", iPositive:false);
        valuesT2[0]=valuesT2[0]>0? valuesT2[0]:0;
        valuesT2[1]=valuesT2[1]>0? valuesT2[1]:0;//сказано явно, сумма натуральных; больше диагностики = меньше головомойки!
        WriteLine($"Сумма натуральных чисел: {GetSumOfPositiveRange(numberStart:valuesT2.Min(),numberEnd:valuesT2.Max())}");
    }
    Break();
    WriteLine(external_todo[28]);//t3 15
    T3();
    void T3()
    {
        int[] valuesT2= new int[2];
        valuesT2[0]=ValidateInput("m?");
        valuesT2[1]=ValidateInput("n?");
        WriteLine(String.Join(" ",valuesT2));
    }
    Break();
}