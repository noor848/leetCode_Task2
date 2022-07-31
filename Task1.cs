
 public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
   }
}

public class Task1
{  public static ListNode DetectCycle(ListNode head)
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

    public static void Main(string[] args)
    {
        int[] arr = { 1,2,3};
        if (arr.Length == 1)
            Console.WriteLine("no Cycle");
        else
        {
            ListNode listNode = new ListNode(arr[0]);
            ListNode head = listNode;
            int i = 1;
            while (i < arr.Length)
            {
                ListNode listNode2 = new ListNode(arr[i]);
                head.next = listNode2;
                head = head.next;
                i++;
            }

            int position = 1;///position of Tail Connection 
            ListNode head3 = listNode;
            while (position != 0)
            {
                head3 = head3.next;
                position--;
            }
            head.next = head3;
            Task1.DetectCycle(listNode);
            int index = 0;
            while (head3 != listNode)
            {
                listNode = listNode.next;
                index++;
            }
            Console.WriteLine("Position is At :"+index);
        }
    }
}