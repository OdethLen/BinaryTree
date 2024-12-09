using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTree
    {
       

        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public string GetTreeStructure()
        {
            if (root == null)
            {
                return "El árbol está vacío.";
            }

            string rootStr = $"Raíz: {root.Data}";
            string leftStr = (root.Left != null) ? $"Subárbol izquierdo: {GetSubtree(root.Left)}" : "Subárbol izquierdo: Vacío";
            string rightStr = (root.Right != null) ? $"Subárbol derecho: {GetSubtree(root.Right)}" : "Subárbol derecho: Vacío";

            return $"{rootStr}\n{leftStr}\n{rightStr}";
        }

        private string GetSubtree(Node node)
        {
            if (node == null)
                return "Vacío";

            // Recorremos en InOrder para mostrar todos los nodos del subárbol
            List<int> result = new List<int>();
            InOrderRec(node, result);
            return string.Join(", ", result);
        }

        // Insertar un nuevo nodo en el árbol binario
        public void Insert(int data)
        {
            root = InsertRec(root, data);
        }

        // Recursivo para insertar un nuevo nodo
        private Node InsertRec(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);

            return root;
        }

        // Eliminar un nodo del árbol binario
        public void Delete(int data)
        {
            root = DeleteRec(root, data);
        }

        private Node DeleteRec(Node root, int data)
        {
            if (root == null)
                return root;

            if (data < root.Data)
                root.Left = DeleteRec(root.Left, data);
            else if (data > root.Data)
                root.Right = DeleteRec(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = MinValue(root.Right);
                root.Right = DeleteRec(root.Right, root.Data);
            }

            return root;
        }

        private int MinValue(Node root)
        {
            int minValue = root.Data;
            while (root.Left != null)
            {
                minValue = root.Left.Data;
                root = root.Left;
            }
            return minValue;
        }

        // Recorrido Inorder (izquierda, raíz, derecha)
        public List<int> InOrder()
        {
            List<int> result = new List<int>();
            InOrderRec(root, result);
            return result;
        }

        private void InOrderRec(Node root, List<int> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);
                result.Add(root.Data);
                InOrderRec(root.Right, result);
            }
        }

        // Recorrido Preorder (raíz, izquierda, derecha)
        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrderRec(root, result);
            return result;
        }

        private void PreOrderRec(Node root, List<int> result)
        {
            if (root != null)
            {
                result.Add(root.Data);
                PreOrderRec(root.Left, result);
                PreOrderRec(root.Right, result);
            }
        }

        // Recorrido Postorder (izquierda, derecha, raíz)
        public List<int> PostOrder()
        {
            List<int> result = new List<int>();
            PostOrderRec(root, result);
            return result;
        }

        private void PostOrderRec(Node root, List<int> result)
        {
            if (root != null)
            {
                PostOrderRec(root.Left, result);
                PostOrderRec(root.Right, result);
                result.Add(root.Data);
            }
        }
    }
}
