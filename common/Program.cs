// See https://aka.ms/new-console-template for more information
using static System.Console;

string[] tasks=new string[] {
"Вывести рекурсивно числа от 1 до n",
"Вывести рекурсивно числа от m до n",
"Вывести рекурсивно сумму цифр в числе",
"вывести рекурсивно число а в степени б"
};

main(tasks);

string t1(int tmp,int limit)
{
    string output=String.Empty;
    for (int i = 0; i < limit; i++)
    {
        output=output+$"{i} ";
    }
    return output;
}

string t1rec(int tmp, int limit)
{
    if (tmp==limit)
    {
        return "";
    }
    else return $"{tmp} {t1rec(tmp+1,limit)}";
}

int sumD(string iParsable)
{
    int oSum=0;
    for (int _char = 0; _char < iParsable.Length; _char++)
    {
        oSum+=Int32.Parse(iParsable[_char].ToString()); 
    }
    return oSum;
}

int sumD_rec( string iParsable, int index)
{
    // WriteLine(index);
    if (index==iParsable.Length)
    {
        return 0;
    }
    else return(Int32.Parse(iParsable[index].ToString())+sumD_rec(iParsable,++index));//index+1, index++
}

int ManualPow(int a, int b)
{
    int output=a;
    for (int i = 1; i < b; i++)
    {
        output=output*a; 
    }
    return output;
}

int ManualPow_rec(int a, int b, int index)
{
    if (index>=b)
    {
        return a;
    }
    else
    {
        // WriteLine(a);
        return a*ManualPow_rec(a,b,++index);
    }
}


void main(string[] tasks)
{
    WriteLine(tasks[0]);
    WriteLine("Дай n?");
    int t1arg=Int32.Parse(ReadLine()!);
    WriteLine(t1(0,t1arg));
    WriteLine(t1rec(0,t1arg));
    WriteLine(tasks[1]);
    WriteLine("Дай m?");
    int t2argMin=Int32.Parse(ReadLine()!);
    WriteLine("Дай n?");
    int t2argMax=Int32.Parse(ReadLine()!);
    WriteLine(t1rec(t2argMin,t2argMax));
    WriteLine(tasks[2]);
    string t3arg=ReadLine()!;
    WriteLine(sumD(t3arg));
    WriteLine(sumD_rec(t3arg,0));
    WriteLine(tasks[3]);
    WriteLine("Дай a?");
    int t3argBase=Int32.Parse(ReadLine()!);
    WriteLine("Дай b?");
    int t3argPow=Int32.Parse(ReadLine()!);
    WriteLine(ManualPow(t3argBase,t3argPow));
    WriteLine(ManualPow_rec(t3argBase,t3argPow,1));
}