// See https://aka.ms/new-console-template for more information
using Classes;

var account = new BankAccount("Constantin", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

// Doc : https://learn.microsoft.com/fr-fr/dotnet/csharp/fundamentals/tutorials/classes#create-your-application