using NUnit.Framework;
using Metods;
namespace Metods.Test;

public class BankTestsOne
{
    [TestCase("Misha", 60, 5, 1000, "Misha - акционные предложения не доступны")]
    [TestCase("Misha", 6, 5, 1000, "Misha - акционные предложения не доступны")]
    [TestCase("Misha", 60, 15, 9000, "Misha - акционные предложения не доступны")]
    [TestCase("Misha", 65, 2, 10000, "Misha - акционные предложения доступны")]
    public void ClientProductBank(string clientName, int clientAge, int colBank, int clientSum, string expected)
    {
        //string clientName = "Вася";
        //int clientAge = 60;
        //int colBank = 5;
        //int clientSum = 100000;
        //string expected = $"{clientName} - акционные предложения не доступны";


        string actual = Bank.ClientProductBank(clientName, clientAge, colBank, clientSum);

        //Assert.AreEqual(expected, actual);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
