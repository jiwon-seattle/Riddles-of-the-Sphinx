using System;
using System.Collections.Generic;

class Sphinx {

    public static Dictionary<string, string> riddleAnswer = new Dictionary<string, string>() {};

    static void Main()
    {


      string riddleOne = "I’m tall when I’m young, and I’m short when I’m old. What am I?";
      string riddleTwo = "What has to be broken before you can use it?";
      string riddleThree = "What is full of holes but still holds water?";
      string riddleFour = "What is always in front of you but can’t be seen?";

      string answerOne = "A candle";
      string answerTwo = "An egg";
      string answerThree = "A sponge";
      string answerFour = "The future";

      riddleAnswer.Add(riddleOne, answerOne.ToLower());
      riddleAnswer.Add(riddleTwo, answerTwo.ToLower());
      riddleAnswer.Add(riddleThree, answerThree.ToLower());
      riddleAnswer.Add(riddleFour, answerFour.ToLower());

      MainGame();
    }

    static int RandomNumber(int num)
    {
      Random random = new Random();
      int index = random.Next(num);
      return index;
    }

    static void MainGame()
    {
      Console.WriteLine("Main Game");
      Console.WriteLine("Would you like to play a riddle game with Spynx? [Yes for Y / No for N]");
      string answer = Console.ReadLine().ToLower();

      if (answer == "y")
      {
          Riddle();
      }
      else
      {
          Console.WriteLine("Goodbye");
      }
    }

    static void Riddle()
    {
            List<string> riddleList = new List<string>(riddleAnswer.Keys);
            string randomRiddle = riddleList[RandomNumber(riddleList.Count)];
            Console.WriteLine(randomRiddle);
            string answerRiddle = Console.ReadLine().ToLower();


            if (riddleAnswer[randomRiddle] == answerRiddle )
            {
                Console.WriteLine("You win!")
                PlayAgain();
            }
            else
            {
                Console.WriteLine("Answer is not correct. You are my tomorrow breakfast");
            }

    }

    static void PlayAgain()
    {
        Console.WriteLine("Would you like to play again? [Yes for Y / No for N]");
        string userAnswer = Console.ReadLine().ToLower();
        if (userAnswer == "y")
        {
            Riddle();
        }
        else
        {
            Console.WriteLine("Bye");
        }
    }

}
