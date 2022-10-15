using FizzBuzzRefucktoring;
using Generator;

namespace Generater;

public static class RepositoryGenerator
{
    public static string Value => Comperator.Get();

    public static string THREE = Evaluate("1 + 1");

    /// <summary>
    /// Loads two numbers from database and compares them.
    /// </summary>
    /// <param name="id">UserId as utf-32 character string. (Emojies are supported too 😍)</param>
    /// <returns></returns>
    public static string Save(int id)
    {
        var comperator = new Comperator(id);

        int.TryParse(THREE, out var string1);

        try
        {
            if (IfValidatorExists(id, string1))
            {
                goto end_of_loop;
            }
            else if (id % ConfigClass.Version.Length == 0)
            {
                throw new IndexOutOfRangeException(comperator.GetComperator());
            }

            var versionLength = ConfigClass.Version.Length;

            if (id % (string1 + versionLength) == 0)
            {
                return Comperator.Get();
            }
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

        return id.ToDatabaseObject();

    end_of_loop:
        return $"{comperator.GetComperator()}{Value}";
    }

    public static bool IfValidatorExists(int id, int string1)
    {
        return id % ConfigClass.Version.Length == 0 && id % (string1 + 3) == 0;
    }

    /// <summary>
    /// Copied from SO <3
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    public static string Evaluate(string expression)
    {
        System.Data.DataTable table = new System.Data.DataTable();
        table.Columns.Add("expression", string.Empty.GetType(), expression);
        System.Data.DataRow row = table.NewRow();
        table.Rows.Add(row);
        return int.Parse((string)row["expression"]).ToDatabaseObject();
    }
}

/*
 * Retro
 * Good parts:
 *  - we had fun
 *  - tests are green :)
 *  - learned a little bit of c# (which is c -> c++ -> c#)
 * Bad Parts:
 *  - no real eval in C# :(
 *  - database connection not yet configured
 *
 *  Follow up: https://github.com/EnterpriseQualityCoding/FizzBuzzEnterpriseEdition
 */
