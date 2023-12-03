string[] lines = File.ReadAllLines(@"..\..\..\input.txt");
long total = 0;
foreach (var line in lines)
{
    int firstNum = line.First(line => char.IsDigit(line)) - '0';
    int lastNum = line.Last(line => char.IsDigit(line)) - '0';

    var number = $"{firstNum}{lastNum}";

    total += int.Parse(number);

}

Console.WriteLine($"Your answer is: {total}");  
Console.ReadLine();