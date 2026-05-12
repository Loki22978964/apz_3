using BLL.DTOs;
using BLL.Interfaces;
using BLL.Strategies;
using DAL.Entities.Enum;
using UI.Commands;
using UI.Interfaces;

namespace UI
{
    public class MainMenu
    {
        private readonly Dictionary<string, ICommand> _commands;

        public MainMenu(BLL.Interfaces.IContentService service)
        {
            _commands = new Dictionary<string, ICommand>
            {
                { "1", new DisplayAllCommand(service) },
                { "2", new SearchCommand(service) },
                { "3", new AddContentCommand(service) },
                { "4", new DeleteContentCommand(service) },
                { "5", new AddContentTypeCommand(service) },
                { "6", new AddStorageCommand(service) }
            };
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                foreach (var cmd in _commands)
                    Console.WriteLine($"{cmd.Key}. {cmd.Value.Name}");
                Console.WriteLine("0. Exit");

                var choice = Console.ReadLine();
                if (choice == "0") return;

                if (_commands.ContainsKey(choice))
                    _commands[choice].Execute();
                else
                    Console.WriteLine("Invalid option.");
            }
        }
    }
}