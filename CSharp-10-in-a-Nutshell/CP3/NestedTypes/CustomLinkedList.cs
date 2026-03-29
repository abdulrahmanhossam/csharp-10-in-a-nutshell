namespace CSharp_10_in_a_Nutshell.CP3.NestedTypes;

public class CustomLinkedList
{
    private Node _head;

    public void Add(int value)
    {
        _head = new Node(value, _head);
    }

    private class Node
    {
        public int Value;
        public Node Next;

        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }
    }
}