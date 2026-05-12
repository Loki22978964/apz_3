using BLL.Interfaces;
using BLL.Strategies;
using UI.Interfaces;

namespace UI.Commands
{
    public class SearchCommand : ICommand
    {
        private readonly IContentService _service;
        public string Name => "Search Content";

        public SearchCommand(IContentService service) => _service = service;

        public void Execute()
        {
            Console.Write("Query: ");
            string q = Console.ReadLine() ?? "";
            
            var results = _service.Search(q, new FullSearchStrategy());
        foreach (var r in results) Console.WriteLine($"> {r.Name}");
        }
    }
}
