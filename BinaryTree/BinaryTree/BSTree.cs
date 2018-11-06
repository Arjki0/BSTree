using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BSTree
    {
        private Node _root;
        public void insert(int currentValue)
        {
            Node currentNode = _root;
            if (currentValue > currentNode.value)
            {
                if (currentNode.leftChild != null)
                {
                    currentNode = currentNode.leftChild;
                }
                else
                {
                    currentNode.leftChild.value = currentValue;
                }

            }
            else if (currentValue < currentNode.value)
            {
                if (currentNode.rightChild != null)
                {
                    currentNode = currentNode.rightChild;
                }
                else
                {
                    currentNode.rightChild.value = currentValue;
                }

            }
            else
            {
                Console.Write("Sorry I dont do duplicates");
            }
        }
        public void delete(int targetValue)
        {
            Node targetNode = Search(targetValue);
            Node currentNode = _root;
            Node parent = null;
            int currentValue = _root.value;
            bool direction = false;
            while (true)
            {
                if (currentNode.leftChild.value == targetNode.value)
                {
                    parent = currentNode;
                    direction = false;
                    break;
                }
                else if (currentNode.rightChild.value == targetNode.value)
                {
                    parent = currentNode;
                    direction = true;
                    return;
                }
                else if (currentNode.value < currentNode.leftChild.value)
                {
                    currentNode = currentNode.leftChild;
                }
                else
                {
                    currentNode = currentNode.rightChild;
                }
                
            }
            if(targetNode.leftChild==null&targetNode.rightChild==null)
            {
                if (direction)
                {
                    parent.rightChild = null;
                }
                else
                {
                    parent.leftChild = null;
                }

            }
            else if (targetNode.leftChild == null ^ targetNode.rightChild == null)
            {
                if (direction)
                {
                    if (targetNode.leftChild == null)
                    {
                        parent.rightChild = targetNode.rightChild;
                    }
                    else
                    {
                        parent.rightChild = targetNode.leftChild;
                    }
                }
                else
                {
                    if (targetNode.leftChild == null)
                    {
                        parent.rightChild = targetNode.rightChild;
                    }
                    else
                    {
                        parent.rightChild = targetNode.leftChild;
                    }
                }
            }
                //chyby mazani pro 2 childy
        }
        public Node Search(int value)
        {
            Node currentNode = _root;
            while (true)
            {
                if (currentNode.value==value)
                {
                    return (currentNode);
                }
                else if (currentNode.value < currentNode.leftChild.value)
                {
                    currentNode = currentNode.leftChild;
                }
                else
                {
                    currentNode = currentNode.rightChild;
                }
            }
        }
         public int FindMinimum()
        {
            Node currentNode = _root;
            while (true)
            {
                if (currentNode.leftChild == null & currentNode.rightChild == null)
                {
                    return (currentNode.value);
                }
                else if (currentNode.value < currentNode.leftChild.value) 
                {
                    currentNode = currentNode.leftChild;
                }
                else if (currentNode.value > currentNode.rightChild.value)
                {
                    currentNode = currentNode.rightChild;
                }
                else
                {
                    Console.Write("Error");
                }
            }
        }
        public BSTree(List<int> _list)
        {
            _root.value = _list[0];
            for (int i = 1; _list.Count<1; i++)
            {
                int currentValue = _list[i];
                Node currentNode = _root;
                while (true)
                {
                    if (currentValue > currentNode.value)
                    {
                        if (currentNode.leftChild != null)
                        {
                            currentNode = currentNode.leftChild;
                        }
                        else
                        {
                            currentNode.leftChild.value = currentValue;
                            break;
                        }
                    
                    }
                    else if (currentValue < currentNode.value)
                    {
                        if (currentNode.rightChild != null)
                        {
                            currentNode = currentNode.rightChild;
                        }
                        else
                        {
                            currentNode.rightChild.value = currentValue;
                            break;
                        }

                    }
                    else
                    {
                        Console.Write("Sorry I dont do duplicates");
                        break;
                    }
                }   
            }
        }
    }
}
