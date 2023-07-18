namespace Oop_Fundamentals.Interfaces
{
    internal interface IBook
    {
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
    }
}
