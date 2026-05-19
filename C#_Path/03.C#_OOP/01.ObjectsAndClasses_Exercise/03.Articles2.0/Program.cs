class Program
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
    }

    static void Main()
    {
        List<Article> articles = new List<Article>();
        int articleCount = int.Parse(Console.ReadLine());

        for (var i = 0; i < articleCount; i++)
        {
            string[] args = Console.ReadLine().Split(", ");
            string title = args[0];
            string content = args[1];
            string author = args[2];

            articles.Add(new Article(title, content, author));
        }

        foreach (var article in articles)
        {
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}