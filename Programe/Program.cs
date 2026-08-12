// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Media;
using chartBot;

namespace ChartBot;
public class Programe
{
    static void Main(string[] args)
    {
        String userInput1 = ;
        string userInput = Console.ReadLine();
        Logo logo = new Logo();
        logo.Display();
        SoundPlayer player = new System.Media.SoundPlayer("C:\\Users\\Student\\source\\repos\\Programe\\Programe\\Resource\\chartbot.wav");
        player.PlaySync();
        player.Play();
        Response reply = new Response(userInput);
        bool running = true;
        while (running){
            reply.GetResponse();
            Console.WriteLine("Do you have any queries? ");
            string input = Console.ReadLine();
            if (input.Contains("Y") running = false;
            else { running  = true; }
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 