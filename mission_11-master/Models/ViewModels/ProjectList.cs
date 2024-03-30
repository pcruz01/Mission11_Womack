﻿namespace Amazon.Models.ViewModels
{
    public class ProjectList
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

    }
}
