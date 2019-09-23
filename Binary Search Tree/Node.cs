using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node
    {
        //FIELDS************************************************************************
       
        /// <summary>
        /// Current data this node is holding
        /// </summary>
        private int var;


        private Node lesserChild = null;
        private Node greaterChild = null;
       


        //CONSTRUTOR********************************************************************

        public Node(int var)
        {
            this.var = var;
        }

        //METHODS***********************************************************************

        /// <summary>
        /// Will either fill or send a variable to either the lesser or greater child nodes
        /// </summary>
        /// <param name="newVar"></param>
        public void InsertNode(int newVar)
        {

            if (newVar < var)//if insertedNode is less then the current variable...
            {

                if (lesserChild == null)//and lesserChild is empty...
                {
                    lesserChild = new Node(newVar);//create new node at lesser child position with newVariable...
                    return;
                }
                else
                {
                    lesserChild.InsertNode(newVar);//and if there is something in lesserchild, send this data to the lesser child
                    return;
                }

            }
            else if (newVar > var)//same thing here but with greater child
            {
                if (greaterChild == null)
                {
                    greaterChild = new Node(newVar);
                    return;
                }
                else
                {
                    greaterChild.InsertNode(newVar);
                    return;
                }

            }
            else
            {
                throw new Exception("This tree only accepts unique values");
            }


        }

        /// <summary>
        /// Will find and remove the found code from the tree
        /// </summary>
        /// <param name="expectedVar">< /param>
        public void RemoveNode(int expectedVar)
        {
            if (var == expectedVar)
            {
                if (lesserChild == null)
                {
                    if (greaterChild == null)
                    {
                        
                    }
                }
            }

            }


        /// <summary>
        /// Will Look through BST till variable is found if it is
        /// </summary>
        /// <param name="expectedVar"></param>
        /// <returns></returns>
        public bool SearchBST(int expectedVar)
        {

            if (var == expectedVar)//Checks if the variable has been found
            {
                Console.WriteLine();
                Console.Write(var);//debug
                Console.Write("  The Variable has been found!");
                return true;
            }

            if (expectedVar < var)//will send the search further through the tree, unless there is nothing there in which case it will return false
            {
                Console.WriteLine(var);//debug

                if (lesserChild != null)
                {
                    return lesserChild.SearchBST(expectedVar);
                }
                else
                {
                    return false;
                }
            }
            else if (expectedVar > var)
            {
                Console.WriteLine(var);//debug

                if (greaterChild != null)
                {
                    return greaterChild.SearchBST(expectedVar);
                }
                else
                {
                    return false;
                }

            }
                
            Console.WriteLine(expectedVar + " was not found.");
            return false;
        }


        /// <summary>
        ///Will Return true if the expectedVariable is in this node
        /// </summary>
        /// <param name="expectedVar"></param>
        /// <returns></returns>
        public bool CheckVar(int expectedVar)
        {
            if (var == expectedVar)
            {
                return true;
            }


            return false;
        }



    }
}
