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
            public Node Left, Right;
            public int Size;

            public Node(Records data)
            {
                Data = data;
                Size = 1;
            }
        }

        private Node root;
        private readonly double alpha = 0.7;
        private int totalNodes = 0;
        private int maxNodes = 0;

        // Сортировка по ID
        private int Compare(Records a, Records b)
        {
            return a.ID.CompareTo(b.ID);
        }
        // Получение следующего Id для новой записи
        public int GetNextId()
        {
            if (root == null) return 1;

            Node current = root;
            while (current.Right != null)
                current = current.Right;

            return current.Data.ID + 1;
        }

        public List<Records> GetAll()
        {
            var list = new List<Records>();
            FillListRecursive(root, list);
            return list;
        }

        private void FillListRecursive(Node node, List<Records> list)
        {
            if (node is null) return;

            // 1. Сначала идем в левое поддерево (там меньшие ID)
            FillListRecursive(node.Left, list);

            // 2. Добавляем текущий узел
            list.Add(node.Data);

            // 3. Затем идем в правое поддерево (там большие ID)
            FillListRecursive(node.Right, list);
        }

        // Вставка
        public void Insert(Records record)
        {
            int depth = InsertAndGetDepth(record);
            if (totalNodes > 0 && depth > Math.Log(totalNodes, 1.0 / alpha))
            {
                RebalanceFromScapegoat(record);
            }
        }

        private int InsertAndGetDepth(Records record)
        {
            Node newNode = new Node(record);
            if (root == null)
            {
                root = newNode;
                totalNodes = 1;
                return 0;
            }

            Node current = root;
            int depth = 0;
            while (true)
            {
                current.Size++;
                depth++;
                int cmp = record.ID.CompareTo(current.Data.ID);
                if (cmp < 0)
                {
                    if (current.Left == null) { current.Left = newNode; break; }
                    current = current.Left;
                }
                else if (cmp > 0)
                {
                    if (current.Right == null) { current.Right = newNode; break; }
                    current = current.Right;
                }
                else
                {
                    // Если ID совпал, просто обновляем данные (зависит от твоей логики)
                    current.Data = record;
                    return -1; // Не увеличиваем глубину, перестройка не нужна
                }
            }
            totalNodes++;
            if (totalNodes > maxNodes) maxNodes = totalNodes;
            return depth;
        }

        // Удаление
        public bool Delete(int id)
        {
            bool deleted = false;
            root = DeleteRecursive(root, id, ref deleted);

            if (deleted)
            {
                totalNodes--;
                // Если дерево стало слишком "дырявым" (узлов меньше, чем alpha * maxNodes)
                // перестраиваем всё дерево целиком
                if (totalNodes < alpha * maxNodes)
                {
                    root = Rebuild(root);
                    maxNodes = totalNodes;
                }
            }
            return deleted;
        }

        private Node DeleteRecursive(Node node, int id, ref bool deleted)
        {
            if (node is null) return null;

            if (id < node.Data.ID)
            {
                node.Left = DeleteRecursive(node.Left, id, ref deleted);
            }
            else if (id > node.Data.ID)
            {
                node.Right = DeleteRecursive(node.Right, id, ref deleted);
            }
            else
            {
                // Узел найден
                deleted = true;

                // Случай 1 - Нет детей или только один ребенок
                if (node.Left is null) return node.Right;
                if (node.Right is null) return node.Left;

                // Случай 2 - У узла два ребенка
                // Ищем минимальный элемент в правом поддереве (преемник)
                Node successor = GetMinNode(node.Right);
                node.Data = successor.Data; // Копируем данные преемника в текущий узел

                // Удаляем преемника из правого поддерева
                bool dummy = false;
                node.Right = DeleteRecursive(node.Right, successor.Data.ID, ref dummy);
            }

            UpdateSize(node);
            return node;
        }

        private Node GetMinNode(Node node)
        {
            while (node.Left is not null) node = node.Left;
            return node;
        }

        public bool Update(int id, string newName, string newText, string newUpdateDate)
        {
            // 1. Ищем узел с нужным ID (стандартный поиск в BST)
            Node current = root;
            while (current != null)
            {
                if (id == current.Data.ID)
                {
                    // 2. Узел найден — обновляем только разрешенные поля
                    current.Data.Name = newName;
                    current.Data.Text = newText;
                    current.Data.Updated_Data = newUpdateDate;

                    return true; // Успешно обновлено
                }

                // Переходим к следующему узлу
                current = id < current.Data.ID ? current.Left : current.Right;
            }

            return false; // Запись с таким ID не найдена
        }

        // Поиск по ID (O(log N))
        public Records SearchById(int id)
        {
            Node current = root;
            while (current != null)
            {
                if (id == current.Data.ID) return current.Data;
                current = id < current.Data.ID ? current.Left : current.Right;
            }
            return null; // Не найдено
        }

        // Поиск по имени
        public List<Records> SearchByName(string name)
        {
            List<Records> result = new List<Records>();
            TraverseAndFilter(root, r => string.Equals(r.Name, name, StringComparison.OrdinalIgnoreCase), result);
            return result;
        }

        // Поиск по датам (С трансформацией строк)
        public List<Records> SearchByCreatedDate(DateTime from, DateTime to)
        {
            List<Records> result = new List<Records>();
            DateTime startDate = from.Date;
            DateTime endDate = to.Date;

            TraverseAndFilter(root, r =>
            {
                if (DateTime.TryParse(r.Created_Data, out DateTime date))
                    return date.Date >= startDate && date.Date <= endDate;
                return false;
            }, result);
            return result;
        }

        public List<Records> SearchByUpdatedDate(DateTime from, DateTime to)
        {
            List<Records> result = new List<Records>();
            DateTime startDate = from.Date;
            DateTime endDate = to.Date;

            TraverseAndFilter(root, r =>
            {
                if (DateTime.TryParse(r.Updated_Data, out DateTime date))
                    return date.Date >= startDate && date.Date <= endDate;
                return false;
            }, result);
            return result;
        }

        // Универсальный метод обхода для фильтрации
        private void TraverseAndFilter(Node node, Func<Records, bool> predicate, List<Records> result)
        {
            if (node == null) return;
            TraverseAndFilter(node.Left, predicate, result);
            if (predicate(node.Data)) result.Add(node.Data);
            TraverseAndFilter(node.Right, predicate, result);
        }

        // Балансировка (Scapegoat логика)
        private void RebalanceFromScapegoat(Records insertedData)
        {
            Node scapegoat = null;
            Node parent = null;
            Node curr = root;

            while (curr != null && curr.Data.ID != insertedData.ID)
            {
                Node next = insertedData.ID < curr.Data.ID ? curr.Left : curr.Right;
                if (!IsBalanced(curr)) scapegoat = curr;
                if (next != scapegoat) parent = curr;
                curr = next;
            }

            if (scapegoat != null)
            {
                Node newNode = Rebuild(scapegoat);
                if (parent == null) root = newNode;
                else if (parent.Left == scapegoat) parent.Left = newNode;
                else parent.Right = newNode;
            }
        }

        private bool IsBalanced(Node node) =>
            GetSize(node.Left) <= alpha * node.Size && GetSize(node.Right) <= alpha * node.Size;

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

        private void UpdateSize(Node node) => node.Size = 1 + GetSize(node.Left) + GetSize(node.Right);
        private int GetSize(Node node) => node?.Size ?? 0;
    }
}
