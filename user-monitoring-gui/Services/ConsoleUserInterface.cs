using user_monitoring_gui.Models;
using user_monitoring_gui.Services.Interfaces;

namespace user_monitoring.Services
{
    public class ConsoleUserInterface : IUserInterface
    {
        private Setting _setting;

        public ConsoleUserInterface(Setting setting)
        {
            this._setting = setting;
        }

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
            int numberMenuElement = 0;
            const uint NUMBER_EXIT_MENU_ELEMENT = 5;
            ConsoleKeyInfo userInputSymbol;
            while (numberMenuElement != NUMBER_EXIT_MENU_ELEMENT)
            {
                Console.Clear();
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                const char SYMBOL_СHECMARK = '\u2705';
                const char SYMBOL_СROSS = '\u274E';
                char OnСonditions;
                Console.WriteLine("\t\t\tНастройки:\n");

                Console.Write("1. Считывать нажатия клавиш. ");
                OnСonditions = (this._setting.ReadKeyboardInput == true) ? SYMBOL_СHECMARK : SYMBOL_СROSS;
                Console.WriteLine(OnСonditions);

                Console.Write("2. Считывать список запущенных приложений. ");
                OnСonditions = (this._setting.ReadRunPrograms == true) ? SYMBOL_СHECMARK : SYMBOL_СROSS;
                Console.WriteLine(OnСonditions);

                Console.Write("3. Анализ запрещённых слов. ");
                OnСonditions = (this._setting.AnalysisProhibitedWords == true) ? SYMBOL_СHECMARK : SYMBOL_СROSS;
                Console.WriteLine(OnСonditions);

                Console.Write("4. Анализ запрещённых программ. ");
                OnСonditions = (this._setting.AnalysisProhibitedPrograms == true) ? SYMBOL_СHECMARK : SYMBOL_СROSS;
                Console.WriteLine(OnСonditions);
                Console.WriteLine("5.Назад. ");

                do
                {
                    userInputSymbol = Console.ReadKey(true);
                }
                while (userInputSymbol.Key < ConsoleKey.D0 || userInputSymbol.Key > ConsoleKey.D5);

                numberMenuElement = Convert.ToInt32(userInputSymbol.KeyChar.ToString());

                switch (numberMenuElement)
                {
                    case 1:
                        this._setting.ReadKeyboardInput ^= true;
                        break;
                    case 2:
                        this._setting.ReadRunPrograms ^= true;
                        break;
                    case 3:
                        this._setting.AnalysisProhibitedWords ^= true;
                        break;
                    case 4:
                        this._setting.AnalysisProhibitedPrograms ^= true;
                        break;
                }

            }
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