using NUnit.Framework;
using PracticeOfAlgorithms;

namespace PracticeOfAlgorithmsTest;

[TestFixture]
public class ProblemLongestPalindromicSubstringTests
{
	[Test]
	public void AddTwoNumbers_NullExample()
	{
		ProblemLongestPalindromicSubstring solver = new();

		// Act
		string result = solver.LongestPalindrome(null);

		// Assert
		Assert.IsNull(result);
	}
	
	[Test]
	public void AddTwoNumbers_Example1()
	{
		string s = "babad";
		ProblemLongestPalindromicSubstring solver = new();

		// Act
		string result = solver.LongestPalindrome(s);

		// Assert
		Assert.NotNull(result);
		Assert.AreEqual("aba",result);
	}
	
	[Test]
	public void AddTwoNumbers_Example2()
	{
		string s = "cbbd";
		ProblemLongestPalindromicSubstring solver = new();

		// Act
		string result = solver.LongestPalindrome(s);

		// Assert
		Assert.NotNull(result);
		Assert.AreEqual("bb",result);
	}
}