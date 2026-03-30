using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eDairy.FunctionalClasses
{
    public class eDairyScapegoat
    {
        private class Node
        {
            public Records Data;
            public Node Left;
            public Node Right;
            public int Size;

            public Node(Records data)
            {
                Data = data;
                Size = 1;
            }
        }

        private static Node root;
        private readonly double alpha = 0.7;

        private int Compare(Records a, Records b)
        {
            return string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase);
        }

        // ===== ВСТАВКА =====
        public void Insert(Records record)
        {
            root = Insert(root, record);
        }

        private Node Insert(Node node, Records record)
        {
            if (node == null)
                return new Node(record);

            if (Compare(record, node.Data) < 0)
                node.Left = Insert(node.Left, record);
            else
                node.Right = Insert(node.Right, record); // дубликаты уходят вправо

            UpdateSize(node);

            if (!IsBalanced(node))
                node = Rebuild(node);

            return node;
        }

        // ===== ПОИСК ТОЧНОГО NAME =====
        public List<Records> SearchByName(string name)
        {
            var result = new List<Records>();
            SearchByName(root, result, name);
            return result;
        }

        private void SearchByName(Node node, List<Records> list, string name)
        {
            if (node == null) return;

            int cmp = string.Compare(name, node.Data.Name, StringComparison.OrdinalIgnoreCase);

            if (cmp < 0)
            {
                SearchByName(node.Left, list, name);
            }
            else if (cmp > 0)
            {
                SearchByName(node.Right, list, name);
            }
            else
            {
                // нашли совпадение — но могут быть дубликаты справа
                list.Add(node.Data);
                SearchByName(node.Right, list, name);
            }
        }

        // ===== ПОИСК ПО ДАТЕ СОЗДАНИЯ =====
        public List<Records> SearchByCreatedDate(DateTime from, DateTime to)
        {
            var result = new List<Records>();
            SearchByCreatedDate(root, result, from, to);
            return result;
        }

        private void SearchByCreatedDate(Node node, List<Records> list, DateTime from, DateTime to)
        {
            if (node == null) return;

            SearchByCreatedDate(node.Left, list, from, to);

            if (node.Data.CreatedAt >= from && node.Data.CreatedAt <= to)
                list.Add(node.Data);

            SearchByCreatedDate(node.Right, list, from, to);
        }

        // ===== ПОИСК ПО ДАТЕ ИЗМЕНЕНИЯ =====
        public List<Records> SearchByUpdatedDate(DateTime from, DateTime to)
        {
            var result = new List<Records>();
            SearchByUpdatedDate(root, result, from, to);
            return result;
        }

        private void SearchByUpdatedDate(Node node, List<Records> list, DateTime from, DateTime to)
        {
            if (node == null) return;

            SearchByUpdatedDate(node.Left, list, from, to);

            if (node.Data.UpdatedAt >= from && node.Data.UpdatedAt <= to)
                list.Add(node.Data);

            SearchByUpdatedDate(node.Right, list, from, to);
        }

        // ===== БАЛАНС =====
        private bool IsBalanced(Node node)
        {
            return GetSize(node.Left) <= alpha * node.Size &&
                   GetSize(node.Right) <= alpha * node.Size;
        }

        private Node Rebuild(Node node)
        {
            var nodes = new List<Node>();
            Flatten(node, nodes);
            return BuildBalanced(nodes, 0, nodes.Count - 1);
        }

        private void Flatten(Node node, List<Node> list)
        {
            if (node == null) return;

            Flatten(node.Left, list);
            list.Add(node);
            Flatten(node.Right, list);
        }

        private Node BuildBalanced(List<Node> nodes, int start, int end)
        {
            if (start > end) return null;

            int mid = (start + end) / 2;

            var node = nodes[mid];
            node.Left = BuildBalanced(nodes, start, mid - 1);
            node.Right = BuildBalanced(nodes, mid + 1, end);

            UpdateSize(node);
            return node;
        }

        private void UpdateSize(Node node)
        {
            node.Size = 1 + GetSize(node.Left) + GetSize(node.Right);
        }

        private int GetSize(Node node)
        {
            return node?.Size ?? 0;
        }
        /*
        private class Node
        {
            public Records Data;
            public Node Left;
            public Node Right;
            public int Size;

            public Node(Records data)
            {
                Data = data;
                Size = 1;
            }
        }

        private static Node root;
        private readonly double alpha = 0.7;

        // Вставка
        public void Insert(Records record)
        {
            root = Insert(root, record);
        }

        private Node Insert(Node node, Records record)
        {
            if (node == null)
                return new Node(record);

            if (record.Id < node.Data.Id)
                node.Left = Insert(node.Left, record);
            else
                node.Right = Insert(node.Right, record);

            UpdateSize(node);

            if (!IsBalanced(node))
                node = Rebuild(node);

            return node;
        }

        // Поиск по названию
        public List<Records> SearchByName(string name)
        {
            var result = new List<Records>();
            Traverse(root, result, name);
            return result;
        }

        private void Traverse(Node node, List<Records> list, string name)
        {
            if (node == null) return;

            Traverse(node.Left, list, name);

            if (node.Data.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                list.Add(node.Data);

            Traverse(node.Right, list, name);
        }

        // Логика scapegoat
        private bool IsBalanced(Node node)
        {
            return GetSize(node.Left) <= alpha * node.Size &&
                   GetSize(node.Right) <= alpha * node.Size;
        }

        private Node Rebuild(Node node)
        {
            var nodes = new List<Node>();
            Flatten(node, nodes);
            return BuildBalanced(nodes, 0, nodes.Count - 1);
        }

        private void Flatten(Node node, List<Node> list)
        {
            if (node == null) return;

            Flatten(node.Left, list);
            list.Add(node);
            Flatten(node.Right, list);
        }

        private Node BuildBalanced(List<Node> nodes, int start, int end)
        {
            if (start > end) return null;

            int mid = (start + end) / 2;

            var node = nodes[mid];
            node.Left = BuildBalanced(nodes, start, mid - 1);
            node.Right = BuildBalanced(nodes, mid + 1, end);

            UpdateSize(node);
            return node;
        }

        private void UpdateSize(Node node)
        {
            node.Size = 1 + GetSize(node.Left) + GetSize(node.Right);
        }

        private int GetSize(Node node)
        {
            return node?.Size ?? 0;
        }
        */
    }
}
