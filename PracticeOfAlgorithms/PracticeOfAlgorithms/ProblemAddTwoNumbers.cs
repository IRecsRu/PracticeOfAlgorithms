namespace PracticeOfAlgorithms;

public class ProblemAddTwoNumbers
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

	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		ListNode answer = new(0);
		ListNode current = answer;

		int remainder = 0;

		while(l1 != null || l2 != null || remainder != 0)
		{
			int x = l1?.val ?? 0;
			int y = l2?.val ?? 0;

			int sum = remainder + x + y;
			remainder = sum / 10;

			current.next = new ListNode(sum % 10);
			current = current.next;

			l1 = l1?.next;
			l2 = l2?.next;
		}

		return answer.next;
	}
}