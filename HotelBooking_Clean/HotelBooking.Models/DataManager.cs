using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Models
{
    public class DateManager
    {
        /// <summary>
        /// dtStartParameter -> Takes the currently date and sum 2 months and 1 day
        /// dtEndParameter   -> Takes the currently date and sum 2 months and 8 days
        /// TOTAL -> dtEndParameter - dtStartParameter => 1 week
        ///
        /// dtS   -> Takes the currently date and sum 1 day
        /// dtEnd -> Takes the currently date and sum 8 days
        /// TOTAL -> dtE - dtS => 1 week
        /// </summary>

        // Declarations

        private DateTime dtStartParameter;
        private DateTime dtEndParameter;
        private DateTime dtS;
        private DateTime dtE;

        // Constructor

        public DateManager()
        {
            dtStartParameter = DateTime.Today.AddDays(1).AddMonths(2);
            dtEndParameter = DateTime.Today.AddDays(8).AddMonths(2);
            dtS = DateTime.Today.AddDays(1);
            dtE = DateTime.Today.AddDays(8);
        }

        // Getter & Setters

        public DateTime DtStartParameter
        {
            get { return dtStartParameter; }
            set { dtStartParameter = value; }
        }

        public DateTime DtEndParameter
        {
            get { return dtEndParameter; }
            set { dtEndParameter = value; }
        }

        public DateTime DtS
        {
            get { return dtS; }
            set { dtS = value; }
        }

        public DateTime DtE
        {
            get { return dtE; }
            set { dtE = value; }
        }
    }
}
