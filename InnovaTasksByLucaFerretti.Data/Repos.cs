using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using static InnovaTasksByLucaFerretti.Core.Models.Models;

namespace InnovaTasksByLucaFerretti.Data.Repos
{
    public class ProdottiRepository
    {
        public void CreateProdotto(Prodotti prodotto)
        {
            using var db = new DataContext();
            db.Prodotti.Add(prodotto);
            db.SaveChanges();
        }

        public Prodotti? ReadProdotto(int id)
        {
            using var db = new DataContext();
            return db.Prodotti.Find(id);
        }

        public List<Prodotti> ReadAllProdotti()
        {
            using var db = new DataContext();
            return db.Prodotti.ToList();
        }

        public void UpdateProdotto(Prodotti prodotto)
        {
            using var db = new DataContext();
            var prodottoAggiornato = db.Prodotti.Find(prodotto.Id);
            if (prodottoAggiornato != null)
            {
                prodottoAggiornato.Nome = prodotto.Nome;
                prodottoAggiornato.Descrizione = prodotto.Descrizione;
                prodottoAggiornato.Prezzo = prodotto.Prezzo;
                db.SaveChanges();
            }
        }

        public void DeleteProdotto(int id)
        {
            using var db = new DataContext();
            var prodotto = db.Prodotti.Find(id);
            if (prodotto != null)
            {
                db.Prodotti.Remove(prodotto);
                db.SaveChanges();
            }
        }
    }

    public class SalesRepository
    {
        public decimal GetTotalSales(DateTime startDate, DateTime endDate)
        {
            using var db = new DataContext();
            /*return db.Sales
                     .Where(s => s.DataAcquisto >= startDate && s.DataAcquisto <= endDate)
                     .Sum(s => s.Prezzo);*/
            var totalSales = db.Sales.Where(s => s.DataAcquisto >= startDate && s.DataAcquisto <= endDate).ToList();

            return totalSales.Sum(s => s.Prezzo);
        }
    }

    public class ClientiRepository
    {
        public List<Clienti> FiltraClienti(string? regione, string? citta)
        {
            using var db = new DataContext();
            var query = db.Clienti.AsQueryable();

            if (!string.IsNullOrEmpty(regione))
            {
                query = query.Where(c => c.Regione == regione);
            }

            if (!string.IsNullOrEmpty(citta))
            {
                query = query.Where(c => c.Citta == citta);
            }

            return query.ToList();
        }

        public List<string?> GetRegioni()
        {
            using var db = new DataContext();
            return db.Clienti.Where(x => x.Regione != null).Select(x => x.Regione).Distinct().OrderBy(r => r).ToList();
        }
        public List<string?> GetCitta()
        {
            using var db = new DataContext();
            return db.Clienti.Where(x => x.Citta != null).Select(x => x.Citta).Distinct().OrderBy(r => r).ToList();
        }
    }
}
