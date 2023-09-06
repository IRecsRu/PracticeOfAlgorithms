namespace PracticeOfAlgorithms;

public class ProblemTwoSum
{
	public int[] TwoSum(int[] nums, int target)
	{
		Dictionary<int, int> seen = new();
		
		for(int i = 0; i < nums.Length; i++)
		{
			int complement = target - nums[i];

			if(seen.ContainsKey(complement) && seen[complement] != i)
				return new[]{seen[complement], i};

			if(!seen.ContainsKey(nums[i]))
				seen.Add(nums[i], i);
            
		}
		
		return null;
	}
}