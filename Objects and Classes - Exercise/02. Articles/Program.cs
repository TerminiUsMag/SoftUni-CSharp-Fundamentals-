using System;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            string result = $"{this.Title} - {this.Content}: {this.Author}";
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(command[0], command[1], command[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}
