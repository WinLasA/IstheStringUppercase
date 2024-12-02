namespace IstheStringUppercase;

public class Kata
{
    public static bool IsUpperCase(string text)
    {
        foreach (var c in text)
        {
            if(char.IsUpper(c))
                return true;
        }
        return false;
    }
}
