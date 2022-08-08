namespace Task4
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Task4
    {  public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode list3 = null;
            ListNode l3 = null;
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            ListNode l1 = list1;
            ListNode l2 = list2;
            int count = 0, count2 = 0; ;
            list3 = new ListNode(0);
            l3 = list3;
            while (l1 != null && l2 != null)
            {
                if (l2.val <= l1.val)
                {
                    l3.next = l2;
                    list2 = list2.next;
                    l2.next = null;
                    l2 = list2;

                }
                else if (l1.val <= l2.val)
                {
                    l3.next = l1;
                    list1 = list1.next;
                    l1.next = null;
                    l1 = list1;

                }

                l3 = l3.next;
            }
            if (l1 == null)
            {
                l3.next = l2;

            }
            if (l2 == null)
            {
                l3.next = l1;
            }

            return list3.next;

        }
        public static ListNode generateLinkList(int[] arr)
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

            return listNode;
        }
        public static void print(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
    }
}
