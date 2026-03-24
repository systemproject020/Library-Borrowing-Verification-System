using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Borrowing_Verification_System
{
    public class BorrowRecord
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public string Status
        {
            get
            {
                return ReturnDate == null ? "Not Returned" : "Returned";
            }
        }
    }
}