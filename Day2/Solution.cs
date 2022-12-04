//https: //adventofcode.com/2022/day/1

namespace AdventOfCode.Day2;

public class Day2 {
  private static readonly (int win, int draw, int loose) Points = (6, 3, 0);
  public static void Main() {
    string[] guide = File.ReadAllLines(@"C:\Users\Indeed\Desktop\Stuff\Repositories\c#\AdventOfCode\Day2\Input.txt");
    Console.WriteLine(Part1(guide));
    Console.WriteLine(Part2(guide));
  }

  private static int Part1(string[] guide) {
    var choices = new Dictionary<char, (char choice, int value, char winningChoice)> {
      {'A', ('X', 1, 'Y')}, //Rock
      {'B', ('Y', 2, 'Z')}, //Paper
      {'C', ('Z', 3, 'X')}  //Scissors
    };
    
    int score = 0;
    foreach (var line in guide){
      char enemy = line[0];
      char me = line[2];

      var enemyChoice = choices[enemy];
      var myChoice = choices.First(x => x.Value.choice == me);

      score += myChoice.Value.value;
      if (enemyChoice.choice == me) score += Points.draw;            //draw
      else if (enemyChoice.winningChoice == me) score += Points.win; //win
      else score += Points.loose;                                    //loose
    }

    return score;
  }

  private static int Part2(string[] guide) {
    int score = 0;
    var choices = new Dictionary<char, (int value, char winningChoice)> {
      {'A', (1, 'B')}, //Rock
      {'B', (2, 'C')}, //Paper
      {'C', (3, 'A')}  //Scissors
    };
    (char loose, char win, char draw) results = ('X', 'Z', 'Y');
    foreach (var round in guide){
      var enemyChoice = round[0];
      var result = round[2];

      if (result == results.win){
        score += Points.win;
        score += choices[choices[enemyChoice].winningChoice].value;
      }
      else if (result == results.draw){
        score += Points.draw;
        score += choices[enemyChoice].value;
      } 
      else if (result == results.loose){
        score += Points.loose;

        var myChoice = choices.First(x
          => x.Key != enemyChoice && //isn't a draw
             x.Key != choices[enemyChoice].winningChoice //isn't a win
        );
        score += myChoice.Value.value;
      }

    }

    return score;
  }
}