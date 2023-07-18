using Oop_Fundamentals.Interfaces;

namespace Oop_Fundamentals.Entities
{
    internal class LocalizedBook: Card, IBook, IAuthor, ILocalization
    {
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public DateTime DatePublished { get; set; }
        public string Authors { get; set; }
        public string CountryOfLocalization { get; set; }
        public string LocalPublisher { get; set; }
    }
}
