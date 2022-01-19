using Refit;
using SearchApp.Models;

namespace SearchApp.Client
{
    public interface ISearchClient
    {
        [Get("/api/entertainment/Search/?Skip={skip}&Take={take}&Title={title}")]
        Task<Root> GetSearchResults(string title, string skip, string take);

        [Get("/api/Common/GetCommonEnumerators")]
        Task<CommonEnumerators> GetCommonEnumerators();

        [Get("/api/Entertainment/AutocompleteTitle/?Prefix={prefix}")]
        Task<List<AutocompleteTitle>> AutocompleteTitle(string prefix);
    }
}