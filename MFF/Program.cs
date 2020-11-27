using System;
using System.IO;


namespace MFF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //bool isRunning      = true;


            Console.Clear();
            Console.WriteLine("=================== MFF ===================");


            //This will try to run the arguments trough the handler
            try
            {
                InputHandler(args);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Arguments was not defined....");
            }

            

        }

        static void InputHandler(string[] _args)
        {
            string exportPath   = "./Exports";
            string inportPath   = "";
            string name         = "map";

            //This will loop through the entire array of inputs, and depending on the flag, will assign the new path to the variable
            for (int i = 0; i < _args.Length; i++)
            {
                switch (_args[i])
                {
                    case "-i":
                        inportPath = _args[i+1];    
                        break;
                    case "-e":
                        exportPath = _args[i+1];
                        break;
                    case "-n":
                        name = _args[i+1];
                        break;
                    default:
                        break;
                }
            }
        
            Make(inportPath, exportPath, name);
        }

        static void Make(string _file, string _path, string _name)
        {
            Console.WriteLine(
                "File:  " + _file + 
                "\nPath: " + _path +
                "\nName: " + _name
            );

            //Read the contents of the txt file
            byte[] file = System.IO.File.ReadAllBytes(_file);




            //This will write the file :)
            File.WriteAllBytes(_path + "/" + _name + ".mff", file);
        }
    }
}
