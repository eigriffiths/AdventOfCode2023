using System.Text.RegularExpressions;

string[] lines = File.ReadAllLines(@"..\..\..\input.txt");

long total = 0;
var reg = @"\d|one|two|three|four|five|six|seven|eight|nine";

foreach (var line in lines)
{
    string firstNum = Regex.Match(line, reg).ToString();
    var lastNum = Regex.Match(line, reg, RegexOptions.RightToLeft).ToString();

    var number = $"{ParseMatch(firstNum)}{ParseMatch(lastNum)}";

    total += int.Parse(number);

}

int ParseMatch(string st) => st switch
{
    "one" => 1,
    "two" => 2,
    "three" => 3,
    "four" => 4,
    "five" => 5,
    "six" => 6,
    "seven" => 7,
    "eight" => 8,
    "nine" => 9,
    var d => int.Parse(d)
};

Console.WriteLine($"Your answer is: {total}");
Console.ReadLine();