using Accord.Math.Optimization;
using System;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearch<int> binarySearch = new BinarySearch<int>(56);

            binarySearch.insert(56);
            binarySearch.insert(30);
            binarySearch.insert(22);
            binarySearch.insert(11);
            binarySearch.insert(3);
            binarySearch.insert(16);
            binarySearch.insert(40);
            binarySearch.insert(70);
            binarySearch.insert(60);
            binarySearch.insert(65);
            binarySearch.insert(63);
            binarySearch.insert(67);
            binarySearch.insert(95);
            binarySearch.Display();
            binarySearch.GetSize();
            bool result = binarySearch.IfExist(63, binarySearch);
            Console.WriteLine(result);









        }
    }

    class BinarySearch<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }

        public BinarySearch<T> LeftTree { get; set; }
        public BinarySearch<T> RightTree { get; set; }
        public BinarySearch(T nodedata)
        {
            this.NodeData = nodedata;
            this.RightTree = null;
            this.LeftTree = null;


        }

        int leftcount = 0, rightcount = 0;
        bool result = false;

        public void insert(T item)
        {
            T CurrentNodeValue = this.NodeData;
            if (CurrentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearch<T>(item);
                else
                    this.LeftTree.insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearch<T>(item);
                else
                    this.RightTree.insert(item);
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            { 
            this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            { 
            this.rightcount++;
                this.RightTree.Display();
            }
        
        }
        public void GetSize()
        { 
        Console.WriteLine("Size"+" "+(1+this.leftcount+this.rightcount));
        
        }
        public bool IfExist(T element, BinarySearch<T> node)
        {
            if (node == null)
            { 
                return false;
            
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("found element in BST " + " " + node.NodeData);
                result = true;
            }
            else
            { 
            Console.WriteLine("Current element {0} in BST",node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            { 
            IfExist(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            { 
            IfExist(element, node.RightTree);
            }
            return result;
                
                
        
        }
    }
}
            
            
                
                
                
                
            
            