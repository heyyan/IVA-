using Newtonsoft.Json;

namespace SearchApp.Models
{
    public class Release
    {
        public DateTime Date { get; set; }
        public string Certification { get; set; }
        public string Country { get; set; }
        public string CountryName { get; set; }
        public string CountryId { get; set; }
        public string Type { get; set; }
    }

    public class Contributor
    {
        public string PersonId { get; set; }
        public string PersonName { get; set; }
        public string Character { get; set; }
        public string Job { get; set; }
    }

    public class AlternateTitle
    {
        public string Title { get; set; }
        public string Country { get; set; }
        public string CountryName { get; set; }
        public string CountryId { get; set; }
    }

    public class Description
    {
        [JsonProperty("Description")]
        public string Desc { get; set; }
        public string Attribution { get; set; }
        public string Language { get; set; }
    }

    public class Company
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string Name { get; set; }
    }

    public class ExternalId
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class ScreenCapture
    {
        public string Height { get; set; }
        public string Width { get; set; }
        public string Aspect { get; set; }
        public string FilePath { get; set; }
    }

    public class TargetCountriesDetail
    {
        public string CountryId { get; set; }
        public string Country { get; set; }
        public string CountryName { get; set; }
    }

    public class Video
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Mature { get; set; }
        public string Duration { get; set; }
        public string Language { get; set; }
        public string LanguageSubtitled { get; set; }
        public string Company { get; set; }
        public bool Clean { get; set; }
        public bool AllowAdvertising { get; set; }
        public bool Certification { get; set; }
        public bool Theatrical { get; set; }
        public bool HomeVideo { get; set; }
        public bool TuneIn { get; set; }
        public string SourceVideoWidth { get; set; }
        public string SourceVideoHeight { get; set; }
        public DateTime Encoded { get; set; }
        public List<ScreenCapture> ScreenCaptures { get; set; }
        public List<string> TargetCountries { get; set; }
        public List<TargetCountriesDetail> TargetCountriesDetail { get; set; }
        public string TargetLanguage { get; set; }
    }

    public class Image
    {
        public string ImageType { get; set; }
        public string Attribution { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Violence { get; set; }
        public string Sexuality { get; set; }
        public string Language { get; set; }
        public List<string> Tags { get; set; }
        public bool Official { get; set; }
        public string FilePath { get; set; }
        public DateTime Modified { get; set; }
    }

    public class Link
    {
        public string Platform { get; set; }
        public string Url { get; set; }
    }

    public class Availability
    {
        public string Provider { get; set; }
        public string OfferType { get; set; }
        public string DeliveryMethod { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public bool PreSale { get; set; }
        public string Quality { get; set; }
        public string Country { get; set; }
        public List<Link> Links { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

    public class ProgramTrend
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
        public List<string> Classifiers { get; set; }
        public DateTime Modified { get; set; }
        public string Rank { get; set; }
        public string ListUrl { get; set; }
        public string TitleUrl { get; set; }
    }

    public class Award
    {
        public string Year { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string CategoryType { get; set; }
        public string ProgramId { get; set; }
        public List<string> PersonIds { get; set; }
        public bool Winner { get; set; }
        public DateTime Modified { get; set; }
    }

    public class Item
    {
        public string ProgramId { get; set; }
        public string Sequence { get; set; }
        public DateTime Modified { get; set; }
    }

    public class Collection
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Types { get; set; }
        public List<string> ParentCollectionIds { get; set; }
        public List<Item> Items { get; set; }
        public List<string> Tags { get; set; }
        public List<string> MicroGenres { get; set; }
        public List<string> Subjects { get; set; }
        public List<string> BasedOns { get; set; }
        public List<string> Characters { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class Summary
    {
        public Video Video { get; set; }
        public Image Image { get; set; }
        public Description Description { get; set; }
        public List<Contributor> Contributors { get; set; }
        public string ContributorCount { get; set; }
        public string AvailabilityCount { get; set; }
        public string ImageCount { get; set; }
        public string VideoCount { get; set; }
        public string ProgramTrendCount { get; set; }
        public string AwardCount { get; set; }
        public string ReleaseCount { get; set; }
        public string TitleCount { get; set; }
        public string ExternalIdCount { get; set; }
        public string TagCount { get; set; }
        public string ThemeCount { get; set; }
    }

    public class Source
    {
        public string Id { get; set; }
        public string ProgramType { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string OriginalTitle { get; set; }
        public DateTime OriginalReleaseDate { get; set; }
        public string Year { get; set; }
        public string ShowId { get; set; }
        public string SeasonId { get; set; }
        public string SeasonNumber { get; set; }
        public string EpisodeNumber { get; set; }
        public string OriginalLanguage { get; set; }
        public string Revenue { get; set; }
        public string Budget { get; set; }
        public string Runtime { get; set; }
        public string OfficialSiteUrl { get; set; }
        public bool Deleted { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string RedirectTo { get; set; }
        public string Idx { get; set; }
        public string OriginatingNetwork { get; set; }
        public List<string> Genres { get; set; }
        public List<Release> Releases { get; set; }
        public List<Contributor> Contributors { get; set; }
        public List<AlternateTitle> AlternateTitles { get; set; }
        public List<Description> Descriptions { get; set; }
        public List<Company> Companies { get; set; }
        public List<string> Tags { get; set; }
        public List<string> Themes { get; set; }
        public List<ExternalId> ExternalIds { get; set; }
        public List<Video> Videos { get; set; }
        public List<Image> Images { get; set; }
        public string VersionId { get; set; }
        public List<Availability> Availabilities { get; set; }
        public List<ProgramTrend> ProgramTrends { get; set; }
        public string VideoCount { get; set; }
        public string ImageCount { get; set; }
        public string IvaRating { get; set; }
        public string IvaRatingSort { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<Award> Awards { get; set; }
        public List<Collection> Collections { get; set; }
        public Summary Summary { get; set; }
    }

    public class Hit
    {
        public string Score { get; set; }
        public Source Source { get; set; }
        public string Id { get; set; }
    }

    public class Root
    {
        public string Took { get; set; }
        public string Total { get; set; }
        public string MaxScore { get; set; }
        public List<Hit> Hits { get; set; }
        public string Message { get; set; }
        public string NextPageToken { get; set; }
    }
}
