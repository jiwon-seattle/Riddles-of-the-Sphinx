using System;

class Spynx {
    static void Main()
    {   
        Console.WriteLine("Main Game");
        Console.WriteLine("Do you want to start riddle game? Please say Y if you are okay");
        string answer = Console.ReadLine().ToLower();

        if (answer == "y") 
        {
            Riddle();
        }
        else
        {
            Console.WriteLine("Good bye");
        }
    }
    static void Riddle() 
    {
            Console.WriteLine("What has to be broken before you can use it?");
            string answerRiddle = Console.ReadLine().ToLower();

            // int index = Random.Next(list.Count);
            // Console.WriteLine();

            if (answerRiddle == "egg" || answerRiddle == "an egg")
            {
                Riddles();
                PlayAgain();
            }
            else
            {
                Console.WriteLine("Answer is not correct. You are my tomorrow breakfast");
            }
        
    }

    static void PlayAgain()
    {
        Console.WriteLine("Would you like to play again?");
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

    static void Riddles()
    {
        List<string> riddles = new List<string>{};
        string riddleOne = "I’m tall when I’m young, and I’m short when I’m old. What am I?";
        string riddleTwo = "I’m tall when I’m young, and I’m short when I’m old. What am I?";
        string riddleThree = "What is full of holes but still holds water?";
        string riddleFour = "What is always in front of you but can’t be seen?";

        riddles.Add(riddleOne);
        riddles.Add(riddleTwo);
        riddles.Add(riddleThree);
        riddles.Add(riddleFour);
        Console.WriteLine(riddles[0]);


        List<string> answers = new List<string>{};
        string answerOne = "A candle";
        string answerTwo = "An egg";
        string answerThree = "A sponge";
        string answerFour = "The future";

        answers.Add(answerOne);
        answers.Add(answerTwo);
        answers.Add(answerThree);
        answers.Add(answerFour);
        return answers;

        Dictionary <string, string> riddleAnswer = new Dictionary<string, string>() {};

        foreach (string riddle in riddles)
        {
            riddleAnswer.Add(riddle);
        }
    }
}