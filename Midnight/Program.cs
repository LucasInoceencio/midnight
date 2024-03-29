﻿using System;

namespace Midnight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Account example
            Console.WriteLine(Account.Access.Writer.HasFlag(Account.Access.Delete)); //Should print: "False"

            // AlertService example
            var alertService = new AlertService(new AlertDAO());
            var result = alertService.RaiseAlert();
            Console.WriteLine(result.GetType()); //Should print: "True" 

            // MergeNames example
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // Should print Ava, Emma, Olivia, Sophia

            // Song example
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");
            first.NextSong = second;
            second.NextSong = first;
            Console.WriteLine(first.IsRepeatingPlaylist());

            // User input example
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue()); // Should printi 10


            // Folders
            string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

            foreach (string name in Folders.FolderNames(xml, 'u'))
                Console.WriteLine(name);

            // Binary Search Tree
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(BinarySearchTree.Contains(n2, 3));

            // Quadratic Equation
            Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
            Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);

            // Bank Account
            var bankAccount = new BankAccount(150);
            bankAccount.Deposit(100);
            bankAccount.Withdraw(50);
            Console.WriteLine($"Balance: {bankAccount.Balance}"); // Should print 50

        }
    }
}
