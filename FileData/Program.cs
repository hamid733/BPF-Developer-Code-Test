using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDetails obj = new FileDetails();
            if (args[0] == "-v" || args[0] == "--v" || args[0] == "/v" || args[0] == "--version")
            {
                System.Console.WriteLine("File version is--" + obj.Version(args[0]));

            }
            else if (args[0] == "-s" || args[0] == "--s" || args[0] == "/s" || args[0] == "--size")

            {
                System.Console.WriteLine("File Size is--" + obj.Size(args[0]));

            }
            else System.Console.WriteLine("Invalid input please check");
            

        }
    }
}
