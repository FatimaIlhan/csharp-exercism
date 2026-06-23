using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder  sb = new StringBuilder();
        bool capitalizeNext = false;
      foreach (char c in identifier)
  {
    // Task 1
    if (c == ' ')
    {
        sb.Append('_');
        continue;
    }
    // Task 2
    if (char.IsControl(c))
    {
        sb.Append("CTRL");
        continue;
    }
    // Task 3
    if (c == '-')
    {
        capitalizeNext = true;
        continue;
    }

    // Task 5
    if (c >= 'α' && c <= 'ω')
    {
        continue;
    }

    // Task 4
    if (!char.IsLetter(c))
    {
        continue;
    }

    if (capitalizeNext)
    {
        sb.Append(char.ToUpper(c));
        capitalizeNext = false;
    }
    else
    {
        sb.Append(c);
    
}
        }
        return sb.ToString();
    }
}