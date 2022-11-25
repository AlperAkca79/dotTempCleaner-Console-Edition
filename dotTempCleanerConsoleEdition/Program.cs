using System;
using System.IO;

namespace dotTempCleanerConsoleEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coded By AlperAkca79

            bool keepUse = true;

            // Actions     
            while (keepUse)
            {
                Console.WriteLine("Type 'w' for About .TempCleanerConsoleEdition");
                Console.WriteLine("Type 'x' for Delete 'Temp' Folder");
                Console.WriteLine("Type 'y' for Delete 'Prefetch' Folder");
                Console.WriteLine("Type 'z' for Delete 'Temp' and 'Prefetch' Folders");

                Console.Write("What do you want to do? (w/x/y/z): ");
                string selectedNumber = Convert.ToString(Console.ReadLine());

                // Action - W
                if (selectedNumber == "w")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------About--------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine(".TempCleanerConsoleEdition Version: 2.0.0");
                    Console.WriteLine(".NET version: 6.0.0");
                    Console.WriteLine("License: MIT License");
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------Links--------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Website: " + "https://alperakca79.github.io/dotTemp-Cleaner-Console-Edition");
                    Console.WriteLine("Source Code: " + "https://github.com/AlperAkca79/dotTemp-Cleaner-Console-Edition");
                    Console.WriteLine("Found Bug? Report Issue on GitHub: " + "https://github.com/AlperAkca79/dotTemp-Cleaner-Console-Edition/issues/new");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Coded By AlperAkca79");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press ENTER for Continue");
                    Console.WriteLine(" ");
                }

                // Action - X
                else if (selectedNumber == "x")
                {
                    var tempPath = new DirectoryInfo(@"C:\Windows\Temp");
                    tempPath.Attributes = tempPath.Attributes & ~FileAttributes.ReadOnly;
                    Console.WriteLine("Deleting temp folder...");
                    tempPath.Delete(true);
                    Console.Write("Selected Folders Cleaned!");
                }

                // Action - Y
                else if (selectedNumber == "y")
                {
                    var prefetchPath = new DirectoryInfo(@"C:\Windows\Prefetch");
                    prefetchPath.Attributes = prefetchPath.Attributes & ~FileAttributes.ReadOnly;
                    Console.WriteLine("Deleting prefetch folder...");
                    prefetchPath.Delete(true);
                    Console.Write("Selected Folders Cleaned!");
                }

                // Action - Z
                else if (selectedNumber == "z")
                {
                    // Temp
                    var tempPath = new DirectoryInfo(@"C:\Windows\Temp");
                    tempPath.Attributes = tempPath.Attributes & ~FileAttributes.ReadOnly;
                    Console.WriteLine("Deleting temp folder...");
                    tempPath.Delete(true);
                    Console.Write("Selected Folders Cleaned!");

                    // Prefetch
                    var prefetchPath = new DirectoryInfo(@"C:\Windows\Prefetch");
                    prefetchPath.Attributes = prefetchPath.Attributes & ~FileAttributes.ReadOnly;
                    Console.WriteLine("Deleting prefetch folder...");
                    prefetchPath.Delete(true);
                    Console.Write("Selected Folders Cleaned!");
                }

                Console.ReadKey();
            }
        }
    }
}