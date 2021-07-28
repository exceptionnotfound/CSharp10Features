//NOTE: This will not compile at the moment, since null parameter checking is not included
//in the C# 10 preview at publishing time.
//However, this file will give you an idea of how this feature might work when C# 10 is available.

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
