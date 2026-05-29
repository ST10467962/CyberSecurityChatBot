using System;
using System.Collections.Generic;

namespace CyberSecurityChatBot
{
    public static class ResponseManager
    {
        static Random random = new Random();

        public static Dictionary<string, List<string>> responses =

            new Dictionary<string, List<string>>()

        {

            {

                "password",

                new List<string>()

                {

                    "Use strong passwords with symbols and numbers.",

                    "Avoid using personal information in passwords.",

                    "Enable two-factor authentication."

                }

            },

            {

                "phishing",

                new List<string>()

                {

                    "Do not click suspicious email links.",

                    "Verify sender email addresses carefully.",

                    "Avoid downloading unknown attachments."

                }

            },

            {

                "privacy",

                new List<string>()

                {

                    "Review your privacy settings regularly.",

                    "Avoid sharing personal information online.",

                    "Use secure websites with HTTPS."

                }

            }

        };

        public static string GetRandomResponse(string keyword)

        {

            List<string> selectedResponses = responses[keyword];

            int index = random.Next(selectedResponses.Count);

            return selectedResponses[index];
        }
    }
}
