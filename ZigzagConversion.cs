public string Convert(string s, int numRows) 
{           
	if (numRows == 1)
	{
		return s;
	}

	var shift = (numRows - 1) * 2;

	var result = string.Empty;


	for (var row = 0; row < numRows; row++)
	{
		for (var i = row; i < s.Length; i += shift)
		{
			result += s[i];

			if (row > 0 && row < numRows - 1 && i + shift - 2 * row < s.Length)
			{
				result += s[i + shift - 2 * row];
			}
		}
	}

	return result;
}
