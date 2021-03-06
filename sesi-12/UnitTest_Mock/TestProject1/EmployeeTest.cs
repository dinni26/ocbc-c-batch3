using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;
using Xunit;

namespace TestProject1
{
    public class EmployeeTest
    {
            public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

            [Fact]
            public async void GetEmployeebyId()
            {
                mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("dinni");
                EmployeeController emp = new EmployeeController(mock.Object);
                string result = await emp.GetEmployeeById(1);
                Assert.Equal("dinni", result);
            }

            [Fact]
            public async void GetEmployeeDetails()
            {
                var employeeDTO = new Employee()
                {
                    Id = 1,
                    Name = "dinni",
                    Designation = "test"
                };
                mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
                EmployeeController emp = new EmployeeController(mock.Object);
                var result = await emp.GetEmployeeDetails(1);
                Assert.True(employeeDTO.Equals(result));
            }
        }
 
}
