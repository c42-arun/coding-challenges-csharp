using System;
using System.Collections.Generic;
using System.IO;

namespace InterviewCake.hashing_and_hashtables
{
    public class DuplicateFilesRecursive
    {
        Dictionary<long, FileInfo> _foundSizes = new Dictionary<long, FileInfo>();

        public DuplicateFilesRecursive(string rootDir)
        {
            PrintFiles(new DirectoryInfo(rootDir));
        }

        private void PrintFiles(DirectoryInfo directoryInfo)
        {
            foreach(FileInfo fileInfo in directoryInfo.GetFiles())
            {
                System.Console.WriteLine(fileInfo.Name);
            }

            foreach(DirectoryInfo d in directoryInfo.GetDirectories())
            {
                PrintFiles(d);
            }
        }
    }
}
