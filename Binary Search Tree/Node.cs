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

        /// <summary>
        /// Stores node being removed
        /// </summary>
        private Node removedNodeStorage = null;

        /// <summary>
        /// node replacement storage
        /// </summary>
        private Node nodeReplacementStorage = null;

        //PROPETIES*********************************************************************

        /// <summary>
        /// Gets the variable of this node
        /// </summary>
        public int Var
        {
            get
            {
                return var;
            }
        }


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
            removedNodeStorage = SearchForNode(expectedVar);
            
            if (removedNodeStorage == null)//checks if expected var exists in the BST
            {
                Console.WriteLine("This node does not exist");
                return;
            }




        }


        /// <summary>
        /// This method finds and returns the last lesser node connected to the parent, will return null if parents lesser node is empty
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public Node FindNodeToMove(Node parent)
        {
            


            return null;
        }

        

        /// <summary>
        /// Will Look through BST till variable is found if it is
        /// </summary>
        /// <param name="expectedVar"></param>
        /// <returns></returns>
        public bool SearchBST(int expectedVar)
        {
            if (SearchForNode(expectedVar) == null)
            {
                Console.WriteLine("This variable does not exist in the tree.");
                return false;
            }
            else
            {
                Console.WriteLine("This variable exists in the tree!");
                return true;
            }

        }

        /// <summary>
        /// Will Return the node of the inputed variable, expects that the value is in the program and will return null if it is not
        /// </summary>
        /// <param name="expectedVar"></param>
        /// <returns></returns>
        public Node SearchForNode(int targetNode)
        {

            if (targetNode > this.Var) //Determines Direction
            {
                if (greaterChild != null)
                {
                    if (greaterChild.Var == targetNode) //Will Return the child node if its variable matches the target
                    {
                        Console.WriteLine(greaterChild.Var);//debug


                        return greaterChild;
                    }
                    else
                    {
                        Console.WriteLine(greaterChild.Var);//debug


                        return greaterChild.SearchForNode(targetNode); //Will keep running this method till the node is found then will return it
                    }
                }
            }
            else if (targetNode < this.Var) //Repeats with lesser
            {

                if (lesserChild != null)
                {
                    if (lesserChild.Var == targetNode)
                    {
                        Console.WriteLine(lesserChild.Var);//debug


                        return lesserChild;
                    }
                    else
                    {
                        Console.WriteLine(lesserChild.Var);//debug


                        return lesserChild.SearchForNode(targetNode);
                    }
                }
            }
            return null;//If the node is in the tree this should not be reached

        }

        /// <summary>
        /// returns lesser child object
        /// </summary>
        /// <returns></returns>
        public Node getLesserNode()
        {
            return lesserChild;
        }

        /// <summary>
        /// returns lesser child object
        /// </summary>
        /// <returns></returns>
        public Node getGreaterNode()
        {
            return greaterChild;
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
