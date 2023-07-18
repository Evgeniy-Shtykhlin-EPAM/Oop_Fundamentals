using System.Text.Json;
using Oop_Fundamentals.Entities;

namespace Oop_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //patent1
            var patent1 = new Patent{ DocumentNumber = "1", Tittle = "patent1",TypeOfCard = TypeOfCard.Patent, Authors = "Ivanov", DatePublished = DateTime.Today };
            var jsonPatent1 = JsonSerializer.Serialize(patent1);
            var patent1FileName = @"c:\temp\Patent_#{1}.json";
            File.WriteAllText(patent1FileName, jsonPatent1);

            //patent2
            var patent2 = new Patent { DocumentNumber = "2", Tittle = "patent2", TypeOfCard = TypeOfCard.Patent, Authors = "Pertov", DatePublished = DateTime.Today };
            var jsonPatent2 = JsonSerializer.Serialize(patent2);
            var patent2FileName = @"c:\temp\Patent_#{2}.json";
            File.WriteAllText(patent2FileName, jsonPatent2);

            //book1
            var book1 = new Book
            {
                DocumentNumber = "1",
                Tittle = "Book1",
                TypeOfCard = TypeOfCard.Book,
                Authors = "Izmailov",
                DatePublished = DateTime.Today,
                ISBN = "12345",
                NumberOfPages = 1,
                Publisher = "Publisher1",
            };
            var jsonBook1 = JsonSerializer.Serialize(book1);
            var book1FileName = @"c:\temp\Book_#{1}.json";
            File.WriteAllText(book1FileName, jsonBook1);

            //book2
            var book2 = new Book
            {
                DocumentNumber = "2",
                Tittle = "Book2",
                TypeOfCard = TypeOfCard.Book,
                Authors = "Mann",
                DatePublished = DateTime.Today,
                ISBN = "123456",
                NumberOfPages = 2,
                Publisher = "Publisher2",
            };
            var jsonBook2 = JsonSerializer.Serialize(book2);
            var book2FileName = @"c:\temp\Book_#{2}.json";
            File.WriteAllText(book2FileName, jsonBook2);


            //Localizedbook1
            var localizedBook1 = new LocalizedBook()
            {
                DocumentNumber = "5",
                Tittle = "Localizedbook1",
                TypeOfCard = TypeOfCard.LocalizedBook,
                Authors = "Grizshenko",
                DatePublished = DateTime.Today,
                ISBN = "12345121",
                NumberOfPages = 55,
                Publisher = "Publisher1",
                CountryOfLocalization = "KZ",
                LocalPublisher = "Dostyk"
            };
            var jsonLocalizedBook1 = JsonSerializer.Serialize(localizedBook1);
            var localizedBook1FileName = @"c:\temp\LocalizedBook_#{1}.json";
            File.WriteAllText(localizedBook1FileName, jsonLocalizedBook1);

            //Localizedbook2
            var localizedBook2 = new LocalizedBook()
            {
                DocumentNumber = "6",
                Tittle = "Localizedbook2",
                TypeOfCard = TypeOfCard.LocalizedBook,
                Authors = "Jack London",
                DatePublished = DateTime.Today,
                ISBN = "12343435",
                NumberOfPages = 1,
                Publisher = "Star",
                CountryOfLocalization = "UA",
                LocalPublisher = "UALocalPublisher"
            };
            var jsonLocalizedBook2 = JsonSerializer.Serialize(localizedBook2);
            var localizedBook2FileName = @"c:\temp\LocalizedBook_#{2}.json";
            File.WriteAllText(localizedBook2FileName, jsonLocalizedBook2);

            //serarch by document number
            var fileStorage= new FileStorage();
            var listOfCards = fileStorage.GetCardsByDocumentNumber("1");


            //task2 new entity magazine
            var magazine = new Magazine()
            {
                TypeOfCard = TypeOfCard.Magazine, Tittle = "Magazine1", DatePublished = DateTime.Today,
                Publisher = "magazine publisher", DocumentNumber = "1", ReleaseNumber = "4545"
            };
            var jsonMagazine = JsonSerializer.Serialize(magazine);
            var magazineFileName = @"c:\temp\Magazine_#{1}.json";
            File.WriteAllText(magazineFileName, jsonMagazine);


            var fileStorage2 = new FileStorage();
            listOfCards = fileStorage2.GetCardsByDocumentNumber("1");

        }
    }
}