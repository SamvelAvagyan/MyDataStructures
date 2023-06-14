using System;
using System.Collections.Generic;

namespace MyDataStructures
{
    class BinarySearchTree<T>
        where T : IComparable
    {
        public TreeNode<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            if(Root == null)
            {
                Root = new TreeNode<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public List<T> Preorder()
        {
            if(Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }

        private List<T> Preorder(TreeNode<T> node)
        {
            List<T> list = new List<T>();

            if(node != null)
            {
                list.Add(node.Data);

                if(node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if(node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }

            return list;
        }

        public List<T> Postorder()
        {
            if(Root == null)
            {
                return new List<T>();
            }

            return Postorder(Root);
        }

        private List<T> Postorder(TreeNode<T> node)
        {
            List<T> list = new List<T>();

            if(node != null)
            {
                if(node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }

                list.Add(node.Data);
            }

            return list;
        }

        public List<T> Inorder()
        {
            if(Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        private List<T> Inorder(TreeNode<T> node)
        {
            List<T> list = new List<T>();

            if(node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node.Data);

                if(node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }

            return list;
        }
    }
}
