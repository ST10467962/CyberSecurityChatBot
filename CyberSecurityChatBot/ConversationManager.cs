using System;


namespace CyberSecurityChatBot
{
    public static class ConversationManager
    {
        public static string CurrentTopic = "";

        public static string ContinueConversation()

        {

            if (CurrentTopic == "password")

            {

                return "Another password tip: never reuse passwords.";

            }

            if (CurrentTopic == "phishing")

            {

                return "Phishing scams often create panic or urgency.";

            }

            if (CurrentTopic == "privacy")

            {

                return "Privacy tip: review app permissions carefully.";

            }

            return "Please specify which topic you want more information about.";
        }
    }
}
