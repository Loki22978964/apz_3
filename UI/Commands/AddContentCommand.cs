using BLL.DTOs;
using BLL.Interfaces;
using UI.Infrastructure;
using UI.Interfaces;

namespace UI.Commands
{
    public class AddContentCommand : ICommand
    {
        private readonly IContentService _service;
        public string Name => "Add New Content Item";

        public AddContentCommand(IContentService service) => _service = service;

        public void Execute()
        {
            var types = _service.GetContentTypes().ToList();
            var storages = _service.GetStorageLocations().ToList();

            if (!types.Any() || !storages.Any())
            {
                Console.WriteLine("Error: Create a Type and Storage first!");
                return;
            }

            Console.WriteLine("\n--- Available Types ---");
            for (int i = 0; i < types.Count; i++) Console.WriteLine($"{i + 1}. {types[i].Name}");
            int typeIdx = ConsoleHelper.GetValidIndex("Select type number: ", types.Count);

            Console.WriteLine("\n--- Available Storages ---");
            for (int i = 0; i < storages.Count; i++) Console.WriteLine($"{i + 1}. {storages[i].Name}");
            int storageIdx = ConsoleHelper.GetValidIndex("Select storage number: ", storages.Count);

            string title = ConsoleHelper.GetRequiredString("Enter Title: ");
            string desc = ConsoleHelper.GetRequiredString("Enter Description: ");

            var dto = new ContentDTO
            {
                Id = Guid.NewGuid(),
                Name = title,
                Description = desc,
                ContentTypeId = types[typeIdx].Id,
                StorageLocationId = storages[storageIdx].Id
            };

            _service.AddContent(dto);
            Console.WriteLine("Successfully added!");
        }
    }
}
