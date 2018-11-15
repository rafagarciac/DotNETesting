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
    public class RoomControllerTest
    {
        private RoomsController controller;
        private Mock<IRepository<Room>> fakeRoomRepository;

        // Constructor
        public RoomControllerTest()
        {
            var rooms = new List<Room>
            {
                new Room { Id=1, Description="A" },
                new Room { Id=2, Description="B" },
            };

            // Create fake RoomRepository
            fakeRoomRepository = new Mock<IRepository<Room>>();
            
            // Implement fake GetAll() method.
            fakeRoomRepository.Setup(x => x.GetAll()).Returns(rooms);

            // Implement fake Get() method.
            fakeRoomRepository.Setup(x => x.Get(1)).Returns(rooms[1]);
            fakeRoomRepository.Setup(x => x.Get(2)).Returns(rooms[1]);

            // Create RoomsController
            controller = new RoomsController(fakeRoomRepository.Object);
        }

        // IActionResult Index()
        [Fact]
        public void Index_ReturnsViewResultWithCorrectListOfRooms()
        {
            // Act
            var result = controller.Index() as ViewResult;
            var roomsList = result.Model as IList<Room>;
            var noOfRooms = roomsList.Count;
            // Assert
            Assert.Equal(2, noOfRooms);
        }

        // Create([Bind("Id,Description")] Room room)
        [Fact]
        public void Create_WithAnyCreate_ReturnTrue()
        {
            // Act
            controller.Create(It.IsAny<Room>());

            // Assert Id Room
            fakeRoomRepository.Verify(x => x.Add(It.IsAny<Room>()), Times.Once);
        }

        // IActionResult Edit(int? id) where Id is null
        [Fact]
        public void Edit_RoomIdIsNull_EditedFalse()
        {
            // Act 
            controller.Edit(null);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Edit(It.IsAny<Room>()), Times.Never);
        }

        // IActionResult Edit(int? id) where Id is != Rooms Id
        [Fact]
        public void Edit_RoomIdIsNotFound_EditedFalse()
        {
            // Act 
            controller.Edit(10);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Edit(It.IsAny<Room>()), Times.Never);
        }

        // IActionResult Edit(int? id) where Id is 1 or 2 (Valid Data)
        [Fact]
        public void Edit_RoomIdIsValis_EditedTrue()
        {   
            // Act 
            var result = controller.Edit(1) as ViewResult;
            var room = result.Model as Room;
            var roomId = room.Id;
            // Assert Verify
            Assert.InRange<int>(roomId, 1, 2);
        }

        // IActionResult Edit(int id, [Bind("Id,Description")] Room room) RoomId != Id
        [Fact]
        public void EditParameters_IdDistinctToRoom_EditedFalse()
        {
            // Act
            Room r1 = new Room();
            r1.Id = 2;
            controller.Edit(0, r1);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Edit(It.IsAny<Room>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("Id,Description")] Room room) RoomId = null
        [Fact]
        public void EditParameters_IdNullRoom_EditedFalse()
        {
            // Act
            Room r1 = new Room();
            r1.Id = 100;
            controller.Edit(1, r1);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Edit(It.IsAny<Room>()), Times.Never);
        }

        // IActionResult Edit(int id, [Bind("Id,Description")] Room room)
        [Fact]
        public void EditParameters_IdNullRoom_EditedTrue()
        {
            // Act
            Room r1 = new Room();
            r1.Id = 1;
            controller.Edit(1, r1);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Edit(It.IsAny<Room>()), Times.Once);
        }

        // IActionResult Details(int? id)
        [Fact]
        public void Details_RoomExists_ReturnsViewResultWithRoom()
        {
            // Act
            var result = controller.Details(2) as ViewResult;
            var room = result.Model as Room;
            var roomId = room.Id;
            // Assert
            Assert.InRange<int>(roomId, 1, 2);
        }

        // DeleteConfirmed(int id) where id >= 1
        [Fact]
        public void DeleteConfirmed_WhenIdIsLargerThanZero_RemoveIsCalled()
        {
            // Act
            controller.DeleteConfirmed(1);
            // Assert against the mock object
            fakeRoomRepository.Verify(x => x.Remove(It.IsAny<int>()));
        }

        // DeleteConfirmed(int id) where id <= 0
        [Fact]
        public void DeleteConfirmed_WhenIdIsLessThanOne_RemoveIsNotCalled()
        {
            // Act
            controller.DeleteConfirmed(0);
            // Assert against the mock object
            fakeRoomRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
        }

        // Delete(int? id) where id = [1, 2]
        [Fact]
        public void Delete_WhenRoomIdIsValid_ReturnViewRoom()
        {
            // Act 
            var result = controller.Delete(2) as ViewResult;
            var room = result.Model as Room;
            var roomId = room.Id;
            // Assert Verify
            Assert.InRange<int>(roomId, 1, 2);
        }

        // Delete(int? id) where id = null
        [Fact]
        public void Delete_WhenIdIsnull_ReturnNullValid()
        {
            // Act 
            controller.Delete(null);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
        }

        // Delete(int? id) where id = [RoomId Not Found]
        [Fact]
        public void Delete_WhenRoomIdIsnull_ReturnRoomNull()
        {
            // Act 
            controller.Delete(10);
            // Assert Verify
            fakeRoomRepository.Verify(x => x.Remove(It.IsAny<int>()), Times.Never());
        }
    }
}