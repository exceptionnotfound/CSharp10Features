namespace CSharp10Demo
{
    public class ConstInterpolatedStrings
    {
        public const string Greeting = "Hello ";
        public const string Title = "Ms. ";
        public const string LastName = "Keating";

        public const string Salutation
            = $"{Greeting}, {Title}{LastName}!";
    }
}
