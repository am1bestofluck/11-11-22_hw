// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static System.Console;
Main();
int ValidateInput(string iInvite, bool iPositive=true,bool iIncludeZero=false)
{
    WriteLine(iInvite);
    bool isValid=false;
    int output= new int();
    while (!isValid)
    {
        string bufferStr=ReadLine()!;
        isValid=Int32.TryParse(bufferStr, out output);
        if (!isValid)//совсем уж явный мусор
            {
                WriteLine("Ещё хочу :)");
                continue;
            }
        if (!iIncludeZero)//оглашаем запрет ноля
        {
            if (output==0 && isValid)
            {
                WriteLine("В этот раз ноль запрещён.");
            }
        }        
        if (iPositive)//проверка на допустимость: могут быть запрещены отрицательные с или без нуля
        {
            if(!iIncludeZero)
            {
                isValid=output > 0 ? true: false;
                if (output<0)
                {
                    WriteLine("Только положительные");
                }
            }
            else
            {
                isValid=output >= 0 ? true: false;
                if (output<0)
                {
                    WriteLine("Только положительные");
                }
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

int GetSumOfPositiveRange(int iNumberStart, int iNumberEnd)
{

    if (iNumberStart==iNumberEnd+1) return 0;//включительно наверно оО; все же знают что сумма чисел от 1 до 10 это 55 а не 45
    else return iNumberStart+GetSumOfPositiveRange(++iNumberStart,iNumberEnd);
}

ulong AckermannFunction(ulong m, ulong n)//это функция ПОТОМ начала быть штангой для вычислений. А ДО этого что она делала?
{
    if (m==0)
    {
        return n+1;
    }
    else if (m>0 && n==0)
    {
        return AckermannFunction(m-1,1);
    }
    else 
    {
        return AckermannFunction(m-1,AckermannFunction(m,n-1));
    }
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
        valuesT2[0]=ValidateInput("Откуда считаем?", iPositive:false, iIncludeZero:true);
        valuesT2[1]=ValidateInput("До какого числа считаем?", iPositive:false, iIncludeZero:true);
        valuesT2[0]=valuesT2[0]>0? valuesT2[0]:0;
        valuesT2[1]=valuesT2[1]>0? valuesT2[1]:0;//сказано явно, сумма натуральных; больше диагностики = меньше головомойки!
        int output= valuesT2[0]==valuesT2[0]? 0: GetSumOfPositiveRange(iNumberStart:valuesT2.Min(),iNumberEnd:valuesT2.Max());//чтобы 3 и 3 не давали на выходе 3
        WriteLine($"Сумма натуральных чисел: {output}");
    }
    Break();
    WriteLine(external_todo[28]);//t3 15
    T3();
    void T3()
    {
        WriteLine("В текущей реализации на 5,0 уже вылетает.");
        int[] valuesT2= new int[2];
        valuesT2[0]=ValidateInput("m?",iIncludeZero:true);
        valuesT2[1]=ValidateInput("n?",iIncludeZero:true);
        WriteLine($@"A({valuesT2[0]},{valuesT2[1]}) = {AckermannFunction(
            m:Convert.ToUInt64(valuesT2[0]),
            n:Convert.ToUInt64(valuesT2[1]))}");
    }
}
