 public class ListNode2 {
     public int val;
      public ListNode2 next;
      public ListNode2(int val=0, ListNode2 next=null) {
         this.val = val;
         this.next = next;
     }
 }
public class Task2 : Task2Main
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
}