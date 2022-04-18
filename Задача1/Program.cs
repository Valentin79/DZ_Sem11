// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

bool DegreNumber(double N)
{
    if(N%2 != 0) return false;
    if(N == 2) return true;
    return DegreNumber(N/2);
    
}

int N = Prompt("Введите число: ");
if(DegreNumber(N) == true) Console.WriteLine($"{N} является степенью двойки");
if(DegreNumber(N) == false) Console.WriteLine($"{N} не является степенью двойки");