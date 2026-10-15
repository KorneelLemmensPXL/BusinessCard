namespace BusinessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string ascii = """
     _  __                          _   _                                             
    | |/ /                         | | | |                                            
    | ' / ___  _ __ _ __   ___  ___| | | |     ___ _ __ ___  _ __ ___   ___ _ __  ___ 
    |  < / _ \| '__| '_ \ / _ \/ _ \ | | |    / _ \ '_ ` _ \| '_ ` _ \ / _ \ '_ \/ __|
    | . \ (_) | |  | | | |  __/  __/ | | |___|  __/ | | | | | | | | | |  __/ | | \__ \
    |_|\_\___/|_|  |_| |_|\___|\___|_| |______\___|_| |_| |_|_| |_| |_|\___|_| |_|___/

                                                                                      

    """;
            Console.WriteLine(ascii);
            Console.ResetColor();
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine("| Opleiding    Graduaat Programmeren |");
            Console.WriteLine("| Klasgroep:   1Pro e                |");
            Console.WriteLine("| Leukste vak: Werkplekleren         |");
            Console.WriteLine("+------------------------------------+");

            
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write ("Groetjes van je linkse buur        ");
            Console.ResetColor();
            Console.WriteLine(" |");
            Console.WriteLine("+------------------------------------+");
            
        }
    }
}
