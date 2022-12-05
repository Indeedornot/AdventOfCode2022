namespace AdventOfCode.Day3;

public class Day3 {
  static readonly List<char> letters = new() {
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
  };

  public static void Main() {
    string[] guide = File.ReadAllLines(@"C:\Users\Indeed\Desktop\Stuff\Repositories\c#\AdventOfCode\Day3\Input.txt");
  }

  private static void Part1(string[] guide) {
    int sum = 0;
    foreach (var line in guide){
      var first = line.Substring(0, line.Length / 2);
      var second = line.Substring(line.Length / 2);

      foreach (var item in first){
        if (!second.Contains(item)) continue;

        sum += letters.IndexOf(item) + 1;
        Console.WriteLine(item + " " + (letters.IndexOf(item) + 1));
        break;
      }
    }

    Console.WriteLine(sum);
  }

  private static void Part2(string[] guide) {
    int sum = 0;
    for (int i = 0; i < guide.Length; i += 3){
      var badge = guide[i].First((item) => guide[i + 1].Contains(item) && guide[i + 2].Contains(item));
      sum += letters.IndexOf(badge) + 1;
    }
    Console.WriteLine(sum);
  }
}