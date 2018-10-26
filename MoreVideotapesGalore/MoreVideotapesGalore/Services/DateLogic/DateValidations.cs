using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MoreVideotapesGalore.Services.DateLogic
{
    /*
     * The class DateValidations (DateValidations.cs)
     * compares the dates between the query strings from the URIs
     * and the borrow and return dates of tapes that have already been borrowed.
     * 
     * The class is used in user and videotape service when making the reports available for admins.
     */
    public class DateValidations
    {
        // Converts string to the DateTime type which will then be used for comparison.
        public DateTime convertToDateTime(string sDate)
        {
            DateTime dtDate = DateTime.ParseExact(sDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return dtDate;
        }


        // Checks if the date from query in URI is between borrow and return date of a tape or before borrow date if return date is null.
        public bool validateDate(string sBorrowDate, string sReturnDate, string sDateQuery)
        {
            DateTime dateQuery = convertToDateTime(sDateQuery);
            DateTime borrowDate = convertToDateTime(sBorrowDate);

            bool checkBeforeDate = borrowDate < dateQuery;
            bool checkEqualsDate = borrowDate == dateQuery;

            if (sReturnDate != null)
            {
                DateTime returnDate = convertToDateTime(sReturnDate);
                bool checkAfterDate = returnDate > dateQuery;

                return (checkBeforeDate || checkEqualsDate) && checkAfterDate;
            }

            return checkBeforeDate || checkEqualsDate;
        }


        // Checks if the date from query in URI is between borrow and return date 
        // of a tape or before borrow date if return date is null after duration from query. 
        public bool validateAfterDuration(string sBorrowDate, string sReturnDate, int duration)
        {
            DateTime borrowDate = convertToDateTime(sBorrowDate);
            DateTime dateWithDuration = borrowDate.AddDays(duration);

            if (sReturnDate != null)
            {
                DateTime returnDate = convertToDateTime(sReturnDate);

                bool checkTapeAfterDuration = validateDate(sBorrowDate, sReturnDate, dateWithDuration.ToString("yyyy-MM-dd"))
                                              && dateWithDuration < returnDate;

                return checkTapeAfterDuration;
            }

            else
            {
                string today = DateTime.Now.ToString("yyyy-MM-dd");
                bool checkTapeAfterDuration = validateDate(sBorrowDate, sReturnDate, dateWithDuration.ToString("yyyy-MM-dd"))
                                              && dateWithDuration < DateTime.Now;

                return checkTapeAfterDuration;
            }
        }
    }
}
