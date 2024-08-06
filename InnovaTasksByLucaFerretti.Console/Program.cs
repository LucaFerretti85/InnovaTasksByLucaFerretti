// See https://aka.ms/new-console-template for more information
using InnovaTasksByLucaFerretti.Core.Interfaces;
using InnovaTasksByLucaFerretti.Data;
using InnovaTasksByLucaFerretti.Services;
using Microsoft.Extensions.DependencyInjection;
using static InnovaTasksByLucaFerretti.Core.Models.Models;

var serviceProvider = new ServiceCollection()
                .AddDbContext<DataContext>()
                .AddSingleton<IProdottiService, ProdottiService>()
                .AddSingleton<IBudgetService, BudgetService>()
                .AddSingleton<IClientiService, ClientiService>()
                .BuildServiceProvider();

var prodottiService = serviceProvider.GetService<IProdottiService>();
var budgetService = serviceProvider.GetService<IBudgetService>();
var clientiService = serviceProvider.GetService<IClientiService>();

// Esempio CRUD Prodotti
/*prodottiService?.CreateProdotto(new Prodotti { Nome = "Prodotto 3", Descrizione = "Descrizione 3", Prezzo = 300 });
var prodotto = prodottiService?.ReadProdotto(1);
Console.WriteLine($"Prodotto letto: {prodotto?.Nome}");
prodottiService?.UpdateProdotto(1, "Prodotto Aggiornato");
prodottiService?.DeleteProdotto(2);*/

// Esempio Residuo Budget
var residuoBudget = budgetService?.CalcolaResiduoBudget(DateTime.Now.AddYears(-2), DateTime.Now);
Console.WriteLine($"Residuo Budget: {residuoBudget}");

// Esempio Filtri Clienti
var clientiFiltrati = clientiService?.FiltraClienti("LOMBARDIA", "Milano");
if (clientiFiltrati != null)
{
    foreach (var cliente in clientiFiltrati)
    {
        Console.WriteLine($"Cliente: {cliente.RagioneSociale}, Mail: {cliente.Mail}");
    }
}
