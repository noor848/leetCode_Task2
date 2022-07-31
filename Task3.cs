

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
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
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
            ListNode head3 = Task3.ReverseList(listNode);
            while (head3 != null)
            {
                Console.Write(head3.val + " ");
                head3 = head3.next;
            }

        }
    }

}
