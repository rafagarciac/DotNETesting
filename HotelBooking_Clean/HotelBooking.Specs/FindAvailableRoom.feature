Feature: FindAvailableRoom
	We given a StartDate and EndDate
	In order to find available rooms
	In our Hotel Booking

@available @rooms
Scenario Outline: Find Available Room
	Given a starting date <sd> 
	And a ending date <ed>
	When We search for available room
	Then the result should be active bookings

	# This dates are static but the Business Logic works with dinamic dates,
	# So if the test will not executed sucessfullly then you should change the dates.
	# Using the DateManager class --
    Examples:
	| sd			| ed		   | 
	| '2018-11-14'  | '2018-11-16' |	# True
	| '2018-11-20'  | '2018-11-25' |	# True
	| '2018-11-03'  | '2018-11-15' |	# False - Proposal Error Test