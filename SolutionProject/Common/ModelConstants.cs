using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Common
{
    public static class ModelConstants
    {
        public static class User
        {
            public const int FullNameMaxLength = 40;

            public const int PasswordMaxLength = 20;
            public const int PasswordMinLength = 6;

            public const string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,100}$";

            public const string PasswordErrorMessage =
                "Password minimum length is 6 characters and it must contain at least one uppercase letter, one lowercase letter and one number.";
        }

        public static class BankAccount
        {
            public const int NameMaxLength = 25;
            public const int UniqueIdMaxLength = 32;
            public const int SwiftCodeMaxLength = 22;
            public const int CountryMaxLength = 45;
        }

        public static class Card
        {
            public const int NameMaxLength = 60;

            public const int ExpiryDateMaxLength = 5;
            public const int SecurityCodeMaxLength = 3;
        }

        public static class MoneyTransfer
        {
            public const int DescriptionMaxLength = 140;
            public const string MinStartingPrice = "0.01";
            public const string MaxStartingPrice = "36985262514264337593541458963";
        }
    }
}