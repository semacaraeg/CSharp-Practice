using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        //array of alphabet chars
        static char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
            'W', 'X', 'Y', 'Z'};
        
        //default to 3
        static int key = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your phrase to be encoded:");
            string userInput = Console.ReadLine();
            Console.WriteLine("How many keys do you want to shift?");
            //ask user how many key shift from user
            key = int.Parse(Console.ReadLine());

            string encodedString = Encipher(userInput, key);
            string decoded = Decipher(encodedString, key);
            Console.WriteLine(encodedString);
            Console.WriteLine(decoded);
            Console.Read();
        }

      
        //Encoding based on the key shift
        static string Encode(string userInput) {
            string userUpperCase = userInput.ToUpper();
            char[] inputCharArray = userUpperCase.ToCharArray();
            string encoded = string.Empty;
            int counter=0;
            
            while (counter < inputCharArray.Length)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (inputCharArray[counter] == alphabet[i] && inputCharArray[counter] != ' ')
                    {
                        if ((i + key) <= 25)
                        {
                            encoded += alphabet[i + key];
                        }
                        else if ((i + key) > 25)
                        {
                            
                            encoded += alphabet[((i+key)-25)-1];  
                        }

                    }
                    else if (inputCharArray[counter].Equals(' '))
                    {
                        encoded += " ";
                        break;
                    }

                }
                counter++;
            }
            Console.WriteLine("Encoded string is: " + encoded);
            return encoded;
            
        }

        static string Encipher(string encoded, int userKey) {
            userKey %= 26;
            string output = string.Empty;
            char newChar;

            foreach (var letter in encoded)
            {
                if (!char.IsLetter(letter))
                {
                    output += letter;
                }
                else{
                    //Console.WriteLine("Letter + key value: " + (letter+key));    
                    char d = char.IsUpper(letter) ? 'A' : 'a';
                    newChar = (char)((((letter + userKey) - d) % 26) + d);
                    output += newChar;
                }
            }
            return output;

        }
        static string Decipher(string encoded, int userKey) {
           return Encipher(encoded, (26 - userKey));
        }
    }
}
