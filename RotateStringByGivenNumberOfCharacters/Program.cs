using System;
using System.Text;

namespace RotateStringByGivenNumberOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Input String");
            var inputString = Console.ReadLine();
            Console.WriteLine("Enter the number of chars you what to rotate the string by");
            int noOfCharatersToRotate= Convert.ToInt32(Console.ReadLine());
            StringBuilder resultString = new StringBuilder();
            if (noOfCharatersToRotate <= inputString.Length)
            {
                var StartString = inputString.Substring(0, inputString.Length - noOfCharatersToRotate);
                var rotateString = inputString.Substring(inputString.Length - noOfCharatersToRotate); 
                resultString.Append(rotateString).Append(StartString);
                Console.WriteLine("resultString {0}", resultString);
                
            }
            else
            
                Console.WriteLine("your string doesnt have sufficient characters to perform the rotate by given number of characters");

            Console.ReadLine();


        }
    }
}
