//https: //adventofcode.com/2022/day/1

namespace AdventOfCode.Day1; 

public class Day1 {
  public static void Main() {
    string[] data = File.ReadAllLines(@"C:\Users\Indeed\Desktop\Stuff\Repositories\c#\AdventOfCode\Day1\Input.txt");

    var caloriesAll = new List<int>();

    int temp = 0;
    for (int i = 0; i < data.Length; i++){
      if (data[i] == " " || data[i] == ""){
        caloriesAll.Add(temp);
        temp = 0;
        continue;
      }

      temp += int.Parse(data[i]);
    }

    caloriesAll.Sort((a, b) => b - a);

    int sum = 0;
    for (int i = 0; i < 3; i++){
      sum += caloriesAll[i];
      Console.WriteLine($"{i} {caloriesAll[i]}");
    }

    Console.WriteLine(sum);   
  }
}