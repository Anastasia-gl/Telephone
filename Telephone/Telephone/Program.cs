namespace Telephone
{
    class Program
    {
        public static void Main()
        {
            Facade.TelephoneFacade telephone = new Facade.TelephoneFacade();
            string setLang = Console.ReadLine();
            telephone.MainSettings(setLang);
        }
    }
}
