using System;

namespace SyntaxSugarExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ORIGINAL CODE:
            //int answer = 4;
            //string response;
            //if (answer = 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + “greater than or equal to nine”;
            //};


            //Syntax Sugar Version
            var answer = 4;

            var response = (answer == 9) ? $"{answer} + is less than nine" : $"{answer} + greater than or equal to nine";
        }
    }
}
