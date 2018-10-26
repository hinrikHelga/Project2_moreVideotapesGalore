using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MoreVideotapesGalore.Services.DateLogic
{
    public class DateValidations
    {
        public DateTime convertToDateTime(string sDate)
        {
            DateTime dtDate = DateTime.ParseExact(sDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return dtDate;
        }

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
