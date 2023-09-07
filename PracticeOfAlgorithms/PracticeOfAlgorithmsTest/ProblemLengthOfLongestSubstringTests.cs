using NUnit.Framework;
using PracticeOfAlgorithms;

namespace PracticeOfAlgorithmsTest;

[TestFixture]
public class ProblemLengthOfLongestSubstringTests
{
	[Test]
	public void TwoSum_Example1()
	{
		// Arrange
		ProblemLengthOfLongestSubstring solver = new();
		string s = "abcabcbb";

		// Act
		int result = solver.LengthOfLongestSubstring(s);

		// Assert
		Assert.AreEqual(3, result);
	}
	
	[Test]
	public void TwoSum_Example2()
	{
		// Arrange
		ProblemLengthOfLongestSubstring solver = new();
		string s = "bbbbb";

		// Act
		int result = solver.LengthOfLongestSubstring(s);

		// Assert
		Assert.AreEqual(1, result);
	}
	
	[Test]
	public void TwoSum_Example3()
	{
		// Arrange
		ProblemLengthOfLongestSubstring solver = new();
		string s = "pwwkew";

		// Act
		int result = solver.LengthOfLongestSubstring(s);

		// Assert
		Assert.AreEqual(3, result);
	}
	
	[Test]
	public void TwoSum_Example4()
	{
		// Arrange
		ProblemLengthOfLongestSubstring solver = new();
		string s = "au";

		// Act
		int result = solver.LengthOfLongestSubstring(s);

		// Assert
		Assert.AreEqual(2, result);
	}
}