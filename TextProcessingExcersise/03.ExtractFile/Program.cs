///<summary>
///  03.ExtractFile
/// </summary>

using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main()
        {
            string path = Console.ReadLine()!;

            (string fileName, string extension) = GetFileNameFormPath(path);

            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");
        }

        private static (string fileName, string ext) GetFileNameFormPath(string directory)
        {
            string fileNm = directory.Substring(directory.LastIndexOf(@"\") + 1, directory.LastIndexOf('.')  - directory.LastIndexOf(@"\") - 1);
            string extension = directory.Substring(directory.LastIndexOf('.') + 1);

            return (fileNm, extension);
        }
    }
}
