/* Author: Brianna Drew
Student ID: 0622446
Description: This is a program that uses another class and objects to perform math involving fractions.

Data Dictionary:
 * den: int variable that will hold the number inputted by the user to be the denominator of the object fraction2.
 * fraction1: object of the Fraction class that is, obviously, a fraction.
 * fraction2: object of the Fraction class that is, obviously, a fraction.
 * fraction3: object of the Fraction class that is, obviously, a fraction.
 * num: int variable that will hold the number inputted by the user to be the numerator of the object fraction2.
 * response: char variable that will hold whether or not the user wants to run through the program again ('Y'/'y' for Yes or 'N'/'n' for No). */

using System;
public static class Driver
{
    public static void Main()
    {
        // intro to program.
        Console.WriteLine("Welcome to the Fraction Math Program!");
        // defining variable and data type.
        char response;

        do
        {
            // defining variables and data type.
            int num, den;
            // create first fraction object using first (no parameter) constructor.
            Fraction fraction1 = new Fraction();
            // create third fraction object (not using a constructor).
            Fraction fraction3;

            // prompt the user to enter numbers for the numerator and the denominator of two fractions (4 seperate numbers),
            // using properties for the first fraction and storing them in variables for the second fraction.
            Console.WriteLine(" ");
            Console.Write("Enter a numerator for the first fraction: ");
            fraction1.Numerator = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter a denominator for the first fraction: ");
            fraction1.Denominator = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(" ");
            Console.Write("Enter a numerator for the second fraction: ");
            num = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter a denominator for the second fraction: ");
            den = (Convert.ToInt32(Console.ReadLine()));

            // create second fraction object using second (two parameters, using inputted values from above stored in variables num and den) constructor.
            Fraction fraction2 = new Fraction(num, den);

            // printing out the first two fractions.
            Console.WriteLine(" ");
            Console.WriteLine("The first fraction: {0}", fraction1.ToString());
            Console.WriteLine("The second fraction: {0}", fraction2.ToString());
            Console.WriteLine(" ");

            // multiplying the first two fractions using overloaded operator and assigning that resulting fraction as the third fraction object.
            fraction3 = fraction1 * fraction2;
            // printing out the equation.
            Console.WriteLine("{0} x {1} = {2}", fraction1.ToString(), fraction2.ToString(), fraction3.ToString());

            // adding the first two fractions using overloaded operator and assigning that resulting fraction as the third fraction object.
            fraction3 = fraction1 + fraction2;
            // printing out the equation.
            Console.WriteLine("{0} + {1} = {2}", fraction1.ToString(), fraction2.ToString(), fraction3.ToString());
            Console.WriteLine(" ");

            // print out whether the first fraction is greater than or equal to the second fraction or not (using overloaded operator).
            if (fraction1 >= fraction2)
            {
                Console.WriteLine("{0} IS greater than or equal to {1}", fraction1.ToString(), fraction2.ToString());
            }
            else
            {
                Console.WriteLine("{0} is NOT greater than or equal to {1}", fraction1.ToString(), fraction2.ToString());
            }

            // print out whether the first fraction is less than or equal to the second fraction or not (using overloaded operator).
            if (fraction1 <= fraction2)
            {
                Console.WriteLine("{0} IS less than or equal to {1}", fraction1.ToString(), fraction2.ToString());
            }
            else
            {
                Console.WriteLine("{0} is NOT less than or equal to {1}", fraction1.ToString(), fraction2.ToString());
            }


            do
            {
                // prompt user to enter whether they want to do the program again or not.
                Console.WriteLine(" ");
                Console.WriteLine("Do you want to restart? Type 'Y' for yes or 'N' for no.");
                response = (Convert.ToChar(Console.ReadLine()));
            } while (response != 'N' && response != 'n' && response != 'Y' && response != 'y'); // error check to keep asking until user enters a valid response.

        } while (response != 'N' && response != 'n'); // while the user still wants to enter more fractions and have math done with them, keep basically restarting
        // the program when it reaches the "end".

        Console.ReadLine();
    }
}