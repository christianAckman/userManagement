using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;


namespace MasterApp{
    class ReU{

        #region String Methods
        public string encodeString(string plainText){

            try{
                var plainTextBytes = Encoding.Unicode.GetBytes(plainText);
                return Convert.ToBase64String(plainTextBytes);
            }

            catch{
                return null;
            }
        }
        public string decodeString(string EncodedText){

            try{
                var encodedTextBytes = Convert.FromBase64String(EncodedText);
                string plainText = Encoding.Unicode.GetString(encodedTextBytes);
                return plainText;
            }

            catch{
                return null;
            }
        }
        public SecureString convertToSecureString(String password){

            SecureString securePass = new SecureString();

            foreach (char c in password){
                securePass.AppendChar(c);
            }

            return securePass;
        }

        public string arrayToString(Array myArray){
            string newString = String.Empty;

            foreach(char i in myArray){
                newString += i;
            }

            return newString;
        }
        public List<String> stringToListDelimitedSpaces(String myString){

            List<String> newList;

            newList = new List<String>();

            newList = myString.Split(' ').ToList();

            return newList;
        }
        public List<String> stringToListDelimitedCommas(String myString){

            List<String> newList;

            newList = new List<String>();

            newList = myString.Split(',').ToList();

            return newList;
        }

        public string removeAllSpaces(String myString){

            char space = ' ';                   // Char to delete

            myString = myString.Trim(space);    // Remove and store

            return myString;                    // Return
        }

        public Boolean stringOnlyLetters(String myString){
            Boolean tester;

            for(int i = 0; i < myString.Length; i++){       // Loop through string

                if (char.IsLetter(myString[i])){            // Check if character is a letter
                    tester = true;

                    if (tester == false){
                        return false;                       // Return false if tester is not letter
                    }
                }
            }
            return true;                                    // Return true if method makes it this far
        }
        public Boolean stringHasNumbers(String myString)
        {

            for (int i = 0; i < myString.Length; i++)
            {  // Loop through string

                if (char.IsDigit(myString[i]))
                {         // If a character has a digit
                    return true;                        // Return true
                }
            }

            return false;                               // String has no numbers
        }
        public Boolean stringHasSpaces(String myString)
        {

            for (int i = 0; i < myString.Length; i++)
            {          // Loop through string

                if (char.IsWhiteSpace(myString[i]))
                {            // Check characters for space
                    return true;                                // Return if true
                }
            }
            return false;
        }
        #endregion





    }
}
