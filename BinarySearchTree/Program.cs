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
    
}

