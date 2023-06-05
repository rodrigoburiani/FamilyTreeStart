namespace Library
{
    public class AgeSumVisitor : INodeVisitor
    {
        private int sum;

        public void Visit(Node node)
        {
            sum += node.Persona.Edad;
        }

        public int GetAgeSum()
        {
            return sum;
        }
    }
}