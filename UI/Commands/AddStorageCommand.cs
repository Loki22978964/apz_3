using BLL.DTOs;
using BLL.Interfaces;
using UI.Interfaces;

namespace UI.Commands
{
    public class AddStorageCommand : ICommand
    {
        private readonly IContentService _service;
        public string Name => "Add New Storage Location";

        public AddStorageCommand(IContentService service) => _service = service;

        public void Execute()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter URL: ");
            string url = Console.ReadLine() ?? "";

            _service.AddStorageLocation(new StorageDTO { Id = Guid.NewGuid(), Name = name, Url = url });
        Console.WriteLine("Storage added.");
        }
    }
}
