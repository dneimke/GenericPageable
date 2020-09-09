using System;
using System.Collections.Generic;

namespace GenericPageable.Models
{
    public class PaginatedList<T> : List<T>, IPageable
    {
        public PaginatedList(List<T> items, int totalRecords, int pageIndex, int pageSize, string orderBy)
        {
            OrderBy = orderBy;
            PageSize = pageSize;
            CurrentPage = pageIndex;
            TotalRecords = totalRecords;
            AddRange(items);
        }

        public int CurrentPage { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set; }
        public string OrderBy { get; set; }
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalRecords, PageSize));
        public bool CanMovePrevious => CurrentPage > 1;
        public bool CanMoveNext => CurrentPage < TotalPages;
        public int PreviousPage => Math.Max(1, CurrentPage - 1);
        public int NextPage => Math.Min(TotalPages, CurrentPage + 1);
    }


    public interface IPageable
    {
        int CurrentPage { get; set; }
        int PageSize { get; set; }
        string OrderBy { get; set; }
        int TotalPages { get; }
        bool CanMovePrevious { get; }
        bool CanMoveNext { get; }
        int PreviousPage { get; }
        int NextPage { get; }
    }
}
