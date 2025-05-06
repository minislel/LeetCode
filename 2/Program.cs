using System.Numerics;

namespace _2
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

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string num1 = "";
            string num2 = "";
            string num1reverse = "";
            string num2reverse = "";

            while (l1 is not null)
            {
                num1 += l1.val.ToString();
                l1 = l1.next;
            }
            while (l2 is not null)
            {
                num2 += l2.val.ToString();
                l2 = l2.next;
            }
            foreach (var c in num1.Reverse())
            {
                num1reverse += c.ToString();
            }
            foreach (var c in num2.Reverse())
            {
                num2reverse += c.ToString();
            }
            BigInteger n1 = BigInteger.Parse(num1reverse);
            BigInteger n2 = BigInteger.Parse(num2reverse);
            BigInteger sum = n1 + n2;

            List<ListNode> nodes = new List<ListNode>();
            for (int i = sum.ToString().Length-1; i >= 0; i--)
            {

                ListNode node = new ListNode();
                var temp = int.Parse(sum.ToString("F")[i].ToString());
                node.val = temp;
                nodes.Add(node);
            }
            for (int i = 0; i < nodes.Count - 1; i++)
            {
                if (i < nodes.Count-1)
                {
                    nodes[i].next = nodes[i + 1];
                }
            }
            return nodes[0];
        }
    }
}
