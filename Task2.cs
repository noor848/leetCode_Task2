 public class ListNode2 {
     public int val;
      public ListNode2 next;
      public ListNode2(int val=0, ListNode2 next=null) {
         this.val = val;
         this.next = next;
     }
 }
public class Task2
{ public static ListNode2 MiddleNode(ListNode2 head)
    {
        ListNode2 listOne = head;
        int count = 0;

        while (listOne != null)
        {
            count++;
            listOne = listOne.next;
        }

        if (count % 2 == 1)
        {
            int i = 0;
            while (i < count / 2)
            {
                head = head.next;
                i++;
            }
            return head;
        }
        else
        {
            int i = 0;
            while (i < (count / 2) - 1)
            {
                head = head.next;
                i++;
            }
        }
        return head.next;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        if (arr.Length == 1)
        {
            Console.WriteLine(arr[arr.Length - 1]);
        }
        else
        {
            ListNode2 listNode = new ListNode2(arr[0]);
            ListNode2 head = listNode;

            int i = 1;
            while (i < arr.Length)
            {
                ListNode2 listNode2 = new ListNode2(arr[i]);
                head.next = listNode2;
                head = head.next;
                i++;
            }

            ListNode2 head3 = Task2.MiddleNode(listNode);
            while (head3 != null)
            {
                Console.Write(head3.val + " ");
                head3 = head3.next;
            }

        }
    }
}