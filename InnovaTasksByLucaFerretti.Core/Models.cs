namespace InnovaTasksByLucaFerretti.Core.Models
{
    public class Models
    {
        public class Clienti
        {
            public int Id { get; set; }
            public string? RagioneSociale { get; set; }
            public string? Mail { get; set; }
            public string? Regione { get; set; }
            public string? Citta { get; set; }
        }

        public class Sales
        {
            public int Id { get; set; }
            public string? Prodotto { get; set; }
            public decimal Prezzo { get; set; }
            public DateTime DataAcquisto { get; set; }
        }

        public class Prodotti
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
            public string? Descrizione { get; set; }
            public decimal Prezzo { get; set; }
        }
    }
}
