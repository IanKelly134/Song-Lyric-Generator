using System;
using System.Text;

namespace LyricsAndProseGenerator;

public class LyricGenerator
{
    public static string GenerateRandomLyrics(int linesToGenerate, string path, string endsWith = null)
    {
        const Int32 BufferSize = 128;
        using (var fileStream = File.OpenRead(path))
        {
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                List<string> lines = new List<string>();
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        if (!string.IsNullOrWhiteSpace(endsWith))
                        {
                            if (line.ToLower().EndsWith(endsWith.ToLower()))
                                lines.Add(line);
                        }
                        else
                        {
                            lines.Add(line);
                        }
                          
                    }
                }

                Random rnd = new Random();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" ");
                sb.AppendLine("--------------------------------------------------------------");

                for (int i = 0; i < linesToGenerate; i++)
                {
                    int indx = rnd.Next(0, lines.Count - 1);
                    string val = lines[indx];
                    sb.AppendLine(val);
                }

                sb.AppendLine("--------------------------------------------------------------");
                sb.AppendLine(" ");
                return sb.ToString();
            }
        }
    }
}
