namespace PracticeOfAlgorithms;

public class ProblemCandy
{
	/*public int Candy(int[] ratings)
	{
		int n = ratings.Length;
		int[] candies = new int[n];
		Array.Fill(candies, 1);

		for( int i = 1; i < n; i++ )
		{
			if(ratings[i] > ratings[i - 1])
				candies[i] = candies[i - 1] + 1;
		}

		for( int i = n - 2; i >= 0; i-- )
		{
			int j = i + 1;
			
			if(ratings[i] > ratings[j])
				candies[i] = Math.Max(candies[i], candies[j] + 1);
		}

		return candies.Sum();
	}*/
	
	public int Candy(int[] ratings)
	{
		if (ratings == null || ratings.Length == 0)
			return 0;

		int ret = 1, up = 0, down = 0, peak = 0;

		for (int i = 1; i < ratings.Length; i++)
		{
			if (ratings[i - 1] < ratings[i])
			{
				up++;
				down = 0;
				peak = up;
				ret += 1 + up;
			}
			else if (ratings[i - 1] == ratings[i])
			{
				up = down = peak = 0;
				ret += 1;
			}
			else
			{
				down++;
				up = 0;
				ret += 1 + down - (peak >= down ? 1 : 0);
			}
		}

		return ret;
	}
}