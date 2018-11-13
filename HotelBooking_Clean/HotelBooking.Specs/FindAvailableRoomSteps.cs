using HotelBooking.BusinessLogic;
using HotelBooking.Models;
using HotelBooking.UnitTests.Fakes;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace HotelBooking.Specs
{

    [Binding]
    public class FindAvailableRoomSteps
    {

        // Declarations 
        private DateManager time;
        private FakeBookingRepository fbr;
        private FakeRoomRepository frr;
        Booking booking;
        BookingManager bookingManager;

        // Constructor
        public FindAvailableRoomSteps()
        {
            time = new DateManager();
            fbr = new FakeBookingRepository(time.DtStartParameter, time.DtEndParameter);
            frr = new FakeRoomRepository();
            bookingManager = new BookingManager(fbr, frr);
            booking = new Booking();
        }


        [Given(@"a starting date '(.*)'")]
        public void GivenAStartDate(string startDate)
        {
            booking.StartDate = DateTime.Parse(startDate);
        }
        
        [Given(@"a ending date '(.*)'")]
        public void GivenAEndDate(string endDate)
        {
            booking.EndDate = DateTime.Parse(endDate);
        }
        
        [When(@"We search for available room")]
        public void WhenWeSearchForAvailableRoom()
        {
            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be active bookings")]
        public void ThenTheResultShouldBeActiveBookings()
        {
            Assert.Equal(1, bookingManager.FindAvailableRoom(booking.StartDate, booking.EndDate));
        }
    }
}
