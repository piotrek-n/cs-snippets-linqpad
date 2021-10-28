<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

interface ITest<in TIn, out TOut> {
	TOut Method(TIn param); // Returns error TIn Method(Tout param); 
}

void Main()
{
	
}

// https://blog.ndepend.com/covariance-and-contravariance-in-csharp-explained/
