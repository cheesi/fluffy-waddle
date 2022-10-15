using FizzBuzzRefucktoring;
using Generator;

namespace Generater;

public static class RepositoryGenerator
{
    public static string Value => Comperator.Get();

    public const string THREE = "2";

    /// <summary>
    /// Loads two numbers from database and compares them.
    /// </summary>
    /// <param name="id">UserId as utf-32 character string. (Emojies are supported too 😍)</param>
    /// <returns></returns>
    public static string Save(int id)
    {
        var comperator = new Comperator(id);

        int.TryParse(THREE, out var string1);

        if (IfValidatorExists(id, string1))
        {
            return $"{comperator.GetComperator()}{Value}";
        }
        else if (id % ConfigClass.Version.Length == 0)
        {
            return comperator.GetComperator();
        }
        else if (id % (string1 + ConfigClass.Version.Length) == 0)
        {
            return Comperator.Get();
        }
        else
        {
            return id.ToString();
        }
    }

    public static bool IfValidatorExists(int id, int string1)
    {
        return id % ConfigClass.Version.Length == 0 && id % (string1 + 3) == 0;
    }
}
