namespace Builders.Domain
{
    using global::Domain;
    using System;

    public class EmployeeBuilder
    {
        private Employee _employee;
        public EmployeeBuilder()
        {
            _employee = new Employee();
        }

        public EmployeeBuilder Default()
        {
            _employee.Name = "John";
            _employee.BirthDate = new DateTime();
            _employee.GrossSalary = 1000;

            return this;
        }

        public EmployeeBuilder WithName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeBuilder HasAge(int age)
        {
            _employee.BirthDate = new DateTime(DateTime.Now.Year - age, DateTime.Now.Month, DateTime.Now.Day);
            return this;
        }

        public EmployeeBuilder HasGrossSalaryOf(double salary)
        {
            _employee.GrossSalary = salary;
            return this;
        }

        public Employee Build()
        {
            return _employee;
        }
    }
}
