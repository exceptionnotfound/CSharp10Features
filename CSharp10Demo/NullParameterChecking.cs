//NOTE: Microsoft decided not to include this feature in C# 10's release. I'll keep it here to keep my post consistent,
//but know that this feature is not available in C# 10.

namespace CSharp10Demo
{
    public class MyCustomClass { }

    public class NullParameterCheckCurrentImplementation
    {
        public string FormatName(string name)
        {
            if (name == null)
                return "Error";
            //...Rest of implementation
            return string.Empty;
        }

        public void FormatCustomClass(MyCustomClass customClass)
        {
            if (customClass == null)
                return;
            //...Rest of implementation
        }
    }

    public class NullParameterCheckNewImplementation
    {
        public string FormatName(string name!)
        {
            //...Rest of implementation
            return string.Empty;
        }

        public void FormatCustomClass(MyCustomClass customClass!)
        {
            //...Rest of implementation
        }
    }
}
