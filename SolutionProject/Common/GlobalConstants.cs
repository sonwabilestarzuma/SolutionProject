using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Common
{
    public static class GlobalConstants
    {
        public const string BankSystemEmail = "sonwabilestarzuma@gmail.com";

        public const string AdministratorRoleName = "Administrator";

        public const string TempDataErrorMessageKey = "ErrorMessage";
        public const string TempDataSuccessMessageKey = "SuccessMessage";

        public const string TempDataNoTwoFactorKey = "2FANotEnabled";
        public const string IgnoreTwoFactorWarningCookie = "IgnoreTwoFactorWarning";

        public const string CardExpirationDateFormat = "MM/YY";
        public const int CardValidityInYears = 4;
    }
}