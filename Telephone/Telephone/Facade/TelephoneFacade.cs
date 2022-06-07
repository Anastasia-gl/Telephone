namespace Telephone.Facade
{
    internal class TelephoneFacade
    {

        Services.GroupSettings group;
        Services.LanguageSettings language;
        Info.Person person;

        public TelephoneFacade()
        {
            group = new Services.GroupSettings();
            language = new Services.LanguageSettings();
            person = new Info.Person();
        }

        public void MainSettings(string lang)
        {
            language.SetUpLang(lang);
            if (lang == "EN" || lang == "")
            {
                language.FullRussianList();
                group.LetterGroup(person.contacts, language.english);
                group.SharpGroup(person.contacts, language.russian);
                group.NumberGroup(person.contacts);

            }
            else if (lang == "RU")
            {
                language.FullEnglishList();
                group.LetterGroup(person.contacts, language.russian);
                group.SharpGroup(person.contacts, language.english);
                group.NumberGroup(person.contacts);

            }
        }
    }
}
