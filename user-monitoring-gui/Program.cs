using user_monitoring_gui.Models;
using user_monitoring_gui.Services.Interfaces;

Console.WriteLine("Hello, World!");

WordBanList wordBanList = new WordBanList();
wordBanList.AddWord("Tom");
wordBanList.AddWord("Tom");
wordBanList.AddWord("Tom");


WordBanListService wordBanService = new WordBanListService();
wordBanService.Save(wordBanList, true);