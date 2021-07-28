using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
