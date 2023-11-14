using NUnit.Framework;
using Metods;
namespace Metods.Test;

public class BankTestsTwo
{
    [TestCase(1000, "Выданные купюры 1000 - 1, Выданные купюры 500 - 0, Выданные купюры 100 - 0")]
    [TestCase(2500, "Выданные купюры 1000 - 2, Выданные купюры 500 - 1, Выданные купюры 100 - 0")]
    [TestCase(2700, "Выданные купюры 1000 - 2, Выданные купюры 500 - 1, Выданные купюры 100 - 2")]
    [TestCase(900, "Выданные купюры 1000 - 0, Выданные купюры 500 - 1, Выданные купюры 100 - 4")]

    public void Bankomat(int cod, string expected)
    {
        string actual = Bank.Bankomat(cod);

        //Assert.AreEqual(expected, actual);
        Assert.That(actual, Is.EqualTo(expected));
    }
}