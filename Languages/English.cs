using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;

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
