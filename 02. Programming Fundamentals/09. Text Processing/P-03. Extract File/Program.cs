using System;

namespace P_03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = Console.ReadLine();
            string fileInfo = inputPath.Substring(inputPath.LastIndexOf('\\') + 1);

            int extensionPos = fileInfo.LastIndexOf('.');

            string fileName = fileInfo.Substring(0, extensionPos);
            string fileExtention = fileInfo.Substring(extensionPos + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtention}");
        }
    }
}
