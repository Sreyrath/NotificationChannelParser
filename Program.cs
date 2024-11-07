using System;
using System.Collections.Generic;

namespace NotificationChannelParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set tags
            HashSet<string> validTags = new HashSet<string> { "BE", "FE", "QA", "Urgent" };

            // Get input from user
            Console.WriteLine("Enter a notification title:");
            string title = Console.ReadLine();

            // List to store unique channels
            List<string> channels = new List<string>();

            // Find all tags in the title
            foreach (var part in title.Split('['))
            {
                if (part.Contains("]"))
                {
                    string tag = part.Substring(0, part.IndexOf("]"));
                    if (validTags.Contains(tag) && !channels.Contains(tag))
                    {
                        channels.Add(tag);
                    }
                }
            }

            // Output the channels
            Console.WriteLine("Receive channels: " + string.Join(", ", channels));
        }
    }
}