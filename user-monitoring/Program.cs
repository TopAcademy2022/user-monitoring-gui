using user_monitoring.Models;
using user_monitoring.Services;

Console.WriteLine("Hello, World!");

WordBanList wordBanList = new WordBanList();
wordBanList.AddWord("Tom");
wordBanList.AddWord("Tom");
wordBanList.AddWord("Tom");


WordBanListService wordBanService = new WordBanListService();
wordBanService.Save(wordBanList, true);