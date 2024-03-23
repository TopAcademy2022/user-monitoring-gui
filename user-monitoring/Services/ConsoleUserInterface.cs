using user_monitoring.Services.Interfaces;

namespace user_monitoring.Services
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
            const int NUMBER_EXIT_SUBMENU_ELEMENT = 4;
            int numberSubMenuElement = 0;

            while (numberSubMenuElement != NUMBER_EXIT_SUBMENU_ELEMENT)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("***********************************************");
                Console.WriteLine("\t====== Редактирование списка запрещенных программ ======\n");
                Console.WriteLine("1. Добавить программу в список");
                Console.WriteLine("2. Удалить программу из списка");
                Console.WriteLine("3. Показать список запрещенных программ");
                Console.WriteLine("4. Вернуться в предыдущее меню\n");
                Console.WriteLine("***********************************************");

                Console.Write("Выберите пункт подменю: ");
                ConsoleKeyInfo userInputSymbol;

                do
                {
                    userInputSymbol = Console.ReadKey(true);
                }
                while (userInputSymbol.Key < ConsoleKey.D0 || userInputSymbol.Key > ConsoleKey.D4);

                numberSubMenuElement = Convert.ToInt32(userInputSymbol.KeyChar.ToString());

                Console.Clear();

                switch (numberSubMenuElement)
                {
                    case 1:
                        AddProgramToBanList();
                        break;

                    case 2:
                        RemoveProgramFromBanList();
                        break;

                    case 3:
                        ShowBanList();
                        break;
                        
                }
            }
        }

        private void AddProgramToBanList()
        {
            Console.WriteLine("Введите название программы для добавления в список:");
            string programName = Console.ReadLine();
            // Реализация добавления программы в список запрещенных
            Console.WriteLine($"Программа '{programName}' успешно добавлена в список запрещенных.");
        }

        private void RemoveProgramFromBanList()
        {
            Console.WriteLine("Введите название программы для удаления из списка:");
            string programName = Console.ReadLine();
            // Реализация удаления программы из списка запрещенных
            Console.WriteLine($"Программа '{programName}' успешно удалена из списка запрещенных.");
        }

        private void ShowBanList()
        {
            // Реализация вывода списка запрещенных программ
            Console.WriteLine("Список запрещенных программ:");
            // Ваш код здесь
        }

        public void RunProgram()
        {

        }

        public void PrintMenuStatistic()
        {

        }
    }
}