using System.Text;

namespace Algorithms.App;

public class Solution
{
    public int Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Number must be non-negative.");
        if (number == 0 || number == 1)
            return 1;

        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i; // Multiply result by i to get the factorial
        }
        return result; // Return the factorial of the number
    }

    public int Fibonacci(int number)
    {
        if (number <= 0)
            return 0;
        if (number == 1)
            return 1;

        int a = 0;
        int b = 1;

        for (int i = 2; i <= number; i++)
        {
            int c = a + b; // Calculate the next Fibonacci number
            a = b;
            b = c;
        }
        return b; // Return the nth Fibonacci number
    }

    public int CountBits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count += number & 1; // Increment count if the least significant bit is 1
            number >>= 1; // Right shift the bits to check the next bit
        }
        return count;
    }

    public int CountDigits(int number)
    {
        if (number == 0)
            return 1;

        int num = Math.Abs(number);

        int count = 0;

        while (num > 0)
        {
            count++;
            num /= 10; // Remove the last digit
        }

        return count;
    }

    public int SumOfDigits(int number)
    {
        int num = Math.Abs(number);
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10; // Add the last digit to the sum
            num /= 10; // Remove the last digit
        }
        return sum;
    }

    public double GeometricSum(int number)
    {
        double factor = 1.0;
        double sum = 0.0;
        for (int i = 0; i <= number; i++)
        {
            sum += factor; // Add the current factor to the sum
            factor /= 2.0; // Halve the factor for the next term
        }
        return sum;
    }

    public int AddNumbers(int a, int b)
    {
        while (b != 0)
        {
            int carry = a & b; // Calculate the carry
            a = a ^ b; // Sum of bits of a and b where at least one of the bits is not set
            b = carry << 1; // Carry is shifted by one so that it can be added in the next iteration
        }
        return a;
    }

    public int ModNumbers(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Divisor cannot be zero.");

        int remainder = a / b;

        return a - remainder * b; // Return the remainder of a divided by b
    }

    public int Divide(int dividend, int divisor)
    {
        // Handle edge case: overflow when dividend is int.MinValue and divisor is -1
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        // Convert to long to handle int.MinValue
        long a = dividend;
        long b = divisor;

        // Determine sign
        bool isNegative = (a < 0) ^ (b < 0);

        // Use absolute values
        a = Math.Abs(a);
        b = Math.Abs(b);

        long quotient = 0;

        // Simple subtraction (but with long to prevent overflow)
        while (a >= b)
        {
            a -= b;
            quotient++;
        }

        // Apply sign
        if (isNegative)
        {
            quotient = -quotient;
        }

        return (int)quotient;
    }

    public int SingleNumber(int[] nums)
    {
        int diff = 0;
        foreach (int num in nums)
        {
            diff ^= num; // XOR operation will cancel out pairs of identical numbers, leaving the single number
        }
        return diff;
    }

    public int MissingNumber(int[] nums)
    {
        int diff = 0;

        foreach (int num in nums)
        {
            diff ^= num; // XOR operation will cancel out pairs of identical numbers, leaving the missing number
        }

        for (int i = 0; i <= nums.Length; i++)
        {
            diff ^= i; // XOR with all numbers from 0 to n will cancel out pairs of identical numbers, leaving the missing number
        }

        return diff;

    }

    public int Power(int number, int power)
    {
        long exponent = power;

        if (exponent == 0)
        {
            return 1;
        }

        if (exponent < 0)
        {
            number = 1 / number; // Invert the base for negative exponent
            exponent = -exponent; // Make the exponent positive
        }

        long result = 1;
        double current = number;
        while (exponent > 0)
        {

            if ((exponent & 1) == 1)
            {
                result *= number; // If the least significant bit is 1, multiply the result by the current base
            }
            current *= current; // Square the base for the next iteration

            exponent >>= 1; // Right shift the exponent to check the next bit
        }

        return (int)result;
    }

    public string ToHex(int number)
    {
        if (number == 0)
            return "0";
        char[] hexChars = "0123456789abcdef".ToCharArray();
        StringBuilder hexBuilder = new StringBuilder();

        uint n = (uint)number;  // Treat as unsigned to handle two's complement

        while (n > 0)
        {
            int hexDigit = (int)(n & 0xF); // Get the last 4 bits or  (n % 16)
            hexBuilder.Insert(0, hexChars[hexDigit]); // Prepend the corresponding hex character
            n >>= 4; // Right shift by 4 bits to process the next hex digit or (n /= 16)
        }

        return hexBuilder.ToString();
    }

    public int ReverseBits(int n)
    {
        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            // Shift result left to make room for next bit
            result <<= 1;

            // Add the least significant bit of n to result
            result |= (n & 1);

            // Shift n right to process next bit
            n >>= 1;
        }

        return result;
    }

    public int MinChanges(int number, int k)
    {
        if ((number & k) != k)
        {
            return -1; // If k has bits that are not set in number, it's impossible to change number to k
        }

        int diff = number ^ k; // XOR to find the bits that are different between number and k

        int changes = 0;

        while (diff > 0)
        {
            diff &= (diff - 1); // Remove the least significant bit that is set to 1
            changes++;
        }
        return changes;
    }

    public int MinimumFlips(int number)
    {
        string binaryString = Convert.ToString(number, 2); // Convert the number to its binary representation
        int flips = 0;
        for (int i = 1; i < binaryString.Length; i++)
        {
            if (binaryString[i] != binaryString[i - 1]) // Check if the current bit is different from the previous bit
            {
                flips++; // Increment the flip count if they are different
            }
        }
        return flips;
    }

    public char RepeatedCharacter(string s)
    {
        int see = 0;
        foreach (char c in s)
        {
            int index = c - 'a'; // Calculate the index for the character (assuming input is lowercase letters)
            int bit = (1 << index); // Create a bitmask for the character at the index
            if ((see & bit) != 0) // Check if the bit at the index is already set
            {
                return c; // If it is set, we have found the repeated character
            }
            see |= bit; // Set the bit at the index to mark that we have seen this character
        }
        return '\0'; // Return null character if no repeated character is found
    }
}
