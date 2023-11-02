using System;
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode? next;

    public  ListNode(int v)
    {
        val = v;
        next = null;
    }
}

class Program
{
    public static ListNode MergeKLists(List<List<int>> lists)
    {
        // Create a new list to store the merged linked list
        List<int> mergedList = new List<int>();

        // Iterate over each linked list in the list of lists
        foreach (List<int> list in lists)
        {
            // Iterate over each element in the linked list
            foreach (int num in list)
            {
                // Add the element to the merged list
                mergedList.Add(num);
            }
        }

        // Sort the merged list in ascending order
        mergedList.Sort();

        // Create a dummy Node as the head of the merged linked list
        ListNode? dummy = new ListNode(0);
        ListNode current = dummy;

        // Create a new Node for each element in the merged list and link them together to form the merged linked list
        foreach (int num in mergedList)
        {
            current.next = new ListNode(num);
            current = current.next;
        }

        return dummy;
    }

    static void Main(string[] args)
    {
        // Create the input list of lists
        List<List<int>> lists = new List<List<int>>
        {
            new List<int> { 1, 3, 4 },
            new List<int> { 2, 6 },
        };

        // Merge the linked lists and get the merged linked list head
        ListNode mergedHead = MergeKLists(lists);

        // Print the merged linked list
        ListNode? current = mergedHead;
        Console.Write("Merged linked list: ");
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
    }
}