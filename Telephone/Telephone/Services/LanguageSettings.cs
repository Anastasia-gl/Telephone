using System.Globalization;

namespace Telephone.Services
{
    internal class LanguageSettings : Interfaces.ILanguage
    {
        internal List<char> english = new List<char>();

        internal List<char> russian = new List<char>();

        private CultureInfo info = CultureInfo.CurrentCulture;

        public void FullRussianList()
        {
            for (char i = 'А'; i <= 'Я'; i++)
            {
                russian.Add(i);
            }
        }

        public void FullEnglishList()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                english.Add(i);
            }
        }

        public void SetUpLang(string? lang)
        {
            info = CultureInfo.CreateSpecificCulture(lang);

            if (info.TwoLetterISOLanguageName == "en" || lang == "")
            { 
                FullEnglishList();
            }
            else if (info.ThreeLetterISOLanguageName == "rus")
            {
                FullRussianList();
            }
        }
    }
}