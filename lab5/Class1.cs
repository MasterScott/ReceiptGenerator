using System;

namespace lab5
{
    public class account
    {
        static int counter = 0, noOfAcc=0, accIndex=0;static string[,] usrnm_psswrd=new string[10,10];
      
        public static bool Login(string usrnm, string password)
        {
           if (checkAcc(usrnm))
            {
                string savedPin=decryptPin(usrnm_psswrd[accIndex, 1]);
                if (password == savedPin)
                    return true;
                else
                    return false;
            }
           else
            {
                return false;
            }
        }
        public static bool CrtAcct(string usrnm,string password)
        {
            if (!checkAcc(usrnm))
            {
                usrnm_psswrd[noOfAcc, 0] = usrnm;
                password = encryptPin(password);
                usrnm_psswrd[noOfAcc, 1] = password;
                noOfAcc++;
                return true;
            }
            else
                return false;

        }
        static string encryptPin(string pin)
        {
            string newStrng=null;
            char[] c = pin.ToCharArray();
            for (int i=0; i<c.Length; i++)
            {
                int code = c[i];
                if (code.ToString().Length == 2)
                    newStrng += "0";
                newStrng += code.ToString();
            }
            return newStrng;
        }
        static string decryptPin(string pin)
        {
            string newStrng = null;
            for (int i = 0; i < pin.Length; i += 3)
            {
                int ch = int.Parse(pin.Substring(i, 3));
                char chr = (char)ch;
                newStrng += chr;
            }
            return newStrng;
        }

        static bool checkAcc(string usrnm)
        {
            bool isAccExist = false;
            for (int i = 0; i <= noOfAcc; i++)
            {
                if (usrnm_psswrd[i, 0] == usrnm)
                {
                    isAccExist = true;
                    accIndex = i;
                    break;
                }
                else
                {
                    isAccExist = false;
                    continue;
                }
            }
            if (isAccExist)
                return true;
            else
                return false;
        }
    }
}
