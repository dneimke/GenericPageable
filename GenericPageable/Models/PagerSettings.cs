namespace GenericPageable.Models
{
    public class PagerSettings
    {
        public int Page { get; set; } = 1;

        public int PageSize = 10;
        public int Skip => (Page - 1) * PageSize;

        public string OrderBy { get; set; } = "";
    }
}
