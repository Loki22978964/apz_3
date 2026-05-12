using BLL.Interfaces;
using UI.Interfaces;

namespace UI.Commands
{
    public class DisplayAllCommand : ICommand
    {
        private readonly IContentService _service;
        public string Name => "Show All Content";

        public DisplayAllCommand(IContentService service)
        {
            _service = service;
        }

        public void Execute()
        {
            var items = _service.GetAll();
        if (!items.Any()) { Console.WriteLine("Empty."); return; }
            foreach (var item in items) Console.WriteLine($"- {item.Name}");
        }
    }
}
