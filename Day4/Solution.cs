namespace AdventOfCode.Day4;

public class Day4 {
  public static void Main() {
    string[] guide = File.ReadAllLines(@"C:\Users\Indeed\Desktop\Stuff\Repositories\c#\AdventOfCode\Day4\Input.txt");
  }

  private static void Part1(string[] guide) {
    int sum = 0;

    foreach (var line in guide){
      var tasks = line.Split(',');
      var task1String = tasks[0].Split('-');
      (int start, int end) task1 = (int.Parse(task1String[0]), int.Parse(task1String[1]));

      var task2String = tasks[1].Split('-');
      (int start, int end) task2 = (int.Parse(task2String[0]), int.Parse(task2String[1]));
      if ((task1.start <= task2.start && task2.end <= task1.end)
          || (task2.start <= task1.start && task1.end <= task2.end)){
        sum++;
      }
    }

    Console.WriteLine(sum);
  }

  private static void Part2(string[] guide) {
    int sum = 0;

    foreach (var line in guide){
      var tasks = line.Split(',');
      var task1String = tasks[0].Split('-');
      (int start, int end) task1 = (int.Parse(task1String[0]), int.Parse(task1String[1]));

      var task2String = tasks[1].Split('-');
      (int start, int end) task2 = (int.Parse(task2String[0]), int.Parse(task2String[1]));
      if (
        task1.start <= task2.start && task2.start <= task1.end || task2.end <= task1.end &&  task1.start <= task2.end &&
        task2.start <= task1.start && task1.start <= task2.end || task1.end <= task2.end && task2.start <= task1.end){
        sum++;
      }
    }

    Console.WriteLine(sum);
  }
}