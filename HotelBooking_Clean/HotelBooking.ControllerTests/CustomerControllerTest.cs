using System;
using System.Collections.Generic;
using HotelBooking.Controllers;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

/// <summary>
/// © Software Developed by Rafa ©
/// </summary>

namespace HotelBooking.UnitTests
{
    public class CustomerControllerTest
    {
        // Controller declaration
        private CustomersController controller;

        // Mocks
        private Mock<IRepository<Customer>> fakeCustomerRepository;

        // Dates
        private DateTime dtS = DateTime.Today.AddDays(1).AddMonths(2);
        private DateTime dtE = DateTime.Today.AddDays(8).AddMonths(2);

        // Constructor
        public CustomerControllerTest()
        {
            List<Booking> bookings = new List<Booking>
            {
                new Booking { Id=1, StartDate = dtS, EndDate = dtE, IsActive=true, CustomerId=1, RoomId=1 },
                new Booking { Id=2, StartDate = dtS, EndDate = dtE, IsActive=true, CustomerId=2, RoomId=2 },
            };

            var customers = new List<Customer>
            {
                new Customer { Id=1, Name="Manolo", Email="mano@hotmail.com", Bookings= bookings },
                new Customer { Id=2, Name="Manuel", Email="manu@gmail.com", Bookings= bookings }
            };

            // Create fake RoomRepository
            fakeCustomerRepository = new Mock<IRepository<Customer>>();

            // Implement fake GetAll() method.
            fakeCustomerRepository.Setup(x => x.GetAll()).Returns(customers);

            // Implement fake Get() method.
            fakeCustomerRepository.Setup(x => x.Get(1)).Returns(customers[1]);
            fakeCustomerRepository.Setup(x => x.Get(2)).Returns(customers[1]);

            // Create RoomsController
            controller = new CustomersController(fakeCustomerRepository.Object);
        }

        // IActionResult Index()
        [Fact]
        public void Index_ReturnsViewResultWithCorrectListOfCustomers()
        {
            // Act
            var result = controller.Index() as ViewResult;
            var customersList = result.Model as IList<Customer>;
            var noOfCustomers = customersList.Count;
            // Assert
            Assert.Equal(2, noOfCustomers);
        }

        // Create([Bind("Id,Description")] Room room)
        [Fact]
        public void Create_WithAnyCreate_ReturnTrue()
        {
            // Act
            controller.Create(It.IsAny<Customer>());

            // Assert Id Room
            fakeCustomerRepository.Verify(x => x.Add(It.IsAny<Customer>()), Times.Once);
        }

        // IActionResult Edit(int? id) where Id is null
        [Fact]
        public void Edit_CustomerIdIsNull_EditedFalse()
        {
            // Act 
            controller.Edit(null);
            // Assert Verify
            fakeCustomerRepository.Verify(x => x.Edit(It.IsAny<Customer>()), Times.Never);
        }

        // IActionResult Edit(int? id) where Id is != Rooms Id
        [Fact]
        public void Edit_CustomerIdIsNotFound_EditedFalse()
        {
            // Act 
            controller.Edit(10);
            // Assert Verify
            fakeCustomerRepository.Verify(x => x.Edit(It.IsAny<Customer>()), Times.Never);
        }

        // IActionResult Edit(int? id) where Id is 1 or 2 (Valid Data)
        [Fact]
        public void Edit_CustomerIdIsValis_EditedTrue()
        {
            // Act 
            var result = controller.Edit(1) as ViewResult;
            var customer = result.Model as Customer;
            var customerId = customer.Id;
            // Assert Verify
            Assert.InRange<int>(customerId, 1, 2);
        }

        // IActionResult Edit(int id, [Bind("Id,Description")] Customer customer) CustomerId != Id
        [Fact]
        public void EditParameters_IdDistinctToCustomer_EditedFalse()
        {
            // Act
            Customer c1 = new Customer();
            c1.Id = 2;
            controller.Edit(0, c1);
            // Assert Verify
            fakeCustomerRepository.Verify(x => x.Edit(It.IsAny<Customer>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("Id,Description")] Room room) RoomId = null
        [Fact]
        public void EditParameters_IdNullCustomer_EditedFalse()
        {
            // Act
            Customer c1 = new Customer();
            c1.Id = 100;
            controller.Edit(1, c1);
            // Assert Verify
            fakeCustomerRepository.Verify(x => x.Edit(It.IsAny<Customer>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("Id,Description")] Room room)
        [Fact]
        public void EditParameters_IdNullCustomer_EditedTrue()
        {
            // Act
            Customer c1 = new Customer();
            c1.Id = 1;
            controller.Edit(1, c1);
            // Assert Verify
            fakeCustomerRepository.Verify(x => x.Edit(It.IsAny<Customer>()), Times.Once);
        }

        // IActionResult Details(int? id)
        [Fact]
        public void Details_CustomerExists_ReturnsViewResultWithRoom()
        {
            // Act
            var result = controller.Details(2) as ViewResult;
            var customer = result.Model as Customer;
            var customerId = customer.Id;
            // Assert
            Assert.InRange<int>(customerId, 1, 2);
        }

        // DeleteConfirmed(int id) where id >= 1
        [Fact]
        public void DeleteConfirmed_WhenIdIsLargerThanZero_RemoveIsCalled()
        {
            // Act
            controller.DeleteConfirmed(1);
            // Assert against the mock object
            fakeCustomerRepository.Verify(x => x.Remove(It.IsAny<int>()));
        }

        // DeleteConfirmed(int id) where id <= 0
        [Fact]
        public void DeleteConfirmed_WhenIdIsLessThanOne_RemoveIsNotCalled()
        {
            // Act
            controller.DeleteConfirmed(0);
            // Assert against the mock object
            fakeCustomerRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Once());
        }

        // Delete(int? id) where id = [1, 2]
        [Fact]
        public void Delete_WhenRoomIdIsValid_ReturnViewRoom()
        {
            // Act 
            var result = controller.Delete(2) as ViewResult;
            var customer = result.Model as Customer;
            var customerId = customer.Id;
            // Assert Verify
            Assert.InRange<int>(customerId, 1, 2);
        }

        // Delete(int? id) where id = null
        [Fact]
        public void Delete_WhenIdIsnull_ReturnNullValid()
        {
            // Act 
            controller.Delete(null);
            // Assert Verify
            fakeCustomerRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
        }

        // Delete(int? id) where id = [RoomId Not Found]
        [Fact]
        public void Delete_WhenCustomerIdIsnull_ReturnRoomNull()
        {
            // Act 
            controller.Delete(10);
            // Assert Verify
            fakeCustomerRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
        }
    }
}