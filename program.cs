using System;
using System.IO;

class DotnetProgram
{
    static void PlayMadlibs(string textFile)
    {
        Random random = new Random();
        if (File.Exists(textFile) && File.ReadAllText(textFile) != null)
        {
            string[] madlibs =  File.ReadAllLines(textFile); 
            string madlib = madlibs[random.Next(0, madlibs.Length)];
            
            string[] myMadlib = madlib.Split(' ');
            for(int madlibArray = 0; madlibArray < myMadlib.Length; madlibArray++)
            {
                switch(myMadlib[madlibArray])
                {
                    case "{verb}": Console.Write("Give me a verb: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    case "{verb,ing}": Console.Write("Give me a verb with -ing: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    case "{verb,ed}": Console.Write("Give me a verb with -ed: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    case "{noun}": Console.Write("Give me a noun: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    case "{pluralnoun}": Console.Write("Give me a plural noun: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    case "{propernoun}": Console.Write("Give me a proper noun: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    case "{abjective}": Console.Write("Give me an abjective: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    case "{adverb}": Console.Write("Give me an adverb: "); myMadlib[madlibArray] = Console.ReadLine(); break;
                    default: break;
                }
            }
            Console.Write("\n");
            foreach(string line in myMadlib){Console.Write(line.ToString() + " ");}
        }
        else{Console.WriteLine("ERROR: The file doesn't exist.");}
    }

    private static void Main(string[] args)
    {
        Console.Title = "Let's play madlibs!";

        while(true)
        {
            PlayMadlibs("madlibs.txt");

            Console.ReadKey(true);
            Console.Clear();
        }
    }
}