using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BST
    {

        public void TreeRunThrough()
        {


            Node root = new Node(5);

            root.InsertNode(4);
            root.InsertNode(2);
            root.InsertNode(6);
            root.InsertNode(9);
            root.InsertNode(1);
            root.InsertNode(7);

            root.SearchBST(1);

        }

    }
}
