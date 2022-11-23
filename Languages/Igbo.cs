using ATMCONSOLEAPPINTHREELANGUAGE;
using AtmConsoleAppInThreeLanguages.Implementations;

namespace AtmConsoleAppInThreeLanguages.Languages
{
    internal static class Igbo
    {
        public static void CallIgboLanguageImplementations()
        {
            Welcome.Message("\nDaalu", "Ezigbo mmadu\n\n");
            LoginValidationInIgbo Validation = new();
            Validation.LoginVal();
        }
    }
}
