using System;

namespace CyberSecurityChatBot
{
    public static class SentimentAnalyzer
    {
        public static string DetectSentiment(string message)

        {

            message = message.ToLower();

            if (message.Contains("worried"))

                return "worried";

            if (message.Contains("frustrated"))

                return "frustrated";

            if (message.Contains("curious"))

                return "curious";

            return "neutral";
            if (message.Contains("confused"))
                return "confused";
        }
    }
}
