using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmConsoleAppInThreeLanguages
{
    public static class English
    {
        public static void CallEnglishLanguageImplementations()
        {
            Welcome.Message("\nHello Awesome Person\t", "Your are welcome.\n\n");
            LoginValidation loginValidation = new LoginValidation();
            loginValidation.LoginVal();

        }
    }
}
