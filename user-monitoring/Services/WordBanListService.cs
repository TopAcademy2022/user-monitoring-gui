using System.Text;
using user_monitoring.Models;
using user_monitoring.Services.Interfaces;


namespace user_monitoring.Services
{
    public class WordBanListService : IWordBanListService
    {
        public bool Save(WordBanList wordBanList, bool save_file = true)
        {
            if (save_file)
            {

                //
                //    string docPath = "..\\";

                //    StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WordBanList.txt"), true);

                //    outputFile.WriteLine(wordBanList);

                using (FileStream fstream = new FileStream("WordBanList.txt", FileMode.Append))
                {

                    var bytes = wordBanList.GetProgramBanList().Select(i => Encoding.Default.GetBytes($"{i}\n")).ToArray();                    

                    foreach(var item in bytes)
                    {
                        fstream.Write(item, 0, item.Length);
                    }        
                }

                return true;
            }
            else
            {

            }


            return false;
        }

        public bool Load()
        {
            return false;
        }

    }
}