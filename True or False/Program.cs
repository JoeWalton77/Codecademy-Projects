using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            //The below three lines and the Tools.cs file were made by codecademy 
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions1 = { "The tallest mountain in the world is Mount Everest.", "The world’s longest coastline is in China.", "The largest ocean in the world is the" +
                    " Atlantic Ocean.", "Of all the states in the union, Alaska has the most active volcanoes.", "The Mississippi and the Nile are the two longest rivers in the" +
                    " world." };
            bool[] answers1 = { true, false, false, true, false };
            string[] questions2 = { "The human eyes can observe 10 million different colors.", "The tongue is the only part of the human body with taste buds.", "The average" +
                    " human body consists of 60% water.", "The human brain contains the maximum amount of muscle density.", "The liver is the largest internal organ in the" +
                    " human body." };
            bool[] answers2 = { true, false, true, false, true };
            string[] questions3 = { "By the number of locations, McDonald’s has the most eateries in the US.", "On the space shuttle, a potato was planted as the first crop.", 
                "There are always even numbers of rows on corn ears.", "The most costly spice in the world is vanilla.", "French fries are a French invention." };
            bool[] answers3 = { false, true, true, false, false };
            //trivia questions from https://quizandsurveymaster.com/best-true-and-false-questions-with-answers/

            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Would you like to take the quiz named 'Geography', 'Human Body', or 'Food'?");
                string quizDecision = Console.ReadLine();

                if (quizDecision == "Geography")
                {
                    RunQuiz(questions1, answers1);
                }

                else if (quizDecision == "Human Body")
                {
                    RunQuiz(questions2, answers2);
                }

                else if (quizDecision == "Food")
                {
                    RunQuiz(questions3, answers3);
                }
                continue;
            }
        }

        static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responses = new bool[5];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("The number of answers is not equal to the number of questions.");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool = false;
                bool inputBool = false;
                Console.WriteLine(question);

                while (!isBool)
                {
                    Console.WriteLine("Please enter either 'true' or 'false': ");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {responses[scoringIndex]} | Answer: {answers[scoringIndex]}");

                if (answer == response)
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of 5 correct!");
        }
    }
}

