using HotelBooking.BusinessLogic;
using HotelBooking.Models;
using System;
using TechTalk.SpecFlow;
using HotelBooking.UnitTests.Fakes;
using Xunit;

namespace HotelBooking.Specs
{
    [Binding]
    public class CreateBookingSteps
    {
        // Declarations 
        private DateManager time;
        private FakeBookingRepository fbr;
        private FakeRoomRepository frr;
        Booking booking;
        BookingManager bookingManager;

        // Constructor
        public CreateBookingSteps()
        {
            time = new DateManager();
            fbr = new FakeBookingRepository(time.DtStartParameter, time.DtEndParameter);
            frr = new FakeRoomRepository();
            bookingManager = new BookingManager(fbr, frr);
            booking = new Booking();
        }

        [Given(@"a Start Date '(.*)'")]
        public void GivenAStartDate(string startDate)
        {
            booking.StartDate = DateTime.Parse(startDate);
        }
        
        [Given(@"a End Date '(.*)'")]
        public void GivenAEndDate(string endDate)
        {
            booking.EndDate = DateTime.Parse(endDate);
        }
        
        [When(@"We created a Booking")]
        public void WhenWeCreatedABooking()
        {
            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be created the booking \(True\)")]
        public void ThenTheResultShouldBeCreatedTheBookingTrue()
        {
            Assert.True(bookingManager.CreateBooking(booking));
        }
    }
}
