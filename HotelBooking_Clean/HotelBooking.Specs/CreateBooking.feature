Feature: CreateBooking
	We want to create a booking given
	A startDate and endDate for create a Booking object
	And check if there are any past booking

@created @booking
Scenario Outline: Create a Booking
	Given a Start Date <startDate> 
	And a End Date <endDate>
	When We created a Booking
	Then the result should be created the booking (True)

	# This dates are static but the Business Logic works with dinamic dates,
	# So if the test will not executed sucessfullly then you should change the dates.
	# Using the DateManager class --
	Examples: 
	| startDate		| endDate      | 
	| '2018-11-14'  | '2018-11-18' |	# True
	| '2018-11-20'  | '2018-11-25' |	# True
	| '2018-11-13'  | '2019-11-15' |	# Error - because the dates there are out-range