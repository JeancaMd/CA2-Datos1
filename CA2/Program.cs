using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


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

    public void InsertStart(int value)
    {
        Node newNode = new Node(value);
        if (this.head == null)
        {
            this.head = this.tail = newNode;
            this.tail.next = this.head;
        }
        else
        {
            newNode.next = this.head;
            this.head = newNode;
            this.tail.next = head;
        }
        size++;
    }

    public void InsertEnd(int value)
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

    public void InsertAt(int value, int index)
    {
        if (index < 0 || index > size) throw new ArgumentOutOfRangeException();
        if (index == 0)
        {
            InsertStart(value);
            return;
        }
        if (index == size)
        {
            InsertEnd(value);
            return;
        }

        Node newNode = new Node(value);
        Node current = head;
        for (int i = 0; i < index - 1; i++)
        {
            current = current.next;
        }
        newNode.next = current.next;
        current.next = newNode;
        size++;
    }


    public void DeleteStart()
    {
        if (this.head == null) return;
        if (this.head == this.tail)
        {
            this.head = this.tail = null;
        }
        else
        {
            this.head = this.head.next;
            this.tail.next = this.head;
        }
        size--;
    }

    public void DeleteEnd()
    {
        if (this.head == null) return;
        if (this.head == this.tail) 
        { 
            this.head = this.tail = null; 
        }
        else
        {
            Node current = this.head;
            while (current.next != this.tail) 
                current = current.next;
            this.tail = current;
            this.tail.next = this.head;
            
        }
        size--;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index > size) throw new ArgumentOutOfRangeException();
        if (index == 0)
        {
            DeleteStart();
            return;
        }
        if (index == size)
        {
            DeleteEnd();
            return;
        }

        Node current = this.head;
        for (int i = 0; i < index - 1; i++)
            current = current.next;

        current.next = current.next.next;
        size--;
    }

 }

class Program
{
    static void Main()
    {
        
    }
}
