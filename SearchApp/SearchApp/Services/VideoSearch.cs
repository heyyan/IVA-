using SearchApp.Client;
using SearchApp.Models;

namespace SearchApp.Services
{
    public class VideoSearch : IVideoSearch
    {
        private readonly ISearchClient _searchClient;

        public VideoSearch(ISearchClient searchClient)
        {
            _searchClient = searchClient ?? throw new ArgumentNullException(nameof(searchClient));
        }

        public async Task<Root> Search(string title, string skip, string take)
        {
            return await _searchClient.GetSearchResults(title, skip, take);
        }


        public async Task<List<AutocompleteTitle>> AutocompleteTitle(string prefix)
        {
            return await _searchClient.AutocompleteTitle(prefix);
        }
    }
}
