using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_02.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToFind = Console.ReadLine();
            int bookshelfCapacity = int.Parse(Console.ReadLine());
            int booksChecked = 1;
            while (bookshelfCapacity > 0)
            {
                string currentBook = Console.ReadLine();
                if (currentBook == bookToFind)
                {
                    Console.WriteLine($"You checked {booksChecked - 1} books and found it.");
                    break;
                }
                booksChecked++;
                bookshelfCapacity--;
            }
            if (bookshelfCapacity == 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksChecked - 1} books.");
            }
        }
    }
}
