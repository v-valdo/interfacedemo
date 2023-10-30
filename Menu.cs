namespace Ling;
public class Menu
{
    public static List<string> Phrases = new();
    public static ILanguage? PickLanguage()
    {
        foreach (var language in Enum.GetValues(typeof(Language)))
        {
            Console.WriteLine($"{(int)language} - {language}");
        }

        if (int.TryParse(Console.ReadLine(), out int c) && c <= 4)
        {
            switch (c)
            {
                case (int)Language.Swedish:
                    return new Swedish();
                case (int)Language.German:
                    return new German();
                case (int)Language.Spanish:
                    return new Spanish();
                case (int)Language.Greek:
                    return new Greek();
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        return null;
    }
    public static void Translator(ILanguage language)
    {
        Console.Clear();
        Phrases.AddRange(new List<string>
        {
            "Greet",
            "Thank",
            "Wish good morning",
            "Wish good evening",
            "Say Good bye",
            "Ask out",
            "Berate"
        });

        int indexer = 1;
        foreach (var phrase in Phrases)
        {
            Console.WriteLine($"{indexer}. {phrase}");
            indexer++;
        }
    }
}