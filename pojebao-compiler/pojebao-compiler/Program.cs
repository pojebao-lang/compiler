using System;
using System.IO;

namespace pojebao_compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.Write("Error: No file provided!");
                Environment.Exit(1);
            }
            if (!args[0].EndsWith(".pjb"))
            {
                Console.Write("Error: The file does not have the .pjb extenstion!");
                Environment.Exit(1);
            }
            
            string code = File.ReadAllText(args[0]);
            Array kod = code.Split("\n");
            foreach (string line in kod)
            {
                if (1 == 2)
                {
                    // command code
                }
                else
                {
                    Console.Write("TypeError: " + line + " not recognized!");
                }
            }

        
        }
    }
}
