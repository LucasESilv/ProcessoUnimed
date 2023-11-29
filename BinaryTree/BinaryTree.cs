namespace ProcessoUnimed.BinaryTree
{
    public class BinaryTree
    {
      public Node Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private Node InsertRec(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.Value)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Value)
                root.Right = InsertRec(root.Right, data);

            return root;
        }

        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }
    }
}