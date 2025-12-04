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
        static List<string> questions = new List<string>() { "Question 1#: what causes an infinty loop? ", "Question 2#: the most helpful code to use when making a map is?", "Question 3#: what is the right varible for a single letter?", "Question 4#: What programing languae are we using?", "Question 5#: What is the sybloe for mulitypliying?", "Question 6#: How do you make a string public?", "Question 7#: whats the quickest way to add?", "Question 8#: how to stop While Loop? while(collecting)", "Question 9#: What will it output: if(5 == num){num = 0}", "Question 10#: how many qestions were there?" };
        static List<string> answer = new List<string>() { "while", "Textfile", "Char", "C Sharp", "*", "public string", "num += 1;", "All of the above", "error", "10" };
        static List<(string, string, string, string)> playerAnswerChecker = new List<(string, string, string, string)>();
        static List<(string, string, string)> fakeAnswers = new List<(string, string, string)>() { ("for", "foreach", "if"), ("List", "Array", "none of the above"), ("String", "Tuple", "int"), ("C+", "C++", "Python"), ("X", "#", "()"), ("Public string", "public String", "Public String"), ("num = num + num;", "in your head", "none of the above"), ("return", "stop the program", "collecting = false"), ("don't Know", "nothing", "num = 0"), ("11", "5", "0") };
        static int score;
        static Random randomnum1 = new Random();
        static string secretScore;


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            
            while(trivia)
            {
                for (int i = 0; i < questions.Count(); i++)
                {
                    Console.WriteLine("press any key to continue");

                    Console.ReadKey(true);
                    Console.Clear();
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
                            Console.WriteLine($"is it 1: {fakeAnswers[i].Item2}  is it 2: {answer[i]}  is it 3: {fakeAnswers[i].Item1}  is it 4: {fakeAnswers[i].Item3}");
                            playerAnswerChecker.Add((fakeAnswers[i].Item2, answer[i], fakeAnswers[i].Item1, fakeAnswers[i].Item3));
                        }
                        if (num == 3)
                        {
                            Console.WriteLine($"is it 1: {fakeAnswers[i].Item1}  is it 2: {fakeAnswers[i].Item3}  is it 3: {answer[i]}  is it 4: {fakeAnswers[i].Item2}");
                            playerAnswerChecker.Add((fakeAnswers[i].Item1, fakeAnswers[i].Item3, answer[i], fakeAnswers[i].Item2));
                        }
                        if (num == 4)
                        {
                            Console.WriteLine($"is it 1: {fakeAnswers[i].Item3}  is it 2: {fakeAnswers[i].Item1}  is it 3: {fakeAnswers[i].Item2}  is it 4: {answer[i]}");
                            playerAnswerChecker.Add((fakeAnswers[i].Item3, fakeAnswers[i].Item1, fakeAnswers[i].Item2, answer[i]));
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
                                if (fakeAnswers[i].Item1 == "11")
                                {
                                    Console.WriteLine("Sorry lets fix that");


                                    secretScore = ($"{name}: {score}/{11}");
                                    Console.WriteLine(secretScore);
                                }
                                else { Console.WriteLine("Incorrect"); }

                            }
                            if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item2)
                            {
                                if (fakeAnswers[i].Item2 == "5")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{5}");
                                    Console.WriteLine(secretScore);

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item3)
                            {
                                if (fakeAnswers[i].Item3 == "0")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{0}");
                                    Console.WriteLine(secretScore);
                                    Console.WriteLine("I guess you win");

                                }
                                else { Console.WriteLine("Incorrect"); }
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
                                if (fakeAnswers[i].Item1 == "11")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{11}");
                                    Console.WriteLine(secretScore);

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item2)
                            {
                                if (fakeAnswers[i].Item2 == "5")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{5}");
                                    Console.WriteLine(secretScore);

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item3)
                            {
                                if (fakeAnswers[i].Item3 == "0")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{0}");
                                    Console.WriteLine(secretScore);
                                    Console.WriteLine("I guess you win");

                                }
                                else { Console.WriteLine("Incorrect"); }
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
                                if (fakeAnswers[i].Item1 == "11")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{11}");
                                    Console.WriteLine(secretScore);

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item2)
                            {
                                if (fakeAnswers[i].Item2 == "5")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{5}");
                                    Console.WriteLine(secretScore);

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item3)
                            {
                                if (fakeAnswers[i].Item3 == "0")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{0}");
                                    Console.WriteLine(secretScore);
                                    Console.WriteLine("I guess you win");

                                }
                                else { Console.WriteLine("Incorrect"); }
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
                                if (fakeAnswers[i].Item1 == "11")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{11}");
                                    Console.WriteLine(secretScore);

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item2)
                            {
                                if (fakeAnswers[i].Item2 == "5")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{5}");
                                    Console.WriteLine(secretScore);

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item3)
                            {
                                if (fakeAnswers[i].Item3 == "0")
                                {
                                    Console.WriteLine("Sorry lets fix that");

                                    secretScore = ($"{name}: {score}/{0}");
                                    Console.WriteLine(secretScore);
                                    Console.WriteLine("I guess you win");

                                }
                                else { Console.WriteLine("Incorrect"); }
                            }
                            count = 1;
                            playerAnswerChecker.Remove(playerAnswerChecker[0]);
                            Console.ReadKey(true);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("try again");
                            Console.WriteLine("press any key to continue");

                            Console.ReadKey(true);

                        }
                        
                        
                           

                        
                       
                    }
                }
                Console.WriteLine("press any key to continue");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("would you like to play again y for yes, n for no");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "y") { trivia = true; score = 0; }
                else { trivia = false; Console.WriteLine(secretScore); }
            }
        }

        

    }
}