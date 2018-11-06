using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int value { get; set; }
        public Node leftChild { get; set; }
        public Node rightChild { get; set; }
        public Node(int _value )
        {
            value = _value;
        }
    }
}
