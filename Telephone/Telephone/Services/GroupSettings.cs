namespace Telephone.Services
{
    internal class GroupSettings : Interfaces.IGroup
    {
        private readonly string[] sharp = new string[1] { "#" };
        private readonly int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void LetterGroup(Dictionary<int, string> dictionary, List<char> language)
        {
            foreach (char letter in language)
            {
                int count = 0;

                foreach (var items in dictionary)
                {
                    if (items.Value.StartsWith(letter))
                    {
                        count++;
                        if (count == 1)
                        {
                            Console.WriteLine(letter);
                        }

                        Console.Write(items.Key + " " + items.Value + "\n");
                    }
                }
            }
        }

        public void SharpGroup(Dictionary<int, string> dictionary, List<char> language)
        {
            Console.Write(sharp[0] + "\n");

            foreach (var items in dictionary)
            {
                foreach (char letter in language)
                {
                    if (items.Value.StartsWith(letter))
                    {
                        Console.WriteLine(items.Key + " " + items.Value);
                    }
                }
            }
        }

        public void NumberGroup(Dictionary<int, string> dictionary)
        {
            foreach (var surmane in dictionary.Values)
            {
                int count = 0;
                if (char.IsDigit(surmane[0]))
                {
                    string a = surmane[0].ToString();
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        string b = numbers[j].ToString();

                        if (a == b)
                        {
                            count++;
                            if (count == 1)
                            {
                                Console.WriteLine(numbers[j]);
                            }

                            Console.WriteLine(surmane);
                        }
                    }
                }
            }
        }
    }
}