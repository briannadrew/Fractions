/* Author: Brianna Drew
Student ID: 0622446
Description: This is the class (driven by the class "Driver") to basically take care of the mathematics and verifications behind the fractions and of course construct
the fractions into objects, the properties being the numerator and the denominator.

Data Dictionary:
 * added: object created in the + overloaded operator to be the fraction that is the sum of the first two fractions.
 * den: int variable parameter passed to the second Fraction() constructor from the Driver class to hold the denominator of the fraction.
 * denominator: private int variable that represents the denominator of the fraction object.
 * fract1: parameter representing the first fraction object used in all overloaded operators to use it's numerator and denominator properties (assigning and
 *         calculating).
 * fract2: parameter representing the second fraction object used in all overloaded operators to use it's numerator and denominator properties (assigning and
 *         calculating).
 * GCD: int variable that will hold the greatest common denominator of two fractions calculated in the Reduce() method.
 * multipication: object created in the * overloaded operator to be the fraction that is the product of the first two fractions.
 * newnum1: int variable used in the + overloaded operator that will hold the first number calculated to be used to calculate the numerator of the fraction
 *          representing the sum of the first two fractions.
 * newnum2: int variable used in the + overloaded operator that will hold the second number calculated to be used to calculate the numerator of the fraction
 *          representing the sum of the first two fractions.
 * num: int variable parameter passed to the second Fraction() constructor from the Driver class to hold the numerator of the fraction.
 * numerator: private int variable that represents the numerator of the fraction object.
 * val1: double variable used in the >= and <= overloaded operators to hold the calculated floating point value of the first fraction to be compared to the second
 *       fraction's floating point value to return a boolean value. 
 * val2: double variable used in the >= and <= overloaded operators to hold the calculated floating point value of the second fraction to be compared to the first
 *       fraction's floating point value to return a boolean value. */

using System;
public class Fraction
{
    // defining variables and their data types.
    private int numerator;
    private int denominator;

    // no parameter constructor.
    public Fraction()
    {
        // setting the values of variables.
        numerator = 0;
        denominator = 1;
    }

    // two parameter constructor.
    // parameters: num representing the user-inputted numerator value and den representing the user-inputted denominator value.
    public Fraction(int num, int den)
    {
        // setting the values of variables to the values passed from Driver class.
        numerator = num;
        // if the denominator is 0, change it to 1 so there is no error.
        if (den == 0)
        {
            denominator = 1;
        }
        else
        {
            denominator = den;
        }
        // reduce the fraction to simplest form.
        Reduce();
    }

    // numerator property.
    public int Numerator
    {
        // setting the numerator property to the given value.
        get
        { return numerator; }
        set
        { numerator = value;}
    }

    // denominator property.
    public int Denominator
    {
        // setting the denominator property to the given value.
        get
        { return denominator; }
        set
        {
            // if the denominator is 0, change it to 1 so there is no error.
            if (value == 0)
            {
                denominator = 1;
            }
            else
            {
                denominator = value;
            }
            // reduce the fraction to simplest form.
            Reduce();
        }
        
    }

    // reduce method.
    private void Reduce()
    {
        int GCD = 0;
        // find the greatest common divider by calculating remainders.
        for (int x = 1; x <= denominator; x++)
        {
            if ((numerator % x == 0) && (denominator % x == 0))
                GCD = x;
        }
        // if there is a remainder, simplify the fraction by dividing both numbers by the GCD.
        if (GCD != 0)
        {
            numerator = numerator / GCD;
            denominator = denominator / GCD;
        }
    }

    // to string method.
    public override string ToString()
    {
        // create a string to represent the fraction to be printed out in the Driver class.
        return numerator + "/" + denominator;
    }

    // multiply operator.
    // parameters: fract1 representing the first fraction object and fract2 representing the second fraction object.
    public static Fraction operator*(Fraction fract1, Fraction fract2)
    {
        // create new fraction object to represent the product of the first two fractions.
        Fraction multipication = new Fraction();

        // multiply the two numerators and the two denominators of the fractions together to get the new numerator and denominator of the fraction that represents
        // the product of the first two fractions.
        multipication.numerator = fract1.numerator * fract2.numerator;
        multipication.denominator = fract1.denominator * fract2.denominator;

        // reduce the calculated fraction to it's simplest form.
        multipication.Reduce();

        return multipication;
    }

    // add operator.
    // parameters: fract1 representing the first fraction object and fract2 representing the second fraction object.
    public static Fraction operator+(Fraction fract1, Fraction fract2)
    {
        // create new fraction object to represent the sum of the first two fractions.
        Fraction added = new Fraction();

        // cross-multiply the fractions to get two numbers to be added together to be the new numerator of the fraction that represents the sum of the first two
        // fractions.
        int newnum1 = fract1.numerator * fract2.denominator;
        int newnum2 = fract2.numerator * fract1.denominator;
        added.numerator = newnum1 + newnum2;

        // multiply the two denominators of the fractions together to get the new denominator of the fraction that represents the sum of the first two fractions.
        added.denominator = fract1.denominator * fract2.denominator;

        // reduce the calcuated fraction to it's simplest form.
        added.Reduce();

        return added;
    }

    // greater than or equal operator.
    // parameters: fract1 representing the first fraction object and fract2 representing the second fraction object.
    public static bool operator>=(Fraction fract1, Fraction fract2)
    {
        // calculate floating point value of each of the first two fractions.
        double val1 = (double)fract1.numerator / fract1.denominator;
        double val2 = (double)fract2.numerator / fract2.denominator;

        // compare the floating point values and return true if the first is less than or equal to the second, false if it is not.
        if (val1 >= val2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // less than or equal operator.
    // parameters: fract1 representing the first fraction object and fract2 representing the second fraction object.
    public static bool operator<=(Fraction fract1, Fraction fract2)
    {
        // calculate floating point value of each fraction.
        double val1 = (double)fract1.numerator / fract1.denominator;
        double val2 = (double)fract2.numerator / fract2.denominator;

        // compare the floating point values and return true if the first is less than or equal to the second, false if it is not.
        if (val1 <= val2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}