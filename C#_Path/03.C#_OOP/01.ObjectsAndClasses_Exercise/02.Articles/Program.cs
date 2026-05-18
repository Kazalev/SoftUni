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
        string[] input = Console.ReadLine().Split(", ");
        int n = int.Parse(Console.ReadLine());

        string title = input[0];
        string content = input[1];
        string author = input[2];

        Article article = new Article(title, content, author);

        for (var i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split(": ");
            switch (args[0])
            {
                case "Edit":
                    article.Edit(args[1]);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(args[1]);
                    break;
                case "Rename":
                    article.Rename(args[1]);
                    break;
            }
        }

        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
    }
}