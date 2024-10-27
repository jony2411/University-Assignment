 using System;
public class Library
{
    string Book;
    string Title;
    string AuthorName;
    long ISBN;
    double Price;
    public Library()//default class
    {
     Book = "Unknown" ;
     Title = "Unknown" ;
     AuthorName = "Unknown" ;
     ISBN = 0 ;
     Price = 0.0 ;
    }
    public Library(string title)
    {
        Title = title;
    }
    public Library(string title,string authorName)
    {
        Title = title;
        AuthorName = authorName;
    }
    public Library(string title,string authorName,long isbn)
    {
        Title = title;
        AuthorName = authorName;
        ISBN = isbn;
    }
    public Library(string book,string title,string authorName,long isbn,double price)
    {
        Book = book;
        Title = title;
        AuthorName = authorName;
        ISBN = isbn;
        Price = price;    
    }
    public void printInfo()
    {
        Console.WriteLine("Book: "+Book);
        Console.WriteLine("Title: "+Title);
        Console.WriteLine("Author Name: "+AuthorName);
        Console.WriteLine("ISBN Number: "+ISBN);
        Console.WriteLine("Price: "+Price);
    }
    
    static void Main()
    {
        Library b1 = new Library("The Hacker Playbook","Practical Guide To Penetration Testing","Peter Kim",1494932636,2499);
        b1.printInfo();
    }
    
}
