namespace PracticeOfAlgorithms;

public class ProblemLengthOfLongestSubstring
{
	public int LengthOfLongestSubstring(string s)
	{
		if (string.IsNullOrEmpty(s)) 
			return 0;

		if(s.Length < 2)
			return s.Length;

		int maxLength = 0;
		int start = 0;

		List<char> currentLChars = new();

		for(; start < s.Length; start++)
		{
			char current = s[start];
			
			if(currentLChars.Contains(current))
			{
				maxLength = MaxLength(currentLChars, maxLength);

				int index  = currentLChars.IndexOf(current);
				currentLChars.RemoveRange(0, index +1);
			}
			
			currentLChars.Add(current);
		}

		maxLength = MaxLength(currentLChars, maxLength);
		return maxLength;
	}
	
	private static int MaxLength(List<char> currentLChars, int maxLength)
	{
		int length = currentLChars.Count;

		if(maxLength < length)
			maxLength = length;
		
		return maxLength;
	}
}