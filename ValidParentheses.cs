public bool IsValid(string s) {
	if (s.Length == 1 || s.Length % 2 != 0)
	{
		return false;
	}

	var brackets = new Dictionary<char, char>
	{
		{ ')', '(' },
		{ '}', '{' },
		{ ']', '[' }
	};

	var stack = new Stack<char>();

	for (var i = 0; i < s.Length; i++)
	{
		switch (s[i])
		{
			case '(':
			case '{':
			case '[':
				stack.Push(s[i]);
				break;
			default:
				if (stack.Count == 0 || brackets[s[i]] != stack.Pop())
				{
					return false;
				}

				break;
		}
	}

	return stack.Count == 0;
}
