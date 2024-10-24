namespace LeetCode
{
    class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var listReference = new ListNode(0);
            var current = listReference;
            int over = 0;

            while (l1 != null || l2 != null || over != 0)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;

                int sum = x + y + over;

                over = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            return listReference.next;
        }

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
    }

}