
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

class Book
{
    public string Titel;
    public string Author;
    public string ISNB;
    public bool Available;

    public Book(string titel, string author, string iSNB)
    {
        Titel = titel;
        Author = author;
        ISNB = iSNB;
        Available = true;
    }
}

class Liberary
{

    List<Book> liberary = new List<Book>();

    public void AddBook(Book book)
    {
        liberary.Add(book);
    }

    public void ShowTheLiberary()
    {
        Console.WriteLine();
        for (int i = 0; i < liberary.Count; i++)
        {

            Console.WriteLine($"{i + 1} -- {liberary[i].Titel} by {liberary[i].Author} Avalibal to Borrow {liberary[i].Available}\n");

        }



    }
    public void BorrowBook(string titel)
    {
        bool flag = false;
        for (int i = 0; i < liberary.Count; i++)
        {
            if (liberary[i].Titel.ToLower().Contains(titel.ToLower())
                || liberary[i].Author.ToLower().Contains(titel.ToLower()))
            {
                liberary[i].Available = false;

                Console.WriteLine($"You borrowed a book  : {liberary[i].Titel}  To the author {liberary[i].Author} With an identification number {liberary[i].ISNB}\n");
                flag = true;
                break;
            }

        }

        if (!flag)
        {
            Console.WriteLine($"This Book ==> {titel} is Not Found in Liberary\n");
        }

    }

    public void ReturnBook(string titel)
    {
        bool flag = false;

        for (int i = 0; i < liberary.Count; i++)
        {
            if (liberary[i].Titel.ToLower().Contains(titel.ToLower()) || liberary[i].Author.ToLower().Contains(titel.ToLower()))
            {
                if (!liberary[i].Available)
                {
                    liberary[i].Available = true;

                    Console.WriteLine($"\nhas been returned  : {liberary[i].Titel}  To the author {liberary[i].Author}  on {DateTime.UtcNow}\n");
                    flag = true;
                    break;
                }



            }

        }

        if (!flag)
        {
            Console.WriteLine($"\nThis book is Not borrowed ===> {titel}\n");
        }

    }


}

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Liberary liberary = new Liberary();

            liberary.AddBook(new("1984", "George Orwell", "1111"));
            liberary.AddBook(new("To Kill a Mockingbird", "Harper Lee", "1112"));
            liberary.AddBook(new("The Great Gatsby", "Scott Fitzgerald", "1113"));
            liberary.AddBook(new("Moby-Dick", "Herman Melville", "1114"));
            liberary.AddBook(new("Jane Eyre", "Charlotte Brontë", "1115"));
            liberary.AddBook(new("Wuthering Heights", "Emily Brontë", "1116"));
            liberary.AddBook(new("Cheese", "Spencer Johnson", "1117"));
            liberary.AddBook(new("Think Big", "David Schwartz", "1118"));
            liberary.AddBook(new("Rich Dad", "Robert Kiyosaki", "1119"));
            liberary.AddBook(new("Badass", "Jen Sincero", "1120"));
            liberary.AddBook(new("Subtle Art", "Mark Manson", "1121"));
            //liberary.AddBook(new("كتاب حياتي ياعين", "للفنان حسن الاسمر", "1122"));


            liberary.ShowTheLiberary(); // =====>  ممكن نستخدم الفانكشن ده لعرض جميع الكتب


            liberary.BorrowBook("badass"); // ==>      وممكن نستخدم ده لو عايزين نبحث او نستعير كتاب فا هتبقي إتاحه الكتاب فولس




            liberary.ReturnBook("badass"); // ==>    ممكن نستخدم ده لو هنرجع كتاب استعرناه وتبقي إتاحه الكتاب ترو



            // liberary.ReturnBook("rich"); // ==> لو بنرجع كتاب مش مستعار هيقول انه مش في القايمة المستعارة


            // liberary.BorrowBook("Herry poter"); // =====> كذلك لو بنستعير كتاب مش موجود هيقول انه مش موجود


            //  liberary.ShowTheLiberary();     // =====>  ممكن نستخدم ده عشان نشوف الكتب المستعارة و الكتب المتاحه

            Console.ReadLine();










            Console.WriteLine();

        }
    }
}
