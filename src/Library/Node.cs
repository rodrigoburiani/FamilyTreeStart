using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Persona persona;
        private List<Node> children = new List<Node>();

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        public ReadOnlyCollection<Node> Children
        {
            get { return children.AsReadOnly(); }
        }

        public Node(Persona persona)
        {
            this.persona = persona;
        }

        public void AddChild(Node child)
        {
            children.Add(child);
        }

        public void Accept(INodeVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in children)
            {
                child.Accept(visitor);
            }
        }
    }
}
