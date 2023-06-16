// See https://aka.ms/new-console-template for more information

using LyricsAndProseGenerator;


string main = "Enter number of lyric lines to generate - (Enter XX to exit, Enter ENDS_WITH:string_val|# of lines for rhymes) :";
Console.WriteLine(main);
string line;
while ((line = Console.ReadLine()) != "XX")
{
    string result = string.Empty;
    if (line.StartsWith("ENDS_WITH:"))
    {
        string[] vals = line.Split("|");
        if (!Int32.TryParse(vals[1], out Int32 val))
        {
            Console.WriteLine("Invalid Entry...");
            Console.WriteLine(main);
            continue;
        }

        string[] endsWithVals = vals[0].Split(":");
        result = LyricGenerator.GenerateRandomLyrics(Convert.ToInt32(vals[1]), @"C:\Users\IAN_KELLY\OneDrive - S&P Global\Documents\Personal\Personal\Lyrics.txt", endsWithVals[1]);
        Console.WriteLine(result);
        Console.WriteLine(main);
        continue;
    }
    else if (!Int32.TryParse(line, out Int32 val))
    {
        Console.WriteLine("Invalid Entry...");
        Console.WriteLine(main);
        continue;
    }

    result = LyricGenerator.GenerateRandomLyrics(Convert.ToInt32(line), @"C:\Users\IAN_KELLY\OneDrive - S&P Global\Documents\Personal\Personal\Lyrics.txt");
    Console.WriteLine(result);
    Console.WriteLine(main);
}
