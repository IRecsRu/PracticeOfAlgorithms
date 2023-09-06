using NUnit.Framework;
using PracticeOfAlgorithms;

namespace PracticeOfAlgorithmsTest;

[TestFixture]
public class ProblemTwoSumTests
{
	[Test]
	public void TwoSum_Example1()
	{
		// Arrange
		ProblemTwoSum solver = new ProblemTwoSum();
		int[] nums = { 2, 7, 11, 15 };
		int target = 9;

		// Act
		int[] result = solver.TwoSum(nums, target);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Length);
		Assert.AreEqual(0, result[0]);
		Assert.AreEqual(1, result[1]);
	}

	[Test]
	public void TwoSum_Example2()
	{
		// Arrange
		ProblemTwoSum solver = new ProblemTwoSum();
		int[] nums = { 3, 2, 4 };
		int target = 6;

		// Act
		int[] result = solver.TwoSum(nums, target);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(2, result.Length);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
	}

	[Test]
	public void TwoSum_NoSolution()
	{
		// Arrange
		ProblemTwoSum solver = new ProblemTwoSum();
		int[] nums = { 1, 2, 3, 4 };
		int target = 10;

		// Act
		int[] result = solver.TwoSum(nums, target);

		// Assert
		Assert.IsNull(result);
	}
}