using System.Reflection;

namespace BookClassListSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();

            Console.WriteLine("Vad heter boken?");
            string svar1 = Console.ReadLine();
            Console.WriteLine("Hur många sidor innehåller boken?");
            int svar2 = int.Parse(Console.ReadLine());
            Console.WriteLine("När släpptes boken?");
            int svar3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in en ytterliggare en bok");

            Console.WriteLine("Vad heter boken?");
            string svar4 = Console.ReadLine();
            Console.WriteLine("Hur många sidor innehåller boken?");
            int svar5 = int.Parse(Console.ReadLine());
            Console.WriteLine("När släpptes boken?");
            int svar6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in ytterligare en bok");

            Console.WriteLine("Vad heter boken?");
            string svar7 = Console.ReadLine();
            Console.WriteLine("Hur många sidor innehåller boken?");
            int svar8 = int.Parse(Console.ReadLine());
            Console.WriteLine("När släpptes boken?");
            int svar9 = int.Parse(Console.ReadLine());

            books.Add(new Book { Title = svar1, Pages = svar2, Year = svar3 });
            books.Add(new Book { Title = svar4, Pages = svar5, Year = svar6 });
            books.Add(new Book { Title = svar7, Pages = svar8, Year = svar9 });

            books.Sort((b1, b2) => b1.Year.CompareTo(b2.Year));
            books.Reverse();
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
}   }