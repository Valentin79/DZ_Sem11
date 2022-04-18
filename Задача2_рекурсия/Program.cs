//  Проверка на простое число:
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

// 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

bool SimpleNumber(int N, int count = 2)
{
    if(N <= -2) N = N*-1;
    if(N == 2) return true;
    if(count == N) return true;
    if(N % count == 0) return false;
    return SimpleNumber(N, count+1);
}

int N = Prompt("Введите число: ");
while(N < 2 && N > -2)
{
    N = Prompt("Введите число больше 1: ");
}

if(SimpleNumber(N) == true) Console.WriteLine($"{N} является простым числом");
if(SimpleNumber(N) == false) Console.WriteLine($"{N} не является простым числом");
