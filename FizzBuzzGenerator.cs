using Generator;

namespace Generater;

public static class RepositoryGenerator
{
    public static string Value => Comperator.Get();

    /// <summary>
    /// Loads two numbers from database and compares them.
    /// </summary>
    /// <param name="id">UserId as utf-32 character string. (Emojies are supported too 😍)</param>
    /// <returns></returns>
    public static string Save(int id)
    {
        var comperator = new Comperator(id);

        if (id % 3 == 0 && id % 5 == 0)
        {
            return $"{comperator.GetComperator()}{Value}";
        }
        else if (id % 3 == 0)
        {
            return comperator.GetComperator();
        }
        else if (id % 5 == 0)
        {
            return Comperator.Get();
        }
        else
        {
            return id.ToString();
        }
    }
}
