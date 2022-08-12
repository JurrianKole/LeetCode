public bool IsPalindrome(int x) 
{
	var value = x.ToString();

	for (var i = 0; i < value.Length / 2; i++)
	{
		if (value[i] != value[value.Length - 1 - i])
		{
			return false;
		}
	}

	return true;
}
