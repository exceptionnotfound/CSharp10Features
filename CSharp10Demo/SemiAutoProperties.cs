//NOTE: This will not compile at the moment, since semi-auto properties are not included
//in the C# 10 preview at publishing time.
//However, this file will give you an idea of how this feature might work when C# 10 is available.

namespace CSharp10Demo
{
    public class EmployeeCurrentImplementation
    {
        private DateTime _hireDate;

        public DateTime HireDate
        {
            get
            {
                return _hireDate;
            }
            set
            {
                _hireDate = value.Date;
            }
        }
    }

    public class EmployeeNewImplementation
    {
        public DateTime HireDate { get; set => field = value.Date; }
    }

    public class Customer
    {
        public DateTime DateOfVisit { get; init => field = value.Date; }
    }
}
