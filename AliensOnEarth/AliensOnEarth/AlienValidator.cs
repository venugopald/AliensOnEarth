using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{

    public interface AlienValidatorInterface
    {
        bool IsStringValid(string value);
        bool IsIntValid(string value);
        bool IsLetterOrDigitValid(string value);

    }


    class AlienValidator : AlienValidatorInterface
    {
        public bool IsStringValid(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length > 35)
            {
                return false;
            }

            foreach (char item in value)
            {
                if (!char.IsLetter(item))
                {

                    return false;
                }
            }

            return true;

        }

        public bool IsIntValid(string value)
        {

            if (string.IsNullOrEmpty(value) || value.Length > 10)
            {
                return false;
            }

            foreach (char item in value)
            {
                if (!char.IsDigit(item))
                {
                    return false;
                }
            }

            return true;
        }


        public bool IsLetterOrDigitValid(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length > 35)
            {
                return false;
            }

            foreach (char item in value)
            {
                if (!char.IsLetterOrDigit(item))
                {

                    return false;
                }
            }

            return true;

        }

    }
}
