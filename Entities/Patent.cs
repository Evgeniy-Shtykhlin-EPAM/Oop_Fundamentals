using Oop_Fundamentals.Interfaces;

namespace Oop_Fundamentals.Entities
{
    internal class Patent: Card, IAuthor
    {
        public string Authors { get; set; }
    }
}
