using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show(string[] text)
        {
            Draw.Editor("MODO VISUALIZAÇÃO (Pressione ESC para voltar)");
            ReplaceStrongTags(text);
            Draw.Lines("/", "-");
            Console.ReadKey();
            Menu.Show();
        }

        public static void ReplaceStrongTags(string[] text)
        {
          
            Regex strongTagRegex = FormatText.Strong();
            foreach (string line in text){

            string textWithReplacedTags = line;

            MatchCollection strongTagMatches = strongTagRegex.Matches(line);
            foreach (Match match in strongTagMatches)
            {
                textWithReplacedTags = textWithReplacedTags.Replace(match.Value, "|/|");
            }

            string[] words = textWithReplacedTags.Split(" ");
            int matchCount = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals("|/|"))
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(strongTagMatches[matchCount].Value[8..^9] + " ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    matchCount++;
                }
                else
                {
                   
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine("");
            }
        }
    }
}
