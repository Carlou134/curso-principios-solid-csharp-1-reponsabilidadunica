namespace OpenClose
{
    public abstract class Employee
    {
        public string Fullname {get; set;} = String.Empty;
        public int HoursWorked {get; set;}
        public abstract decimal CalculateSalaryMonthly();
    }
}