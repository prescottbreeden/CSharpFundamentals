using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpFundamentals
{
    class BasicFileIO
    {
        /*  
            File FileInfo
            FileInfo provides instance methods
            File provides static methods
            Create()
            Copy()
            Delete()
            Exists()
            GetAttributes()
            Move()
            ReadAllText()

            Directory and DirectoryInfo
            CreateDirectory()
            Delete()
            Exitst()
            GetCurrentDirectory()
            GetFiles()
            Move()
            GetLogicalDrives()

            Path
            GetDirecotryName()
            GetFileName()
            GetExtension()
            GetTempPath()

        */ 
        public static void Run()
        {
            // does more security checks - can be nuisance
            string path = @"c:\temp\myfile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                // do something about it
            }
            string content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...", true);
            fileInfo.Delete();
            if (fileInfo.Exists);
            {
                // do something about it
            }
            fileInfo.OpenRead();
        }

        public static void Demo()
        {
            // directory static methods
            Directory.CreateDirectory(@"c:\delete_me\balls");

            string[] files = Directory.GetFiles(@"c:\Users\andro\source\repos\CSharpFundamentals", "*.sln*", SearchOption.AllDirectories);
            foreach (string file in files)
                Console.WriteLine(file);

            string[] directories = Directory.GetDirectories(@"C:\Users\andro\source\repos\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (string dir in directories)
                Console.WriteLine(dir);

            Directory.Exists("...");

            // directory instance methods
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
