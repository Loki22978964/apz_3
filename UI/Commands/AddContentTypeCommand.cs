using BLL.DTOs;
using BLL.Interfaces;
using UI.Interfaces;
using UI.Infrastructure; 
using DAL.Entities.Enum; 

namespace UI.Commands
{
    public class AddContentTypeCommand : ICommand
    {
        private readonly IContentService _service;
        public string Name => "Add New Content Type";

        public AddContentTypeCommand(IContentService service) => _service = service;

        public void Execute()
        {
            string typeName = ConsoleHelper.GetRequiredString("Enter Type Name (e.g., Movie, Book): ");

            var formats = Enum.GetValues(typeof(DataFormat)).Cast<DataFormat>().ToList();

            Console.WriteLine("\n--- Available Formats ---");
            for (int i = 0; i < formats.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {formats[i]}");
            }

            int formatIdx = ConsoleHelper.GetValidIndex("Select format number: ", formats.Count);
            DataFormat selectedFormat = formats[formatIdx]; 

            _service.AddContentType(new ContentTypeDTO
            {
                Id = Guid.NewGuid(),
                Name = typeName,
                Format = selectedFormat.ToString() 
            });

            Console.WriteLine($"Type '{typeName}' with format '{selectedFormat}' added successfully!");
        }
    }
}