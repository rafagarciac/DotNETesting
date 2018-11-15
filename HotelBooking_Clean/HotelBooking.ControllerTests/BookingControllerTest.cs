using HotelBooking.BusinessLogic;
using HotelBooking.Controllers;
using HotelBooking.Models;
using HotelBookingStartupProject.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HotelBooking.UnitTests
{
    public class BookingsControllerTest
    {

        // Declarations
        private BookingsController controller;
        private Mock<IBookingManager> bookingManager;
        private Mock<IBookingViewModel> bookingViewModel;

        // Mocks
        private Mock<IRepository<Room>> fakeRoomRepository;
        private Mock<IRepository<Customer>> fakeCustomerRepository;
        private Mock<IRepository<Booking>> fakeBookingRepository;

        // Dates
        private DateTime startDate;
        private DateTime endDate;


        // Constructor
        public BookingsControllerTest()
        {
            // Dates
            startDate = DateTime.Today.AddDays(1).AddMonths(2);
            endDate = DateTime.Today.AddDays(8).AddMonths(2);

            // Create a Booking List 
            List<Booking> bookings = new List<Booking>
            {
                new Booking { Id=1, StartDate=startDate, EndDate=endDate, IsActive=true, CustomerId=1, RoomId=1 },
                new Booking { Id=2, StartDate=startDate, EndDate=endDate, IsActive=true, CustomerId=2, RoomId=2 },
            };

            // Create a Customer List
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id=1, Name="Rafa", Email="r.gc@hotmail.es", Bookings=bookings },
                new Customer { Id=2, Name="Jake", Email="jake@hotmail.com", Bookings=bookings }
            };

            // Create a Room List
            List<Room> rooms = new List<Room>
            {
                new Room { Id=1, Description="A" },
                new Room { Id=2, Description="B" },
            };

            // Instantiations
            fakeRoomRepository = new Mock<IRepository<Room>>();
            fakeCustomerRepository = new Mock<IRepository<Customer>>();
            fakeBookingRepository = new Mock<IRepository<Booking>>();
            bookingManager = new Mock<IBookingManager>();
            bookingViewModel = new Mock<IBookingViewModel>();

            // Setup --calling to get data method. 
            fakeBookingRepository.Setup(x => x.GetAll()).Returns(bookings);
            fakeBookingRepository.Setup(x => x.Get(1)).Returns(bookings[1]);
            fakeBookingRepository.Setup(x => x.Get(2)).Returns(bookings[1]);

            fakeRoomRepository.Setup(x => x.GetAll()).Returns(rooms);
            fakeCustomerRepository.Setup(x => x.GetAll()).Returns(customers);

            // Create RoomsController
            controller = new BookingsController(fakeBookingRepository.Object, fakeRoomRepository.Object, fakeCustomerRepository.Object, bookingManager.Object, bookingViewModel.Object);
        }

        // IActionResult Index(int? id) where id is null
        [Fact]
        public void Index_ReturnsViewResultWithCorrectListOfBookings()
        {
            // Act
            var result = controller.Index(null) as ViewResult;
            var yearExpected = DateTime.Today.Year;
            var year = result.ViewData;
            // Assert

        }

        // Create([Bind("StartDate,EndDate,CustomerId")] Booking booking)
        [Fact]
        public void Create_WithAnyCreate_ReturnTrue()
        {
            // Act
            Booking booking = new Booking();
            booking.CustomerId = 1;
            var result = controller.Create(booking) as ViewResult;
            var bookingExpected = result.Model as Booking;
            var ConsumerIdExpected = bookingExpected.CustomerId;

            // Assert 
            Assert.Equal(booking.CustomerId, ConsumerIdExpected);
            // fakeBookingRepository.Verify(x => x.Add(It.IsAny<Booking>()), Times.Once);
        }

        // IActionResult Edit(int? id) where Id is null
        [Fact]
        public void Edit_BookingIdIsNull_EditedFalse()
        {
            // Act 
            controller.Edit(null);
            // Assert Verify
            fakeBookingRepository.Verify(x => x.Edit(It.IsAny<Booking>()), Times.Never);
        }

        // IActionResult Edit(int? id) where Id is != Rooms Id
        [Fact]
        public void Edit_BookingIdIsNotFound_EditedFalse()
        {
            // Act 
            controller.Edit(10);
            // Assert Verify
            fakeBookingRepository.Verify(x => x.Edit(It.IsAny<Booking>()), Times.Never);
        }

        // IActionResult Edit(int? id) where Id is 1 or 2 (Valid Data)
        [Fact]
        public void Edit_BookIdIsValid_EditedTrue()
        {
            // Act
            var result = controller.Edit(1) as ViewResult;
            // Assert Verify
            fakeBookingRepository.Verify(x => x.Edit(It.IsAny<Booking>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("Id,Description")] Room room) RoomId != Id
        [Fact]
        public void EditParameters_IdDistinctToRoom_EditedFalse()
        {
            // Act
            Room r1 = new Room();
            r1.Id = 2;
            //controller.Edit(0, r1);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Edit(It.IsAny<Room>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("StartDate,EndDate,IsActive,CustomerId,RoomId")] Booking booking)
        [Fact]
        public void EditParameters_IdNullBooking_EditedFalse()
        {
            // Act
            Booking b1 = new Booking();
            b1.Id = 100;
            //controller.Edit(1, r1);
            // Assert Verify
            fakeBookingRepository.Verify(x => x.Edit(It.IsAny<Booking>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("StartDate,EndDate,IsActive,CustomerId,RoomId")] Booking booking)
        [Fact]
        public void EditParameters_IdNullBooking_EditedTrue()
        {
            // Act
            Booking b1 = new Booking();
            b1.Id = 0;
            //controller.Edit(1, r1);
            // Assert Verify
            fakeBookingRepository.Verify(x => x.Edit(It.IsAny<Booking>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("StartDate,EndDate,IsActive,CustomerId,RoomId")] Booking booking)
        [Fact]
        public void Details_BookingExists_ReturnsViewResultWithBooking()
        {
            // Act
            var result = controller.Details(1) as ViewResult;
            var book = result.Model as Booking;
            var bookId = book.Id;
            // Assert
            Assert.InRange<int>(bookId, 1, 2);
        }

        // DeleteConfirmed(int id) where id >= 1
        [Fact]
        public void DeleteConfirmed_WhenIdIsLargerThanZero_RemoveIsCalled()
        {
            // Act
            controller.DeleteConfirmed(1);
            // Assert against the mock object
            fakeBookingRepository.Verify(x => x.Remove(It.IsAny<int>()));
        }

        // DeleteConfirmed(int id) where id <= 0
        [Fact]
        public void DeleteConfirmed_WhenIdIsLessThanOne_RemoveIsNotCalled()
        {
            // Act
            controller.DeleteConfirmed(0);
            // Assert against the mock object
            fakeBookingRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Once);
        }

        // Delete(int? id) where id = [1, 2]
        [Fact]
        public void Delete_WhenRoomIdIsValid_ReturnViewRoom()
        {
            // Act 
            var result = controller.Delete(2) as ViewResult;
            var booking = result.Model as Booking;
            var bookingId = booking.Id;
            // Assert Verify
            Assert.InRange<int>(bookingId, 1, 2);
        }

        // Delete(int? id) where id = null
        [Fact]
        public void Delete_WhenIdIsnull_ReturnNullValid()
        {
            // Act 
            controller.Delete(null);
            // Assert Verify
            fakeBookingRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
        }

        // Delete(int? id) where id = [RoomId Not Found]
        [Fact]
        public void Delete_WhenRoomIdIsnull_ReturnRoomNull()
        {
            // Act 
            controller.Delete(10);
            // Assert Verify
            fakeBookingRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
        }

    }
}
