using System.Data;
using static InnovaTasksByLucaFerretti.Core.Models.Models;

namespace InnovaTasksByLucaFerretti.Core.Interfaces
{
    public interface IProdottiService
    {
        void CreateProdotto(Prodotti prodotto);
        Prodotti? ReadProdotto(int id);
        List<Prodotti> ReadAllProdotti();
        void UpdateProdotto(Prodotti prodotto);
        void DeleteProdotto(int id);
    }

    public interface IBudgetService
    {
        decimal CalcolaResiduoBudget(DateTime startDate, DateTime endDate);
    }

    public interface IClientiService
    {
        List<Clienti> FiltraClienti(string? regione, string? citta);
        List<string?> GetRegioni();
        List<string?> GetCitta();
    }
}
