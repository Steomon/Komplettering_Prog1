using System;

namespace Komplettering
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new random number generator called "generator"
            Random generator = new Random();

            //use the random number generator to assign a value between 1-20 to the int "correctAnswer"
            int correctAnswer = generator.Next(1,21);

            //print instructions in the console
            Console.WriteLine("Guess a number between 1-20");

            //create a loop that runs until the boolean "numberFound" is True
            bool numberFound = false;
            while (!numberFound)
            {
                //take input from the user and store it in the string "inputAnswer"
                string inputAnswer = Console.ReadLine();
                
                //try to convert the input string into an int. if it can be converted, set the boolean parseSucceed to true,
                //and store the converted value of "inputAnswer" in an int called "inputAnswerInt" 
                bool parseSucceed = int.TryParse(inputAnswer, out int inputAnswerInt);

                //if the string was succesfully converted, keep running
                if (parseSucceed)
                {
                    //if the number is between 1-20, keep running
                    if (inputAnswerInt >= 1 && inputAnswerInt <= 20)
                    {
                        //if the number is correct, print win message and exit out of the while loop
                        if (inputAnswerInt == correctAnswer)
                        {
                            Console.WriteLine("Congratulations, you found the number!");
                            numberFound = true;
                        } 
                        //otherwise, tell the player if the correct answer is bigger or smaller than the number
                        else if(inputAnswerInt < correctAnswer)
                        {
                            Console.WriteLine("Try something bigger");
                        }
                        else if(inputAnswerInt > correctAnswer)
                        {
                            Console.WriteLine("Try something smaller");
                        }
                    }
                    //otherwise print an error message
                    else
                    {
                        Console.WriteLine("That number is not between 1-20. Try again!");
                    }
                }
                //otherwise, print an error message
                else
                {
                    Console.WriteLine("That is text, not a number. Try again!");
                }  
            }
            //Stop the program from closing instantly when done
            Console.ReadLine();
        }
    }
}
