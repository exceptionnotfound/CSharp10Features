//NOTE: Microsoft decided not to include this feature in C# 10's release. I'll keep it here to keep my post consistent,
//but know that this feature is not available in C# 10.

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
