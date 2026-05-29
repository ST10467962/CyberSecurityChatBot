using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace CyberSecurityChatBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Play voice greeting when the application starts

            PlayVoiceGreeting();

            // Display welcome message

            rtbChat.AppendText(

                "Bot: Welcome to the Cybersecurity Awareness Assistant!\n");

            rtbChat.AppendText(

                "Bot: Ask me about passwords, phishing, privacy\n\n");
        }
        private void PlayVoiceGreeting()

        {

            try

            {

                SoundPlayer player = 

                new SoundPlayer("greeting.wav");

                player.Play();

            }

            catch

            {

                MessageBox.Show(

                    "Voice greeting could not be played.");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Store user input

            string userMessage =

                txtUserInput.Text.ToLower();

            // Prevent empty messages

            if (string.IsNullOrWhiteSpace(userMessage))

            {

                MessageBox.Show(

                    "Please enter a message.");

                return;

            }

            // Display user message

            rtbChat.AppendText(

                "You: " + userMessage + "\n");

            string response = "";

            // -----------------------------

            // SENTIMENT DETECTION

            // -----------------------------

            string sentiment =

                SentimentAnalyzer.DetectSentiment(userMessage);

            if (sentiment == "worried")

            {

                response +=

                    "It is understandable to feel worried. " +

                    "Cyber threats are common, but staying " +

                    "informed can help you stay safe.\n";

            }

            else if (sentiment == "frustrated")

            {

                response +=

                    "Cybersecurity can feel overwhelming " +

                    "sometimes, but learning step by step helps.\n";

            }

            else if (sentiment == "curious")

            {

                response +=

                    "Curiosity is great! Learning about " +

                    "cybersecurity is an important skill.\n";

            }

            // -----------------------------

            // MEMORY FEATURE

            // -----------------------------

            if (userMessage.Contains("i like"))

            {

                string[] words =

                    userMessage.Split(' ');

                MemoryManager.FavoriteTopic =

                    words[words.Length - 1];

                response +=

                    "Great! I'll remember that you are " +

                    "interested in " +

                    MemoryManager.FavoriteTopic + ".\n";

            }

            // -----------------------------

            // FOLLOW-UP CONVERSATION

            // -----------------------------

            if (userMessage.Contains("tell me more") ||

                userMessage.Contains("another tip") ||

                userMessage.Contains("explain more"))

            {

                response +=

                    ConversationManager

                    .ContinueConversation();

            }

            else

            {

                // Search for matching keywords

                foreach (var keyword

                    in ResponseManager.responses.Keys)

                {

                    if (userMessage.Contains(keyword))

                    {

                        // Save current topic

                        ConversationManager.CurrentTopic =

                            keyword;

                        // Get random response

                        response +=

                            ResponseManager

                            .GetRandomResponse(keyword);

                        break;

                    }

                }

            }

            // -----------------------------

            // UNKNOWN INPUT HANDLING

            // -----------------------------

            if (string.IsNullOrEmpty(response))

            {

                response =

                    "I'm not sure I understand. " +

                    "Can you try rephrasing?";

            }

            // -----------------------------

            // MEMORY RECALL

            // -----------------------------

            if (MemoryManager.FavoriteTopic != "")

            {

                response +=

                    "\n\nAs someone interested in " +

                    MemoryManager.FavoriteTopic +

                    ", staying informed about online safety " +

                    "is very important.";

            }

            // Display chatbot response

            rtbChat.AppendText(

                "Bot: " + response + "\n\n");

            // Clear textbox

            txtUserInput.Clear();
        }
    }
}
