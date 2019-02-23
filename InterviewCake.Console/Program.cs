using System;
using InterviewCake.binary_trees;
using InterviewCake.binary_trees.traversal_algorithms.depth_first_using_recursion;
using InterviewCake.hashing_and_hashtables;
using InterviewCake.sorting_searching_logs.binary_search_algorithm;

namespace InterviewCake
{
    class Program
    {
        static void Main(string[] args)
        {
            //DuplicateFilesTest();
            //BinarySearchTest();

            BinaryTreeTraverse();

            Console.ReadLine();
        }

        static void DuplicateFilesTest()
        {
            //var cut = new DuplicateFilesRecursive(@"C:\Temp\TennisMatch\New folder");
            var cut = new DuplicateFilesIterative(@"C:\Temp\");
        }

        static void BinarySearchTest()
        {
            int[] sortedArray = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(BinarySearch.Exists(5, sortedArray));
        }

        static void BinaryTreeTraverse()
        {
            var rootNode = BuildTree();

            Console.WriteLine("\nPre Order:");
            PreOrderTraversal.ProcessNode(rootNode);

            Console.WriteLine("\nIn Order:");
            InOrderTraversal.ProcessNode(rootNode);

            Console.WriteLine("\nPost Order:");
            PostOrderTraversal.ProcessNode(rootNode);
        }

        private static BinaryTreeNode BuildTree()
        {
            // level 0
            var zero = new BinaryTreeNode(0);

            // level 1
            var one = zero.InsertLeft(1);
            var two = zero.InsertRight(2);

            // level 2
            var four = one.InsertLeft(4);
            var five = one.InsertRight(5);

            // level 3
            var nine = four.InsertLeft(9);
            var six = four.InsertRight(6);

            var seven = five.InsertLeft(7);
            var eight = five.InsertRight(8);

            return zero;            
        }
    }
}
