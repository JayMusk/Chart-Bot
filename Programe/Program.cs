// See https://aka.ms/new-console-template for more information
using System;
using System.Media;
using chartBot;

namespace ChartBot;
public class Programe
{ 
    static void Main(string[] args)
    {
        //Logo object created to display the logo and welcome message
        Logo logo = new Logo();
        logo.Welcome();//calling the welcome method to display the welcome message
        logo.Display();//calling the display method to display the logo
        //player sound object created to play the sound file
        SoundPlayer player = new System.Media.SoundPlayer("C:\\Users\\Student\\source\\repos\\Programe\\Programe\\Resource\\chartbot.wav");
        player.Play();
        Response reply = new Response();
        bool running = true;
        int uInput = 1;
        
        //while loop to keep the application running until the user chooses to exit
        while (running && uInput == 1){
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ResetColor();
            string userInput = Console.ReadLine();
            string botreply = reply.GetResponse(userInput);
            reply.Typing("Bot: " + botreply);
            Console.WriteLine("");
            //try block to handle any exceptions that may occur during the execution of the code
            try
            {
                //changing the text color to gray for the user prompt
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Do you have any qurries? type 1 to continue and 0 to exit.");            
                Console.Write("Option: ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                if (input == 0)
                {
                    reply.Typing("Bot: Stay safe online! Goodbye!!! ");
                    uInput = 0;
                    running = false;
                }
                else
                {
                    uInput = 1;
                    running = true;
                }
            }
            //catch block to handle any exceptions that may occur during the execution of the code
            catch
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                reply.ShowError("Please type 1 to continue or 0 to close the application");
                Console.Write("Option: ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();

                if (input == 0)
                {
                    reply.Typing("Bot: Stay safe online! Goodbye!!! ");
                    uInput = 0;
                    running = false;
                }
                else { 
                    uInput = 1;
                    running = true;
                }
            }          
        }
    }
}  
