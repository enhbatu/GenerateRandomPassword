using System;

namespace GenerateRandomPassword
{
    public class Generator
    {
        private string PasswordStrings = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        private string PasswordNumbers = "0123456789";
        private string PasswordChars = "$#&";

        public string GeneratePasswordString(int passwordLength)
        {
            if (passwordLength < 1)
                return "";
            var rand = new Random();
            string pass = "";
            for (int i = 0; i < passwordLength; i++)
            {
                int irandom = rand.Next(52);
                pass = pass + PasswordStrings.Substring(irandom, 1);
            }
            return pass;
        }

        public string GeneratePasswordStringNumber(int passwordLength)
        {
            if (passwordLength < 1)
                return "";
            var rand = new Random();
            var strings = PasswordStrings + PasswordNumbers;
            var len = strings.Length;
            
            string pass = "";
            int irandom = 0;
            for (int i = 0; i < passwordLength - 1; i++)
            {
                irandom = rand.Next(len);
                pass = pass + strings.Substring(irandom, 1);
            }

            irandom = rand.Next(PasswordNumbers.Length);
            int pos = rand.Next(pass.Length);
            pass = pass.Substring(0, pos) + PasswordNumbers.Substring(irandom, 1) + pass.Substring(pos, pass.Length - pos);
            return pass;
        }

        public string GeneratePasswordStringNumberChar(int passwordLength)
        {
            if (passwordLength < 2)
                return GeneratePasswordStringNumber(passwordLength);
            var rand = new Random();
            string pass = GeneratePasswordStringNumber(passwordLength - 1);
            int irandom = rand.Next(PasswordChars.Length);
            int pos = rand.Next(1, pass.Length);
            pass = pass.Substring(0, pos) + PasswordChars.Substring(irandom, 1) + pass.Substring(pos, pass.Length - pos);
            return pass;
        }
    }
}
