using NUnit.Framework;
using PracticeOfAlgorithms;

namespace PracticeOfAlgorithmsTest;

public class ProblemAddTwoNumbersTests
{
	[Test]
	public void AddTwoNumbers_Example1()
	{
		// Arrange
		ProblemAddTwoNumbers.ListNode l1 = new(2, new ProblemAddTwoNumbers.ListNode(4, new ProblemAddTwoNumbers.ListNode(3)));
		ProblemAddTwoNumbers.ListNode l2 = new(5, new ProblemAddTwoNumbers.ListNode(6, new ProblemAddTwoNumbers.ListNode(4)));
		ProblemAddTwoNumbers solver = new();

		// Act
		ProblemAddTwoNumbers.ListNode result = solver.AddTwoNumbers(l1, l2);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(7, result.val);
		Assert.IsNotNull(result.next);
		Assert.AreEqual(0, result.next.val);
		Assert.IsNotNull(result.next.next);
		Assert.AreEqual(8, result.next.next.val);
		Assert.IsNull(result.next.next.next);
	}


	[Test]
	public void AddTwoNumbers_Example2()
	{
		// Arrange
		ProblemAddTwoNumbers.ListNode l1 = new(9);
		ProblemAddTwoNumbers.ListNode l2 = new(1);
		ProblemAddTwoNumbers solver = new();
		
		ProblemAddTwoNumbers.ListNode l2T = l2;
		for( int i = 0; i < 99; i++ )
		{
			l2T.next = new ProblemAddTwoNumbers.ListNode(9);
			l2T = l2T.next;
		}

		ProblemAddTwoNumbers.ListNode result = solver.AddTwoNumbers(l1, l2);
		// Assert

		for( int i = 0; i < 100; i++ )
		{
			Assert.IsNotNull(result);
			Assert.AreEqual(0, result.val);
			result = result.next;
		}

		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.val);
	}
}