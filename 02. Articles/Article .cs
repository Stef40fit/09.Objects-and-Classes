
    class Article
{
    //автоматични пропъртита
   public string Title { get; set; }
   public string Content { get; set; }
   public string Author { get; set; }
   
    //конструктор създаване на обект статия от класа
    public Article (string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    //действия методи
    public void Edit(string newContent)
    {
        Content = newContent;
    }
    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }
    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

