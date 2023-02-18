int cutNumber(int num) // 354
{
    int hundreds = num / 10;
    int units = num % 10;
    int result = units;

    return result;
}

int randNumber = new Random().Next(100,1000);

int newNumber = cutNumber(randNumber);

Console.WriteLine($"New wersian of {randNumber} is {newNumber}");