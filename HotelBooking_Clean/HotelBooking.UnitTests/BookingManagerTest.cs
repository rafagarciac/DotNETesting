using HotelBooking.BusinessLogic;
using HotelBooking.Models;
using HotelBooking.UnitTests.Fakes;
using System;
using System.Collections.Generic;
using Xunit;

namespace HotelBooking.UnitTests
{
    public class BookingManagerTest
    {
        // Declarations

        private DateManager time;
        private FakeBookingRepository fbr;
        private FakeRoomRepository frr;
        private BookingManager bm;

        // Constructor by Default
        public BookingManagerTest()
        {
            time = new DateManager();
            fbr = new FakeBookingRepository(time.DtStartParameter, time.DtEndParameter);
            frr = new FakeRoomRepository();
            bm = new BookingManager(fbr, frr);
        }

        //  **************************************************************************************************
        //  *************************   B O O K I N G   M A N A G E R   -  T E S T S ************************* 
        //  **************************************************************************************************

        [Fact]
        public void TestCreateBooking_ReturnTrueCreated()
        {

            // Create a Booking Object & Assign the Start and End date
            Booking book = new Booking();
            book.StartDate = time.DtS;
            book.EndDate = time.DtE;

            // Test
            Assert.True(bm.CreateBooking(book));

        }

        [Fact]
        public void TestGetFullyOccupiedDates_ReturnDateTimeList_CompareList()
        {
            // It should return a Empty ListDateTime.
            List<DateTime> listDT = bm.GetFullyOccupiedDates(time.DtS, time.DtE);
            // Is Empty ? -> True / False
            Assert.Empty(listDT);
        }
    }
}

        //  ********************************************************************************************************
        //  *************************   B O O K I N G   R E P O S I T O R Y   -  T E S T S ************************* 
        //  ********************************************************************************************************


        //[Fact]
        //public void TestFakeBooking_AddMethod_returnTrue()
        //{
        //    Assert.False(fbr.addWasCalled);
        //    Booking book = new Booking();
        //    fbr.Add(book);
        //    Assert.True(fbr.addWasCalled);

        //}


        //[Fact]
        //public void TestFakeBooking_EditMethod_returnTrue()
        //{
        //    Assert.False(fbr.editWasCalled);
        //    Booking book = new Booking();
        //    fbr.Edit(book);
        //    Assert.True(fbr.editWasCalled);

        //}

        //[Fact]
        //public void TestFakeBooking_RemoveMethod_returnTrue()
        //{
        //    Assert.False(fbr.removeWasCalled);
        //    fbr.Remove(1);
        //    Assert.True(fbr.removeWasCalled);

        //}

        //[Fact]
        //public void TestFakeBooking_GetMethod_CompareObject()
        //{
        //    Booking bookExpected = new Booking();
        //    Booking bookActual = fbr.Get(1);

        //    AssignValuesToBooking(ref bookExpected, 1, time.DtStartParameter, time.DtEndParameter, true, 1, 1);
        //    CompareTwoBookingsByAtribbutes(bookExpected, bookActual);

        //}

        //private void AssignValuesToBooking(ref Booking book, int id, DateTime dtStart, DateTime dtEnd, bool active, int customerId, int roomId)
        //{
        //    book.Id = id;
        //    book.StartDate = dtStart;
        //    book.EndDate = dtEnd;
        //    book.IsActive = active;
        //    book.CustomerId = customerId;
        //    book.RoomId = roomId;
        //}

        //private void CompareTwoBookingsByAtribbutes(Booking bookExpected, Booking bookActual)
        //{
        //    // Is not possible the Object's comparasion in the Assert.Equal() method
        //    // Assert.Equal(bookExpected, bookActual)
        //    Assert.Equal(bookExpected.IsActive, bookActual.IsActive);
        //    Assert.Equal(bookExpected.Id, bookActual.Id);
        //    Assert.Equal(bookExpected.StartDate, bookActual.StartDate);
        //    Assert.Equal(bookExpected.EndDate, bookActual.EndDate);
        //    Assert.Equal(bookExpected.CustomerId, bookActual.CustomerId);
        //    Assert.Equal(bookExpected.RoomId, bookActual.RoomId);
        //}

        //[Fact]
        //public void TestFakeBooking_GetAllMethod_CompareList()
        //{
        //    // Create a new List of Bookings
        //    List<Booking> bookings = new List<Booking>
        //    {
        //        new Booking { Id=1, StartDate=time.DtStartParameter, EndDate=time.DtEndParameter, IsActive=true, CustomerId=1, RoomId=1 },
        //        new Booking { Id=2, StartDate=time.DtStartParameter, EndDate=time.DtEndParameter, IsActive=true, CustomerId=2, RoomId=2 },
        //    };

        //    // Get the List from GetAll() method
        //    List<Booking> bookingsActual = (List<Booking>)fbr.GetAll();

        //    for (int i = 0; i < bookings.Count; i++)
        //    {
        //        Booking bookExpected = bookings[i];
        //        Booking bookActual = bookingsActual[i];
        //        CompareTwoBookingsByAtribbutes(bookExpected, bookActual);
        //    }
        //}

        //  **************************************************************************************************
        //  *************************   R O O M   R E P O S I T O R Y   -  T E S T S ************************* 
        //  **************************************************************************************************

        //    [Fact]
        //    public void TestFakeRoom_AddMethod_returnTrue()
        //    {
        //        Assert.False(frr.addWasCalled);
        //        Room room = new Room();
        //        frr.Add(room);
        //        Assert.True(frr.addWasCalled);

        //    }

        //    [Fact]
        //    public void TestFakeRoom_EditMethod_returnTrue()
        //    {
        //        Assert.False(frr.editWasCalled);
        //        Room room = new Room();
        //        frr.Edit(room);
        //        Assert.True(frr.editWasCalled);

        //    }

        //    [Fact]
        //    public void TestFakeRoom_RemoveMethod_returnTrue()
        //    {
        //        Assert.False(frr.removeWasCalled);
        //        Room room = new Room();
        //        frr.Remove(1);
        //        Assert.True(frr.removeWasCalled);

        //    }

        //    [Fact]
        //    public void TestFakeRoom_GetMethod_CompareObject()
        //    {
        //        Room roomExpected = new Room();
        //        Room roomActual = frr.Get(1);

        //        AssignValuesToRoom(ref roomExpected, 1, "A");
        //        CompareTwoRoomsByAttributes(roomExpected, roomActual);
        //    }


        //    private void AssignValuesToRoom(ref Room room, int id, string description)
        //    {
        //        room.Id = id;
        //        room.Description = description;
        //    }

        //    private void CompareTwoRoomsByAttributes(Room roomExpected, Room roomActual)
        //    {
        //        Assert.Equal(roomExpected.Id, roomActual.Id);
        //        Assert.Equal(roomExpected.Description, roomActual.Description);
        //    }

        //    [Fact]
        //    public void TestFakeRoom_GetAllMethod_CompareList()
        //    {
        //        // Create a new List with two Rooms 
        //        List<Room> rooms = new List<Room>
        //        {
        //            new Room { Id=1, Description="A" },
        //            new Room { Id=2, Description="B" },
        //        };

        //        // Get the List that return the GetAll() method
        //        List<Room> roomsActual = (List<Room>)frr.GetAll();

        //        for (int i = 0; i < rooms.Count; i++)
        //        {
        //            Room roomExpected = rooms[i];
        //            Room roomActual = roomsActual[i];
        //            CompareTwoRoomsByAttributes(roomExpected, roomActual);
        //        }
        //    }
        //}
     //}