

namespace Task3 {

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Task3
    { public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return head;

            if (head.next == null)
                return head;

            ListNode k = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return k;
        }
    }

}
