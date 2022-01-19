using SearchApp.Models;

namespace SearchApp.Services
{
    public interface IVideoSearch
    {
        Task<Root> Search(string title, string skip, string take);
        Task<List<AutocompleteTitle>> AutocompleteTitle(string async);
    }
}
