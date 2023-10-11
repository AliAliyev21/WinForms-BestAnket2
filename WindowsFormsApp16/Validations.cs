using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    public class Validations
    {

        /// <summary>
        /// This function checks the validity of a name
        /// The name must not be empty and must contain only letter characters
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Returns true if the name is valid, false otherwise
        /// </returns>
        public static bool IsNameValid(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The name cannot be empty");
            }
            foreach(char  c in name)
            {
                if(!char.IsLetter(c))
                {
                    throw new ArgumentException("The name must be in letters only");
                }
            }
            return true;
        }



        /// <summary>
        /// This function checks the validity of a surname
        /// The surname must not be empty and must contain only letter characters
        /// </summary>
        /// <param name="surname"></param>
        /// <returns>
        /// Returns true if the name is valid, false otherwise
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsValidSurname(string surname)
        {
            if(string.IsNullOrWhiteSpace (surname))
            {
                throw new ArgumentException("The surname cannot be empty");
            }
            foreach(char c in surname)
            {
                if (!char.IsLetter(c))
                {
                    throw new ArgumentException("The surname must be in letters only");
                }
            }
            return true;
        }



        /// <summary>
        /// This function checks the validity of an email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns>
        /// Returns true if the email address is valid, false otherwise
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsEmailValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(email, emailPattern))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Invalid email address");
            }
        }



        /// <summary>
        /// This function checks the validity of a phone number.
        /// The phone number must consist of only numbers and can contain a maximum of 12 digits
        /// </summary>
        /// <param name="phoneNumber">Phone number to check</param>
        /// <returns>
        /// Returns true if the phone number is valid, false otherwise
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            foreach(char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("A phone number containing invalid characters");
                }
            }
            if(phoneNumber.Length <=12)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("The phone number can contain a maximum of 12 digits");
            }
        }



        /// <summary>
        /// Checks the validity of the JSON file name
        /// </summary>
        /// <param name="jsonFileName">The name of the JSON file to be checked</param>
        /// <returns>
        /// Returns true if the JSON file name is valid, false otherwise
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsJsonFileNameValid(string jsonFileName)
        {
            if(string.IsNullOrWhiteSpace(jsonFileName))
            {
                throw new ArgumentException("JSON filename cannot be empty");
            }
            if(jsonFileName.Any(c=> !char.IsLetterOrDigit(c) && c != '_' && c!= '.'))
            {
                throw new ArgumentException("Invalid JSON filename");
            }
            return true;
        }
    }
}
