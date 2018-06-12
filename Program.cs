using System;

namespace Calculator
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      PrintWelcomeMessage();

      while (true)
      {
        PerformOneCalculation();
      }
    }

    private static void PrintWelcomeMessage()
    {
      Console.WriteLine("Welcome to the calculator!");
      Console.WriteLine("==========================");
    }

    private static void PerformOneCalculation()
    {
      var op = AskForOperator();
      var n = AskForNumberArray(op);
      var a = CalculateAnswer(op, n);

      Console.WriteLine("The answer is: " + a);
      Console.WriteLine();
    }

    private static string AskForOperator()
    {
      string[] allowedOperators = { "+", "-", "*", "/" };
      Console.Write("Please enter the operator: ");
      string op = Console.ReadLine();
      return op;
    }

    private static int[] AskForNumberArray(string op)
    {
      Console.Write($"How many numbers do you want to {op}? ");

      int count = int.Parse(Console.ReadLine());

      int[] numbers = new int[count];
      for (int index = 0; index < count; index++)
      {
        numbers[index] = AddNumber($"Please enter number {index + 1}: ");
      }
      return numbers;
    }

    private static int AddNumber(string message)
    {
//      Console.Write(message);

      int number;

      int.TryParse(Console.ReadLine(), out number);

      return number;
    }

    public static int CalculateAnswer(string op, int[] numbers)
    {
      // Returns 0 if there aren't any numbers.
      int answer = numbers[0];

      int index = 0;
      foreach (int number in numbers)
      {
        if (index == 0)
        {
          // Skip this one.
        }
        else
        {
          if (op == "/")
            answer = answer / number;
          else if (op == "+")
            answer = answer + number;
          else if (op == "-")
            answer = answer - number;
          else
            Console.WriteLine("Invalid operator");
        }

        index++;
      }
      return answer;
    }
  }
}
