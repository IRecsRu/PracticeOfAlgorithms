using System.Text;

namespace PracticeOfAlgorithms;

public class ProblemLongestPalindromicSubstring
{
	/*public string LongestPalindrome(string s)
	{
		if(string.IsNullOrEmpty(s))
			return "";
		
		StringBuilder sPrime = new StringBuilder("#");
		
		foreach(char c in s)
			sPrime.Append(c).Append("#");

		int length = sPrime.Length;
		int[] palindromeRadiI = new int[length];
		int center = 0;
		int radius = 0;

		for( int i = 0; i < length; i++ )
		{
			int mirror = 2 * center - i;

			if(i < radius)
			{
				palindromeRadiI[i] = Math.Min(radius - i, palindromeRadiI[mirror]);
			}

			while(i + 1 + palindromeRadiI[i] < length && i - 1 - palindromeRadiI[i] >= 0 && sPrime[i + 1 + palindromeRadiI[i]] == sPrime[i - 1 - palindromeRadiI[i]])
			{
				palindromeRadiI[i]++;
			}

			if(i + palindromeRadiI[i] > radius)
			{
				center = i;
				radius = i + palindromeRadiI[i];
			}
		}

		int maxLength = 0;
		int centerIndex = 0;
		
		for( int i = 0; i < length; i++ )
		{
			if(palindromeRadiI[i] > maxLength)
			{
				maxLength = palindromeRadiI[i];
				centerIndex = i;
			}
		}

		int startIndex = (centerIndex - maxLength) / 2;
		string longestPalindrome = s.Substring(startIndex, maxLength);

		return longestPalindrome;
	}*/
	
	public string LongestPalindrome(string s)
	{
		if(string.IsNullOrEmpty(s))
			return "";
		
		int length = s.Length;
		bool[,] dp = new bool[length, length];
		
		int start = 0;
		int end = 0;
    
		for (int i = 0; i < length; i++)
			dp[i, i] = true;

		for (int i = 0; i < length - 1; i++)
		{
			if (s[i] == s[i + 1]) 
			{
				dp[i, i + 1] = true;
				
				start = i;
				end = i + 1;
			}
		}
    
		for (int diff = 2; diff < length; diff++) 
		{
			for (int i = 0; i < length - diff; i++)
			{
				int j = i + diff;
				
				if (s[i] == s[j] && dp[i + 1, j - 1]) 
				{
					dp[i, j] = true;
					start = i;
					end = j;
				}
			}
		}
    
		return s.Substring(start, end - start + 1);
	}
}