
 public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
   }
}

public class Task1
{  
 public static ListNode DetectCycle(ListNode head)
    {   ListNode listOne = head;
        ListNode listTwo = head;
        Dictionary<ListNode, ListNode> NodeStore = new Dictionary<ListNode, ListNode>();

        if (head == null || head.next == null)
            return null;

        while (listOne.next != null)
        { if (NodeStore.ContainsKey(listOne.next))
            {   return listOne.next;
            }

            NodeStore.Add(listOne, listOne.next);
            listOne = listOne.next;
        }
        return null;
    }


    }
