namespace Library
{
    public class LongestNameVisitor : INodeVisitor
    {
        private string longestName;

        public void Visit(Node node)
        {
            if (node.Persona != null)
            {
                string currentName = node.Persona.Nombre;
                if (string.IsNullOrEmpty(longestName) || currentName.Length > longestName.Length)
                {
                    longestName = currentName;
                }
            }
        }

        public string GetLongestName()
        {
            return longestName;
        }
    }
}