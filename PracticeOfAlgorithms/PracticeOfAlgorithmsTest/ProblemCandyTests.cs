using System;
using NUnit.Framework;
using PracticeOfAlgorithms;

namespace PracticeOfAlgorithmsTest;

[TestFixture]
public class ProblemCandyTests
{
	[Test]
	public void TwoSum_Example1()
	{
		// Arrange
		ProblemCandy solver = new ProblemCandy();
		int[] ratings = { 1,0,2 };

		// Act
		int result = solver.Candy(ratings);

		// Assert
		Assert.AreEqual(5, result);
	}

	[Test]
	public void TwoSum_Example2()
	{
		// Arrange
		ProblemCandy solver = new ProblemCandy();
		int[] ratings = { 1,2,2 };

		// Act
		int result = solver.Candy(ratings);

		// Assert
		Assert.AreEqual(4, result);
	}
	
	[Test]
	public void TwoSum_Example3()
	{
		// Arrange
		ProblemCandy solver = new ProblemCandy();
		int[] ratings = {1,2,87,87,87,2,1};

		// Act
		int result = solver.Candy(ratings);

		// Assert
		Assert.AreEqual(13, result);
	}
	
	[Test]
	public void TwoSum_Example4()
	{
		// Arrange
		ProblemCandy solver = new ProblemCandy();
		int[] ratings = new int[20000];
		Random random = new Random();
		
		for( int i = 0; i < ratings.Length; i++ )
			ratings[i] = random.Next(0, 20000);

		// Act
		int result = solver.Candy(ratings);

	}
}