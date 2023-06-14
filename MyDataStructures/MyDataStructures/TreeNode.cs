using System;

namespace MyDataStructures
{
    class TreeNode<T> : IComparable
        where T : IComparable
    {
        public T Data { get; private set; }
        public TreeNode<T> Left { get; private set; }
        public TreeNode<T> Right { get; private set; }

        public TreeNode(T data)
        {
            Data = data;
        }

        public TreeNode(T data, TreeNode<T> left, TreeNode<T> right)
            : this(data)
        {
            Left = left;
            Right = right;
        }

        public void Add(T data)
        {
            var node = new TreeNode<T>(data);

            if(node.CompareTo(this) == -1)
            {
                if(Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        public int CompareTo(object obj)
        {
            if(obj is TreeNode<T> node)
            {
                return Data.CompareTo(node.Data);
            }
            else
            {
                throw new Exception("Types are different");
            }
        }
    }
}
