// Leet code 206. Reverse Linked List
//  Given the head of a singly linked list, reverse the list and return the reversed list.

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode nextNode = null;

        while (current != null)
        {
            nextNode = current.next; // Save the next node
            current.next = prev; // Sever the link with the next node (turning the first node into a tail)
            prev = current; // Jump the pointers one position
            current = nextNode;
        }
        return prev; // Return the new head.
    }
}