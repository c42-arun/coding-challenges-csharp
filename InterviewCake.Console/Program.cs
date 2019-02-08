using InterviewCake.hashing_and_hashtables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DuplicateFilesTest();

            System.Console.ReadLine();
        }

        static void DuplicateFilesTest()
        {
            //var cut = new DuplicateFilesRecursive(@"C:\Temp\TennisMatch\New folder");
            var cut = new DuplicateFilesIterative(@"C:\Temp\");
        }
    }
}
