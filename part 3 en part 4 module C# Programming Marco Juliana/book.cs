using System;

class Book
{
    public string Title { get; set; }
    public int NumPages { get; set; }
    public int PubYear { get; set; }

    public Book(string title, int numPages, int pubYear)
    {
        Title = title;
        NumPages = numPages;
        PubYear = pubYear;
    }
}
