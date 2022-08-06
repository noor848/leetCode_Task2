namespace Task3
{
    internal static class Task3HelpersClass
    {
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