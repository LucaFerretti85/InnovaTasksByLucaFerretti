using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InnovaTasksByLucaFerretti.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var serviceProvider = new ServiceCollection()
                .AddSingleton<IProdottiService, ProdottiService>()
                .AddSingleton<IBudgetService, BudgetService>()
                .AddSingleton<IClientiService, ClientiService>()
                .BuildServiceProvider();

            var prodottiService = serviceProvider.GetService<IProdottiService>();
            var budgetService = serviceProvider.GetService<IBudgetService>();
            var clientiService = serviceProvider.GetService<IClientiService>();

            // Esempio CRUD Prodotti
            prodottiService.CreateProdotto(new Prodotti { Nome = "Prodotto 3", Descrizione = "Descrizione 3", Prezzo = 300 });
            var prodotto = prodottiService.ReadProdotto(1);
            Console.WriteLine($"Prodotto letto: {prodotto.Nome}");
            prodottiService.UpdateProdotto(1, "Prodotto Aggiornato");
            prodottiService.DeleteProdotto(2);

            // Esempio Residuo Budget
            var residuoBudget = budgetService.CalcolaResiduoBudget(DateTime.Now.AddYears(-2), DateTime.Now);
            Console.WriteLine($"Residuo Budget: {residuoBudget}");

            // Esempio Filtri Clienti
            var clientiFiltrati = clientiService.FiltraClienti("Lombardia", "Milano");
            foreach (var cliente in clientiFiltrati)
            {
                Console.WriteLine($"Cliente: {cliente.RagioneSociale}, Mail: {cliente.Mail}");
            }*/
        }
    }
}
