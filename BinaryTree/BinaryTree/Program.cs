using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree tree = new BSTree(new List<int> { 0, 1, 2, 3, 4, 9, 8, 7, 6, 5 });
            Console.Write("Enter a command: [I]nsert, [D]elete, [S]earch, [F]ind minimum");
            string input = Console.ReadLine();
            if (input=="I")
            {
                Console.Write("What number do you want to insert: ");
                int _input= Int32.Parse(Console.ReadLine());
                tree.insert(_input);
            }
            else if (input=="D")
            {
                Console.Write("What number do you want to delete: ");
                int _input = Int32.Parse(Console.ReadLine());
                tree.delete(_input);
            }
            else if (input=="S")
            {
                Console.Write("What number do you want to delete: ");
                int _input = Console.Read();
                Console.Write(tree.Search(_input));
            }
            else
            {
                Console.Write(tree.FindMinimum());
            }
        }
    }
}
