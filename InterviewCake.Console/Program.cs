using System;
using InterviewCake.binary_trees;
using InterviewCake.binary_trees.traversal_algorithms.depth_first_using_recursion;
using InterviewCake.binary_trees.traversal_algorithms.depth_first_using_stack_iterative;
using InterviewCake.hashing_and_hashtables;
using InterviewCake.sorting_searching_logs.binary_search_algorithm;
using InterviewCake.sorting_searching_logs.merge_sort_algorithm;

namespace InterviewCake
{
    class Program
    {
        static void Main(string[] args)
        {
            //DuplicateFilesTest();
            //BinarySearchTest();

            //BinaryTreeTraverse();
            //MergeSortRecursive();
            MergeSortIterative();

            Console.ReadLine();
        }

        static void MergeSortRecursive()
        {
            int[] items = new []{ 3, 5, 7, 2, 1};

            var sorted = sorting_searching_logs.merge_sort_algorithm.MergeSortRecursive.MergeSort(items);
        }

        static void MergeSortIterative()
        {
            int[] items = new[] { 3, 5, 7, 2, 1};

            var sorted = sorting_searching_logs.merge_sort_algorithm.MergeSortIterative.MergeSort(items);
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

            Console.WriteLine("\nPre Order (Recursive):");
            PreOrderRecursiveTraversal.ProcessNode(rootNode);

            Console.WriteLine("\nPre Order (Iterative):");
            PreOrderStackTraversal.Traverse(rootNode);

            Console.WriteLine("\nIn Order:");
            InOrderRecursiveTraversal.ProcessNode(rootNode);

            Console.WriteLine("\nPost Order:");
            PostOrderRecursiveTraversal.ProcessNode(rootNode);
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
