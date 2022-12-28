using System;
using System.Collections.Generic;
using System.Linq;
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

        public Node(string i,  Node l, Node r)
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
            while((currentNode != null) && (currentNode.info) < 0)
                currentNode = currentNode.leftchild;
            else
                currentNode = currentNode.rightchild;
        }
    }
    
}

