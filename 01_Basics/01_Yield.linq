<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>



void Main()
{
	IEnumerable<int> GenerateWithoutYield()
	{
		var i = 0;
		var list = new List<int>();
		while (i < 5)
			list.Add(++i);
		return list;
	}
	foreach (var number in GenerateWithoutYield())
		Console.WriteLine(number);

	IEnumerable<int> GenerateWithYield()
	{
		var i = 0;
		while (i < 5)
			yield return ++i;
	}
	foreach (var number in GenerateWithYield())
		Console.WriteLine(number);
}


