using System;
using System.IO;

namespace pojebao_compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args[0].EndsWith(".pjb"))
            {
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
                        Console.Write("Error: Command " + line + " not recognized!");
                    }
                }
            } else
            {
                Console.Write("Error: The file does not have the .pjb extension");
            }
        
        }
    }
}
