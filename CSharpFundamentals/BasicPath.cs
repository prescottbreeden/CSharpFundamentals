using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpFundamentals
{
    class BasicPath
    {
        public static void Run()
        {
            string path = @"c:\Users\andro\source\repos\CSharpFundamentals\CSharpFundamentals.sln";

            int dotIndex = path.IndexOf('.');
            string extension = path.Substring(dotIndex);
            Console.WriteLine(extension);

            string ext = Path.GetExtension(path);
            Console.WriteLine("Extension: " + ext);

            string fn = Path.GetFileName(path);
            Console.WriteLine("File Name: " + fn);

            string fn2 = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine("File Name w/o Extension: " + fn2);

            string dn = Path.GetDirectoryName(path);
            Console.WriteLine("Directory Name: " + dn);
        }
        
    }
}
