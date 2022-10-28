using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Please enter your secret message: ");
            string userMessage = Console.ReadLine();
            char[] userMessageArray = userMessage.ToLower().ToCharArray();
            char[] encryptedMessageArray = new char[userMessage.Length];

            for (int i = 0; i < userMessageArray.Length; i++)
            {
                char letter = userMessageArray[i];
                int letterLocation = Array.IndexOf(alphabet, letter);
                int cipherLetterLocation = ((letterLocation + 3) % 26);
                char cipherLetter = alphabet[cipherLetterLocation];
                encryptedMessageArray.SetValue(cipherLetter, i);
            }

            string encyrptedMessage = String.Join("", encryptedMessageArray);
            Console.WriteLine(encyrptedMessage);

        }
    }
}