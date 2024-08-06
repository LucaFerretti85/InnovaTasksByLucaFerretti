using InnovaTasksByLucaFerretti.Core.Interfaces;
using InnovaTasksByLucaFerretti.Data.Repos;
using static InnovaTasksByLucaFerretti.Core.Models.Models;

namespace InnovaTasksByLucaFerretti.Services
{
    public class ProdottiService : IProdottiService
    {
        private readonly ProdottiRepository _repository;

        public ProdottiService()
        {
            _repository = new ProdottiRepository();
        }

        public void CreateProdotto(Prodotti prodotto)
        {
            _repository.CreateProdotto(prodotto);
        }

        public Prodotti? ReadProdotto(int id)
        {
            return _repository.ReadProdotto(id);
        }

        public List<Prodotti> ReadAllProdotti()
        {
            return _repository.ReadAllProdotti();
        }

        public void UpdateProdotto(Prodotti prodotto)
        {
            _repository.UpdateProdotto(prodotto);
        }

        public void DeleteProdotto(int id)
        {
            _repository.DeleteProdotto(id);
        }
    }

    public class BudgetService : IBudgetService
    {
        private readonly SalesRepository _repository;
        private const decimal Budget = 50000m;

        public BudgetService()
        {
            _repository = new SalesRepository();
        }

        public decimal CalcolaResiduoBudget(DateTime startDate, DateTime endDate)
        {
            var totalSales = _repository.GetTotalSales(startDate, endDate);
            return Budget - totalSales;
        }
    }

    public class ClientiService : IClientiService
    {
        private readonly ClientiRepository _repository;

        public ClientiService()
        {
            _repository = new ClientiRepository();
        }

        public List<Clienti> FiltraClienti(string? regione, string? citta)
        {
            return _repository.FiltraClienti(regione, citta);
        }

        public List<string?> GetRegioni()
        {
            return _repository.GetRegioni();
        }

        public List<string?> GetCitta()
        {
            return _repository.GetCitta();
        }
    }
}
