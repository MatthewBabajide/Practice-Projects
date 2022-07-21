using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // True or false game
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // making an array of the questions and answers
      string[] questions = {"Can pigs fly?", "Can birds sing?", "Is Matthew a fine boy?", "Are you a hater?"};

      bool[] answers = {false, true, true, true};
	  
	  //create an empty array whose length is the same as questions.
      bool[] responses = new bool[questions.Length];

	
	//validation, so every question is given an answer.
      if (questions.Length == answers.Length)
      {
  
      }
      else 
      {
        Console.WriteLine("Warning! The length of the questions and answers are unequal.");
      }
	  
	  //foreach loop, to loop through every question in "questions"
      int askingIndex = 0;
      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.WriteLine("True or false?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        while (isBool == false)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      foreach (bool response in responses)
      {
        Console.WriteLine(response);
      }

      int scoringIndex = 0;
      int score = 0;
      foreach(bool answer in answers)
      {
        bool eachResponse = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {eachResponse} | Answer: {answer}");
        if (eachResponse==answer)
        {
          score++;
        }
        scoringIndex++;
        
      }
      double percentage = score/questions.Length;
      Console.WriteLine($"You got {score} out of {questions.Length} correct: {percentage}%");
    }

    /*string[] questions = new string[]
    {

    };

    bool[] answers = new string[] 
    {

    };
    static void RunQuiz(questions, answers)
    {

    }
    */
  }
}
