using BLL.Interfaces;
using UI.Infrastructure;
using UI.Interfaces;

namespace UI.Commands
{
    public class DeleteContentCommand : ICommand
    {
        private readonly IContentService _service;
        public string Name => "Delete Content Item";

        public DeleteContentCommand(IContentService service) => _service = service;

        public void Execute()
        {
            var items = _service.GetAll().ToList();
            if (!items.Any())
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            Console.WriteLine("\n--- Select item to delete ---");
            for (int i = 0; i < items.Count; i++) Console.WriteLine($"{i + 1}. {items[i].Name}");

            int index = ConsoleHelper.GetValidIndex("Enter number to delete: ", items.Count);

            _service.DeleteContent(items[index].Id);
            Console.WriteLine("Deleted successfully.");
        }
    }
}
