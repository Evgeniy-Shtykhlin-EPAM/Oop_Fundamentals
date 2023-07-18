namespace Oop_Fundamentals.Entities
{
    [Serializable]
    public abstract class Card
    {
        public string DocumentNumber { get; set; }
        public string Tittle { get; set; }
        public TypeOfCard TypeOfCard { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
