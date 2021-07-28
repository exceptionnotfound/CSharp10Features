//NOTE: This will not compile at the moment, since anonymous with expressions are not included
//in the C# 10 preview at publishing time.
//However, this file will give you an idea of how this feature might work when C# 10 is available.

namespace CSharp10Demo
{
    public record Animal(string Name, string Type, int Age);

    class AnonymousWithExpressions
    {
        public void TestMethod()
        {
            //Implementation using records in C# 9.0
            var dog = new Animal("Charlie", "Dog", 7);

            var cat = dog with { Type = "Cat" };

            Console.WriteLine(cat.Name); //Charlie


            //Implementation in C# 10.0
            var dog = new { Name = "Max", Type = "Dog", Age = 10 };

            var cat = dog with { Type = "Cat" };
        }
    }
}
