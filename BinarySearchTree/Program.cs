using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        // Constructor for the Node Class

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = r;
            rightchild = l;
        }
    }

    /* A node class consists of three things, the information,
     * refrences to the right child, and refrences to the left child
    internal class Program */

    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; /* Initializing ROOT to null */
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /* This function search the currentNode if the specified Node as well as the current Node of its parents */
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info) < 0)
                currentNode = currentNode.leftchild;
            else
                currentNode = currentNode.rightchild;
        }
    }
    public void insert(string element) //Insert a node in the binary sesarch tree
    {
        Node tmp, parent = null, currentNode = null;
        search(element, ref parent, ref currentNode);
        if (currentNode != null) // check if the node to be inserted already inserted or not
        {
            Console.WriteLine("Duplicate words not allowed");
            return;
        }
        else // if the specified node is not present 
        {
            tmp = new Node(element, null, null); //creates a Node
            if (parent == null) //if the trees is empty
            {
                ROOT = tmp;
            }
            else if (string.Compare(element, parent.info) < 0)
            {
                parent.leftchild = tmp;
            }
            else
            {
                parent.rightchild = tmp;
            }
        }
    }
    public void inorder(Node ptr)
    {
        if (ROOT == null)
        {
            Console.WriteLine("Tree is Empty");
            return;
        }
        if (ptr != null)
        {
            inorder(ptr.leftchild);
            Console.WriteLine(ptr.info + "");
            inorder(ptr.rightchild);
        }
    }

    public void preorder(Node ptr)
    {
        if(ROOT == null)
        {
            Console.WriteLine("Tree is empty");
            return;
        }
        if (ptr != null)
        {
            Console.WriteLine(ptr.info + "");
            preorder(ptr.leftchild);
            postorder(ptr.rightchild);
        }
    }

}

