using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTestExpleo
{
    public class Calculator
    {

        //Problem 3 Calculator level 1
        public static double CalculatorLevel1(string input)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;
            bool check = true;


            while (check)
            {
                // Error handling user input
                try
                {
                    

                    string[] numberArray = input.Split(new char[] { '+', '-', '*', '/' });
                    char[] charArray = input.ToCharArray();


                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        if (i == 0)
                            firstNumber = double.Parse(numberArray[0]);

                        if (i == 1)
                            secondNumber = double.Parse(numberArray[1]);

                        for (int j = 0; j < charArray.Length; j++)//checks what operator and sets the result.
                        {
                            if (charArray[j] == '+')
                                result = firstNumber + secondNumber;

                            if (charArray[j] == '-')
                                result = firstNumber - secondNumber;

                            if (charArray[j] == '*')
                                result = firstNumber * secondNumber;

                            if (charArray[j] == '/')
                                result = (firstNumber) / (secondNumber);
                        }
                    }
                    check = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Fel format vid inmatning");
                }
            }

            return result;
        }


        //Uppgift 3 kalkylator level 2
        public static double CalculatorLevel2(string input)
        {

            
            string[] numberArray = input.Split(new char[] { '+', '-', '*', '/' });
            string[] StoredOperators = input.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            List<string> listofoperators = new List<string>();

            for (int i = 0; i < StoredOperators.Length; i++)
            {
                //Adding only the filed indexes from array into list. 
                if (StoredOperators[i] != "")
                {
                    listofoperators.Add(StoredOperators[i]);
                }
            }

            double result = 0;
            result = double.Parse(numberArray[0]);

            for (int i = 0; i < listofoperators.Count; i++)
            {
                if (listofoperators[i] == "+")
                {
                    result += double.Parse(numberArray[i + 1]);//Checks the next index, and set result to the current index (+,-,/,*) the next index.
                }
                if (listofoperators[i] == "-")
                {
                    result -= double.Parse(numberArray[i + 1]);
                }
                if (listofoperators[i] == "*")
                {
                    result *= double.Parse(numberArray[i + 1]);
                }
                if (listofoperators[i] == "/")
                {
                    result /= double.Parse(numberArray[i + 1]);
                }
            }
            return result;
        }
    }
}
