using Ling;

// Interface Demo
// Pick Language - Pick Phrase -> Return translated phrase

Console.WriteLine("Pick a language");

ILanguage? language = Menu.PickLanguage();

if (language != null)
{
    Menu.Translator(language);

    if (int.TryParse(Console.ReadLine(), out int c) && c <= 7 && c >= 1)
    {
        Translate(language, c);
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
else
{
    Console.WriteLine("Invalid language");
}
void Translate(ILanguage language, int pickedPhrase)
{
    string output = String.Empty;
    string? languageName = language.ToString();

    switch (pickedPhrase)
    {
        case 1:
            output = language.Greet();
            break;
        case 2:
            output = language.Thank();
            break;
        case 3:
            output = language.Morning();
            break;
        case 4:
            output = language.Evening();
            break;
        case 5:
            output = language.Bye();
            break;
        case 6:
           output = language.AskOut();
            break;
        case 7:
            output = language.Berate();
            break;
        default:
            Console.WriteLine("Invalid choice");
            return;
    }
    Console.Clear();
    Console.WriteLine($"To {Menu.Phrases[pickedPhrase - 1]}, you say: {output} in {languageName}");
    Console.WriteLine();
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}
