using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring_gui.Services
{
    public class ConsoleUserInterface : IUserInterface
    {
        public void PrintMenu()
        {
            const uint NUMBER_EXIT_MENU_ELEMENT = 6;
            int numberMenuElement = 0;

            while (numberMenuElement != NUMBER_EXIT_MENU_ELEMENT)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("***********************************************");
                Console.WriteLine("\t====== Меню ======\n");
                Console.WriteLine("1. Настроить");
                Console.WriteLine("2. Редактировать список запрещённых слов");
                Console.WriteLine("3. Редактировать список запрещённых программ");
                Console.WriteLine("4. Запустить");
                Console.WriteLine("5. Показать статистику");
                Console.WriteLine("6. Выход\n");
                Console.WriteLine("***********************************************");

                Console.Write("Выберите пункт меню: ");
                ConsoleKeyInfo userInputSymbol;

                do
                {
                    userInputSymbol = Console.ReadKey(true);
                }
                while (userInputSymbol.Key < ConsoleKey.D0 || userInputSymbol.Key > ConsoleKey.D6);

                numberMenuElement = Convert.ToInt32(userInputSymbol.KeyChar.ToString());

                Console.Clear();

                switch (numberMenuElement)
                {
                case 1:
                    PrintMenuSettings();
                    break;

                case 2:
                    PrintMenuWordBanList();
                    break;

                case 3:
                    PrintMenuProgramBanList();
                    break;

                case 4:
                    RunProgram();
                    break;

                case 5:
                    PrintMenuStatistic();
                    break;
                }
            }
        }

        public void PrintMenuSettings()
        {

        }

        public void PrintMenuWordBanList()
        {

        }

        public void PrintMenuProgramBanList()
        {

        }

        public void RunProgram()
        {

        }

        public void PrintMenuStatistic()
        {

        }
    }
}