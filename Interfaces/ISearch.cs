using Oop_Fundamentals.Entities;

namespace Oop_Fundamentals.Interfaces
{
    internal interface ISearch
    {
        public List<Card> GetCardsByDocumentNumber(string documentNumber);
    }
}
