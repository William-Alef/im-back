namespace Class
{
    public class Node
    {
        public string Name;
        public Node Next;

        public Node(string value)
        {
            Name = value;
            Next = null;
        }
    }
    public class LinkedList
    {
        public Node Init;
        public void Add(string value)
        {
            Node newNode = new Node(value);
            if (Init == null)
            {
                Init = newNode;
            }
            else
            {
                Node thisNode = Init;
                while (thisNode.Next != null)
                {
                    thisNode = thisNode.Next;
                }
                thisNode.Next = newNode;
            }
        }
        public void Show()
        {
            Node thisNode = Init;
            while (thisNode != null)
            {
                System.Console.WriteLine(thisNode.Name);
                System.Console.WriteLine(thisNode);
                thisNode = thisNode.Next;
            }
        }
    }   
}