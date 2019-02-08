using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.hashing_and_hashtables
{
    public class DuplicateFilesIterative
    {
        public DuplicateFilesIterative(string rootDir)
        {
            PrintFiles(new DirectoryInfo(rootDir));
        }

        private void PrintFiles(DirectoryInfo startingDirInfo)
        {
            Stack<FileSystemInfo> stack = new Stack<FileSystemInfo>();
            stack.Push(startingDirInfo);

            while (stack.Count > 0)
            {
                var currentInfo = stack.Pop(); // could be a directory or a file

                var currentDirInfo = currentInfo as DirectoryInfo;

                // if its a directory
                if (currentDirInfo != null) 
                {
                    // push all its contents into the stack for processing 
                    foreach (var info in currentDirInfo.GetFileSystemInfos())
                    {
                        stack.Push(info);
                    }
                }

                // if its a file
                var currentFileInfo = currentInfo as FileInfo;

                if (currentFileInfo != null)
                {
                    Console.WriteLine($"{currentFileInfo.Name}");
                }
            }
        }
    }
}
