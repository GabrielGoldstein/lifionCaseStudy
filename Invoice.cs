using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIfionDevCaseStudyAlgorithum_GG
{
    // Definition of the Invoice object
    class Invoice
    {
        public Guid invoiceID;
        public Guid userID;        
        public string currentStatus; // currentStatus posible values are "In-Progress", "Closed", "PastDue", etc.
 
        public Invoice()
        {

        }
        
    }
}
