using System;
using System.Collections.Generic;
using System.Linq;

namespace P_03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            int articleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < articleCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                articles.Add(new Article(tokens[0], tokens[1], tokens[2]));
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}