using Builders.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class Employee
    {

        [TestMethod]
        public void TestEmployee()
        {
            var builder = new EmployeeBuilder();

            var employee = builder
                .WithName("Samuel")
                .HasAge(35)
                .HasGrossSalaryOf(1000)
                .Build();

            Assert.AreEqual(850, employee.CalculateNetSalary());

        }
    }
}
