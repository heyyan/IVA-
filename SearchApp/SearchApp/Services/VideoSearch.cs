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

        public async Task<SearchResults> Search(string text)
        {
            return await _searchClient.GetSearchResults();
        }
    }
}
