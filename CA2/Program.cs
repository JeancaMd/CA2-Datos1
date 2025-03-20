using System;
using System.Text;


public class Node
{
    public int value;
    public Node next;
    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}
public class CircularLinkedList
{
    private Node head;
    private Node tail;
    private int size;

    public CircularLinkedList()
    {
        this.tail = null;
        this.size = 0;
    }

    public void InsertarInicio(int value)
    {
        Node newNode = new Node(value);
        if (this.head == null)
        {
            this.head = newNode;
            this.tail.next = head;
        }
        else
        {
            newNode.next = this.head;
            this.head = newNode;
            tail.next = head;
        }
        size++;
    }

    public void InsertarFinal(int value)
    {
        Node newNode = new Node(value);
        if (this.head == null)
        {
            this.head = this.tail = newNode;
            this.tail.next = head;
        }
        else
        {
            this.tail.next = newNode;
            this.tail = newNode;
            this.tail.next = head;
        }
        size++;
    }

 }

class Program
{
    static void Main()
    {
        
    }
}
