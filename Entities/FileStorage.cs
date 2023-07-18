using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Caching.Memory;
using Oop_Fundamentals.Interfaces;

namespace Oop_Fundamentals.Entities
{
    internal class FileStorage :ISearch
    {
        private readonly IMemoryCache cache;
        public List<Card> Items { get; set; }= new List<Card>();

        [JsonConstructor]
        public FileStorage()
        {
            var folderForSearch = @"c:\temp\";

            string[] fileEntries = Directory.GetFiles(folderForSearch);

            foreach (var fileName in fileEntries)
            {
                var jsonFromFile = File.ReadAllText(fileName);

                Card deserialized;
                if (fileName.Contains("Book"))
                {
                    deserialized = JsonSerializer.Deserialize<Book>(jsonFromFile);
                }
                else if (fileName.Contains("LocalizedBook"))
                {
                    deserialized = JsonSerializer.Deserialize<LocalizedBook>(jsonFromFile);
                }
                else if (fileName.Contains("Patent"))
                {
                    deserialized = JsonSerializer.Deserialize<Patent>(jsonFromFile);
                }
                else
                {
                    deserialized = JsonSerializer.Deserialize<Magazine>(jsonFromFile);
                }

                Items.Add(deserialized);
            }
        }

        public List<Card> GetCardsByDocumentNumber(string documentNumber)
        {
            return Items.Select(item => item).Where(i => i.DocumentNumber == documentNumber).ToList();
        }
    }
}
