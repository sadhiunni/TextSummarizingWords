using System;
using System.Collections.Generic;
using System.Text;

namespace TextSummarizingWords
{
        public class CallingSummary
        {
            public static string WritingSummary(string Text, int maxLength)
            {
                int totalCharacter = 0;
                List<string> summary = new List<string>();
                if (Text.Length < maxLength)
                {
                    Console.WriteLine(Text);
                }
                else
                {
                    var words = Text.Split(" ");
                    foreach (var word in words)
                    {
                        totalCharacter += word.Length;
                        if (totalCharacter >= maxLength)
                            break;
                        summary.Add(word);
                    }

                    string summarSentance = string.Join(" ", summary);
                    Console.WriteLine(summarSentance + "...");
                }
                return string.Join(" ", summary);
            }
        }
}
