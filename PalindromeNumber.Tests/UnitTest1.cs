using PalindromeNumber;

namespace PalindromeNumber.Tests;

[TestClass]
public class UnitTest1
{
    private readonly PalindromeNumber _palindromeNumber;

    public UnitTest1()
    {
        _palindromeNumber = new PalindromeNumber();
    }

    [TestMethod]
    public void TestMethod1()
    {
        bool result = _palindromeNumber.IsPalindrome(121);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod2() 
    {
        bool result = _palindromeNumber.IsPalindrome(-121);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        bool result = _palindromeNumber.IsPalindrome(10);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod4()
    {
        bool result = _palindromeNumber.IsPalindrome(2000002);

        Assert.IsTrue(result);
    }
}