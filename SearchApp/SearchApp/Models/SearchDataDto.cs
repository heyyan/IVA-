namespace SearchApp.Models
{
    public class SearchDataDto
    {
        public string SearchText { get; set; }

        public int CurrentPage { get; set; }

        public int PageCount { get; set; }

        public int LeftMostPage { get; set; }

        public int PageRange { get; set; }

        public string Paging { get; set; } = "0";

        public int PageSize { get; set; } = 10;

        public Root Root { get; set; } = new Root();
    }
}
