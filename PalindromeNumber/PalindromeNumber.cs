namespace PalindromeNumber;
public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        List<char> reverseX = new List<char>();
        string xString = x.ToString();
        for (int i = xString.Length - 1; i >= 0; i--)
        {
            reverseX.Add(xString[i]);
        }
        string xStringReversed = new string(reverseX.ToArray());
        if (xString == xStringReversed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
