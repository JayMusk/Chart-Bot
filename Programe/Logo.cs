namespace chartBot
{
    class Logo
    {
        //constructor to initialize the Logo class
        public Logo() { }
        //logo to be displayed when the application starts
        public void Display()
        {Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("   _____      _____    ____________  ___\r\n" +
                              "  /     \\    /  _  \\  /   _____/|  |/ __|\r\n" +
                              " /  \\ /  \\  /  /_\\  \\ \\_____  \\ |   _/  \r\n" +
                              "/    Y    \\/    |    \\/        \\|    \\\r\n\\" +
                              "____|__  /\\____|__  /_______  /|____ \\ \r\n" +
                              "        \\/         \\/        \\/      \\/");
            Console.ResetColor();
        }
        //welcome message to be displayed when the application starts
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=========================================================");
            Console.ResetColor();
            Console.WriteLine("Welcome to the Cyber Security Awareness Bot ");
            Console.WriteLine("Developed by: Mask");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=========================================================");
            Console.ResetColor();
        }   
    }
}
