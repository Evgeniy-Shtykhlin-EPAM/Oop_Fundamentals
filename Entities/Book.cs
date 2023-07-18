using Oop_Fundamentals.Interfaces;

namespace Oop_Fundamentals.Entities
{
    //[Serializable]
    internal class Book: Card, IBook,IAuthor
    {
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public string Authors { get; set; }
    }
}
