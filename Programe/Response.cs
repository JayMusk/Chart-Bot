using System.Threading;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace ChartBot 
{
    class Response
    {
        public string input;
        //constructor to initialize the Response class by print an empty line in yellow color to the console.
        public Response() { 
            Console.WriteLine("");
        }
       
        public void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Typing(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //typing effect
            //foreach loop to iterate through each character in the message string and print it to the console with a delay.
            foreach (char i in message)
            {
                //The program should sleep for 15 milliseconds after each character is printed to the console. This will create a typing effect for the bot's response.
                Console.Write(i);
                Thread.Sleep(15);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("hello"))

                return "Hello! Welcome to the Cyber Security Awareness Bot.";

            else if (input.Contains("how are you"))

                return "I'm doing well. How can I help you?";

            else if (input.Contains("password"))

                return "Password Safety Tip: Use at least 12 characters with uppercase, lowercase, numbers and symbols. Never reuse passwords across sites!";

            else if (input.Contains("phishing"))

                return "Be careful of fake emails and suspicious links.";

            else if (input.Contains("safe browsing"))

                return "Safe Browsing Tip: Always check the URL for HTTPS and be cautious of suspicious websites.";

            //default for unrecognized input.
            else
                return "I didn’t quite understand that. Could you rephrase?";

        }
    }
}
