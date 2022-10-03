/* 
 * FILA - Coda: struttura lineare che segue un ordine particolare in cui vengono eseguite le operazioni.
 * L'ordine è FIRST IN FIRST OUT (FIFO)
 */

using DatiEAlgoritmi6;
using System.Diagnostics;

class Queue
{
    private Node head;
    private Node tail;
    private int size; // dimensione della coda

    //aggiungi elemento alla coda
    public void Offer(string element)
    {
        if (head == null) // se la coda è vuota
        {
            head = new Node(element); // aggiunti elemento alla testa
            tail = head;
        }
        else
        {
            Node newNode = new Node(element);
            newNode.next = tail;
            tail.prev = newNode;
            tail = newNode;
        }
        size++;
    }

    // prendi la testa e poi rimuovi l'elemento head dalla coda

    public Node Poll()
    {
        Node p = head;
        if(p == null)
        {
            return null;
        }
        head = head.prev;
        p.next = null;
        p.prev = null;
        size--;
        return p;  

    }

    public int Size() { return size; }

    public static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Offer("A");
        queue.Offer("B");
        queue.Offer("C");
        queue.Offer("D");

        print(queue);
    }

    public static void print(Queue queue)
    {
        Console.Write("Head ");
        Node node = null;
        while((node = queue.Poll())!= null)
        {
            Console.Write(node.data + " <- ");
        }
        Console.Write("Tail\n");
    }
}