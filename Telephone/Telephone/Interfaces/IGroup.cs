namespace Telephone.Interfaces
{
    public interface IGroup
    {
        public void LetterGroup(Dictionary<int, string> dictionary, List<char> language);

        public void SharpGroup(Dictionary<int, string> dictionary, List<char> language);

        public void NumberGroup(Dictionary<int, string> dictionary);
    }
}
