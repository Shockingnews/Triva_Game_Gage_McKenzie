using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trivia_Game_Gage_McKenzie
{
    internal class Program
    {
        static int count;
        static bool trivia = true;
        static List<string> questions = new List<string>() { "Question 1#: what is your name", "test" };
        static List<string> answer = new List<string>() { "Gage", "tstanswer" };
        static List<(string, string, string, string)> playerAnswerChecker = new List<(string, string, string, string)>();
        static List<(string, string, string)> fakeAnswers = new List<(string, string, string)>() { ("Gabe", "Mason", "Colby"), ("test", "Mason", "Colby") };
        static int score;
        static Random randomnum1 = new Random();
        static Random randomnum2 = new Random();
        static Random randomnum3 = new Random();
        static Random randomnum4 = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < questions.Count(); i++)
            {
                count = 0;
                while (count == 0)
                {
                    Console.WriteLine($"{name}: {score}/{questions.Count()}");
                    Console.WriteLine($"Question {i + 1}: {questions[i]}");
                    int num = randomnum1.Next(1, 5);
                    if (num == 1)
                    {
                        Console.WriteLine($"is it 1: {answer[i]}   is it 2: {fakeAnswers[i].Item1}   is it 3: {fakeAnswers[i].Item2}   is it 4: {fakeAnswers[i].Item3}");
                        playerAnswerChecker.Add((answer[i], fakeAnswers[i].Item1, fakeAnswers[i].Item2, fakeAnswers[i].Item3));
                    }
                    if (num == 2)
                    {
                        Console.WriteLine($"is it 1: {fakeAnswers[i].Item1}  is it 2: {answer[i]}  is it 3: {fakeAnswers[i].Item2}  is it 4: {fakeAnswers[i].Item3}");
                        playerAnswerChecker.Add((fakeAnswers[i].Item1, answer[i], fakeAnswers[i].Item2, fakeAnswers[i].Item3));
                    }
                    if (num == 3)
                    {
                        Console.WriteLine($"is it 1: {fakeAnswers[i].Item1}  is it 2: {fakeAnswers[i].Item2}  is it 3: {answer[i]}  is it 4: {fakeAnswers[i].Item3}");
                        playerAnswerChecker.Add((fakeAnswers[i].Item1, fakeAnswers[i].Item2, answer[i], fakeAnswers[i].Item3));
                    }
                    if (num == 4)
                    {
                        Console.WriteLine($"is it 1: {fakeAnswers[i].Item1}  is it 2: {fakeAnswers[i].Item2}  is it 3: {fakeAnswers[i].Item3}  is it 4: {answer[i]}");
                        playerAnswerChecker.Add((fakeAnswers[i].Item1, fakeAnswers[i].Item2, fakeAnswers[i].Item3, answer[i]));
                    }


                    ConsoleKeyInfo input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.D1)
                    {
                        if (playerAnswerChecker[0].Item1 == answer[i])
                        {
                            Console.WriteLine("Correct");
                            score += 1;
                        }
                        if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item1)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item2)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item3)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        playerAnswerChecker.Remove(playerAnswerChecker[0]);
                        count = 1;
                    }
                    else if (input.Key == ConsoleKey.D2)
                    {
                        if (playerAnswerChecker[0].Item2 == answer[i])
                        {
                            Console.WriteLine("Correct");
                            score += 1;
                        }
                        if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item1)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item2)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item3)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        count = 1;
                        playerAnswerChecker.Remove(playerAnswerChecker[0]);
                    }
                    else if (input.Key == ConsoleKey.D3)
                    {
                        if (playerAnswerChecker[0].Item3 == answer[i])
                        {
                            Console.WriteLine("Correct");
                            score += 1;
                        }
                        if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item1)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item2)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item3)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        count = 1;
                        playerAnswerChecker.Remove(playerAnswerChecker[0]);
                    }
                    else if (input.Key == ConsoleKey.D4)
                    {
                        if (playerAnswerChecker[0].Item4 == answer[i])
                        {
                            Console.WriteLine("Correct");
                            score += 1;
                        }
                        if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item1)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item2)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item3)
                        {
                            Console.WriteLine("Incorrect");
                        }
                        count = 1;
                        playerAnswerChecker.Remove(playerAnswerChecker[0]);
                    }
                    else
                    {
                        Console.WriteLine("try again");
                        Console.WriteLine("press any key to continue");

                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    if (i == questions.Count())
                    {
                        Console.Clear();

                        trivia = false;
                    }
                    Console.WriteLine(" ");
                }
            }
        }

        //static void randomOrder()
        //{
        //    int num = randomnum1.Next(1,5);
        //    if(num == 1)
        //    {
        //        playerAnswerChecker.Add((answer[i], fakeAnswers[i].Item1, fakeAnswers[i].Item2, fakeAnswers[i].Item3));
        //    }
        //    if (num == 2)
        //    {
        //        playerAnswerChecker.Add((fakeAnswers[i].Item1, answer[i], fakeAnswers[i].Item2, fakeAnswers[i].Item3));
        //    }
        //    if (num == 3)
        //    {
        //        playerAnswerChecker.Add((fakeAnswers[i].Item1, fakeAnswers[i].Item2, answer[i], fakeAnswers[i].Item3));
        //    }
        //    if (num == 4)
        //    {
        //        playerAnswerChecker.Add((fakeAnswers[i].Item1, fakeAnswers[i].Item2, fakeAnswers[i].Item3, answer[i]));
        //    }
        //}

    }
}

