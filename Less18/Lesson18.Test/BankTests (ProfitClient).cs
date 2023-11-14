using NUnit.Framework;
using Metods;
namespace Metods.Test;

public class BankTestsThree
{
    [TestCase(10000, 4, 30, "Полученная сумма 28561")]
    [TestCase(10000, 5, 30, "Полученная сумма 37129.3")]
    [TestCase(100000, 2, 15, "Полученная сумма 132250")]
    [TestCase(2000, 3, 10, "Полученная сумма 2662")]
    public void ProfitClient(int clientStartSum, int vkladAge, int vkladProcent, string expected)
    {
        string actual = Bank.ProfitClient(clientStartSum, vkladAge, vkladProcent);

        //Assert.AreEqual(expected, actual);
        Assert.That(actual, Is.EqualTo(expected));
    }
}