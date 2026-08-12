using System;

namespace ChartBot 
{
    class Response
    {
        public string input;
        public Response(string text) {
            input = text;
            Console.WriteLine("Bot: Hello ");
        }
        public ~Response{
            Console.WriteLine("Exiting Application")
        }
        public void GetResponse(string input)
        {
                input = input.ToLower();

            if (input.Contains("hello") || input.Contains("hi"))
            {
                Console.WriteLine("Hello! Welcome to the Cyber Security Awareness Bot.");
            }

            else if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm doing well. How can I help you?");
            }

            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords and never share them.");
            }

            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Be careful of fake emails and suspicious links.");
            }

            else
            {
                void GetResponse(string input)
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                }
            }
        }
    }
}