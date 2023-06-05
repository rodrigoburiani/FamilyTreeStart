namespace Library
{
    public class LargestChildVisitor : INodeVisitor
    {
        private Node largestChild;
        private int largestSize;

        public void Visit(Node node)
        {
            if (node.Children.Count == 0)
            {
                int size = CalculateSize(node);
                if (size > largestSize)
                {
                    largestSize = size;
                    largestChild = node;
                }
            }
        }

        private int CalculateSize(Node node)
        {
            int size = 0;
            if (node.Persona != null)
            {
                size += node.Persona.Edad;
            }
            foreach (var child in node.Children)
            {
                size += CalculateSize(child);
            }
            return size;
        }

        public Node GetLargestChild()
        {
            return largestChild;
        }
    }
}