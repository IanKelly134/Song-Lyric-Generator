// See https://aka.ms/new-console-template for more information

using LyricsAndProseGenerator;


string main = "Enter number of lyric lines to generate - Enter XX to exit :";
Console.WriteLine(main);
string line;
while ((line = Console.ReadLine()) != "XX")
{
    if (!Int32.TryParse(line, out Int32 val))
    {
        Console.WriteLine("Invalid Entry...");
        Console.WriteLine(main);
        continue;
    }

    string result = LyricGenerator.GenerateRandomLyrics(Convert.ToInt32(line), @"C:\Users\IAN_KELLY\OneDrive - S&P Global\Documents\Personal\Personal\Lyrics.txt");
    Console.WriteLine(result);
    Console.WriteLine(main);
}