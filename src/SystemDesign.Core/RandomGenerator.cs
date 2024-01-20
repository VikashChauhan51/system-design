using System.Security.Cryptography;

namespace SystemDesign.Core;

public static class RandomGenerator
{
    /// <summary>
    ///  Random generator.
    /// </summary>
    private static readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();

    /// <summary>
    /// A constant string of possible characters for the short url
    /// </summary>
    private const string UrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    public static string GenerateRandomString(int length)
    {
        // Create a byte array to store the random bytes
        byte[] bytes = new byte[length];

        rng.GetBytes(bytes);


        // Convert the byte array to a character array
        char[] chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            // Use the byte value as an index to the UrlCharacters string
            chars[i] = UrlCharacters[bytes[i] % UrlCharacters.Length];
        }

        // Return the character array as a string
        return new string(chars);
    }
}
