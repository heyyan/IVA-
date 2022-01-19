using SearchApp.Models;

namespace SearchApp.Services
{
    public interface IVideoSearch
    {
        Task<SearchResults> Search(string text);
    }
}
