namespace ProgrammingMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Time");

            // Addition.
            // use the + operator to add numbers

            int sum = 5 + 10;
            Console.WriteLine($"The sum of 5 + 10 is {sum}.");

            // Substraction
            // use the - operator to subtract numbers
            int difference = 30 - 10;
            Console.WriteLine($"The difference of 30 - 10 is {difference}.");

            // Multiplication
            // Use the * operator to multiple numbers
            int product = 3 * 10;
            Console.WriteLine($"The product of 3 x 10 is {product}.");

            // Division
            // Use the / operator to divide numbers

            int dividend = 20 / 5;
            Console.WriteLine($"The dividend of 20 / 5 is {dividend}.");

            // When dividing integers, unless the value can be fully divided, the result will always round down.
            // The integer will not convert to a double automatically.
            // In the case below, the value of "dividend2" will be 4.
            int dividend2 = 22 / 5;
            Console.WriteLine($"The dividend of 22 / 5 is {dividend2}.");

            // To divide a number and ensure we get the decimal places, we need to divide a double data type
            // We must also make sure that at least one of the numbers in the operation has a decimal point,
            // otherwise integer division will take place.
            double dividend3 = 22.0 / 5;
            Console.WriteLine($"The divident of 22.0 / 5 is {dividend3}.");

            // Modulus
            // The modulus operator % is used to give us the remainder of a divison operation.
            // Note that the modulus operator is only applicable for integer division
            int remainder = 8 % 5;
            Console.WriteLine($"The remainder of 8 / 5 is {remainder}.");

            // Modulus will always print the remainder, regardless of how large the division is.
            int remainder2 = 9388 % 5;
            Console.WriteLine($"The remainder of 9388 / 5 is {remainder2}.");

            // Combined Assignment Operator
            // There is a special operator that can be used with the basic arithmetic operators to 
            // merge operation and assignment together, this can clean up our code a bit.
            int firstNumber = 5;
            firstNumber = firstNumber + 10;

            Console.WriteLine($"The first number is now {firstNumber}.");

            // We can simplify the same operation using the combined assignment operator

            int secondNumber = 5;
            secondNumber += 10;
            Console.WriteLine($"The second number is now {secondNumber}.");

            // The combined assignment operator can be used for all of the basic arithmetic operators.
            // +=  (addition)
            // -=  (subtraction)
            // *=  (multiplication)
            // /=  (division)
            // %=  (modulus)

            // Exponents
            // To perform exponent operations, we must use a special method called Math.Pow()
            // Math.Pow() takes two numbers:
            // - the first number is the number we want to take the power of.
            // - The second number is the exponent
            // The result of Math.Pow is always a "double" data type.
            double exponentResult = Math.Pow(2, 4);
            Console.WriteLine($"2 to the power of 4 is {exponentResult}.");

            // Square root
            // Similar to exponents, to perform a square root operation we need to use Math.Sqrt()
            // Math.Sqrt() takes one number, the number of which we want the square root
            double squareRootResult = Math.Sqrt(25);
            Console.WriteLine($"The square root of 25 is {squareRootResult}.");

            // Rounding
            // To round a number to a specific decimal place, we use the Math.Round() method
            // Math.Round takes two numbers, the number to round and the number of decimal places.
            // We must make sure to assign the result either a new variable or the original one.
            double numberToRound = 123.677888;
            numberToRound = Math.Round(numberToRound, 3);
            Console.WriteLine($"The number {numberToRound} has been rounded to 3 decimal places.");

            // Order of operations.
            // Programming mathematics follows the standard order of operations when it comes to mathematical formulas
            // The pneumonic for the order of operations is BEDMAS (Brackets, Exponents, Division, Multiplication, Addition, Subtraction)
            // Here is an example of this in action.

            int orderExample = 5 + 15 / 3 - 1;

            Console.WriteLine($"The result of 5 + 15 / 3 - 1 is {orderExample}.");

            // because of the order of operations, the result of this equation is 9. This is how it was calculated step by step.
            // 1. Brackets (none)
            //    5 + 15 / 3 - 1
            // 2. Exponents (none)
            //    5 + 15 / 3 - 1
            // 3. Division
            //    5 + 5 - 1
            // 4. Multiplication (none)
            //    5 + 5 - 1
            // 5. Addition
            //    10 - 1
            // 6. Subtraction
            //    9

            int orderExampleWithBrackets = (5 + 15) / (3 - 1);
            Console.WriteLine($"The result of (5 + 15) / (3 - 1) is {orderExampleWithBrackets}");

            // The result of the above example is now 10, because we added round brackets.
            // Whatever calculations exist inside round brackets will always take place first.
            // So if we want to structure our calculation to give us a certain result, we can use brackets to do this.
            // In this case, the order of operations went like this:

            // (5 + 15) / (3 - 1)

            // 1. Brackets
            //    20 / 2
            // 2. Exponents (none)
            //    20 / 2
            // 3. Division
            //    10
            // 4. Multiplication (none)
            //    10
            // 5. Addition (none)
            //    10
            // 6. Subtraction (none)
            //    10
        }
    }
}
