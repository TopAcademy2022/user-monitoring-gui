namespace user_monitoring.Models
{
    public class WordBanList
    {
        private List<string> _wordBanList;

        public WordBanList()
        {
            this._wordBanList = new List<string>();
        }

        public List<string> GetProgramBanList()
        {
            return this._wordBanList;
        }

        public void AddWord(string word)
        {
            this._wordBanList.Add(word);
        }

        public void RemoveWord(string word)
        {

        }
    }
}