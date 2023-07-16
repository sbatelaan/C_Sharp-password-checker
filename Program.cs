using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "QWERTYUIOPLKJHGFDSAZXCVBNM";
            string lowercase = "qwertyuioplkjhgfdsazxcvbnm";
            string digits = "1234567890";
            string specialChars = "!@#$%^&*()";
            
            Console.WriteLine("Enter a password: ");
            string userPassword = Console.ReadLine();

            int score = 0;

            if (userPassword.Length >= minLength) {
                score ++;
            } if (Tools.Contains(userPassword, uppercase)) {
                score ++;
            } if (Tools.Contains(userPassword, lowercase)) {
                score ++;
            } if (Tools.Contains(userPassword, digits)) {
                score ++;
            } if (Tools.Contains(userPassword, specialChars)) {
                score ++;
            }

            switch (score) {
                case 1: 
                Console.WriteLine("weak");
                break;
                case 2: 
                Console.WriteLine("mid");
                break;
                case 3: 
                Console.WriteLine("strong");
                break;
                case 4: 
                Console.WriteLine("very strong");
                break;
                case 5: 
                Console.WriteLine("very strong");
                break;

            }






        }
    }
}