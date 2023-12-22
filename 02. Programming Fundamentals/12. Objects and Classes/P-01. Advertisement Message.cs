using System;

namespace P_01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new ReviewGenerator();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(generator.GenerateReview());
            }
        }
    }
    public class ReviewGenerator
    {
        public ReviewGenerator()
        {
            this.Phrases = new string[]
            {
                "Excellent product.",
                "Exceptional product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "I can’t live without this product."
            };

            this.Events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself",
                "I am very satisfied.",
                "I feel great!"
            };

            this.Authors = new string[]
            {
                "Eva",
                "Iva",
                "Diana",
                "Petya",
                "Elena",
                "Katya",
                "Annie",
                "Stella"
            };

            this.Cities = new string[]
            {
                "Ruse",
                "Sofia",
                "Varna",
                "Burgas",
                "Plovdiv"
            };
        }

        public string[] Phrases { get; set; }

        public string[] Events { get; set; }

        public string[] Authors { get; set; }

        public string[] Cities { get; set; }

        public string GenerateReview()
        {
            Random rnd = new Random();
            int phraseIndex = rnd.Next(0, Phrases.Length);
            int eventIndex = rnd.Next(0, Events.Length);
            int authorIndex = rnd.Next(0, Authors.Length);
            int cityIndex = rnd.Next(0, Cities.Length);
            return $"{this.Phrases[phraseIndex]} {this.Events[eventIndex]} {this.Authors[authorIndex]} - {this.Cities[cityIndex]}.";
        }
    }
}
