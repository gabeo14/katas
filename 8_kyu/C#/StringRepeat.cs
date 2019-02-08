namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      var result = s;

      for (var i = 0; i < n - 1; i++)
      {
        result += s;
      }

      return result;
    }
  }
}