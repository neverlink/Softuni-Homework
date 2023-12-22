using System;

namespace P_02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            var article = new Article(tokens[0].Trim(), tokens[1].Trim(), tokens[2].Trim());

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] myArgs = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                string command = myArgs[0];

                if (command == "Rename")
                {
                    article.Rename(myArgs[1].Trim());
                }
                else if (command == "Edit")
                {
                    article.Edit(myArgs[1].Trim());
                }
                else
                {
                    article.ChangeAuthor(myArgs[1].Trim());
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
