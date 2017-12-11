using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIfionDevCaseStudyAlgorithum_GG
{
    class Program
    {
        static void Main(string[] args)
        {
            //The given invoice and subscriber list
            List<Invoice> invoiceList = new List<Invoice>();
            List<Subscriber> subList = new List<Subscriber>();

            // Performs the search and assigns it to the PastDueList object to be printed to the console
            List<Subscriber> pastDueList = PastDueSearch(invoiceList, subList);
            pastDueList.ForEach(Console.WriteLine);
        }

        public static List<Subscriber> PastDueSearch(List<Invoice> invoiceList, List<Subscriber> subList )
        {

            List<Subscriber> pastDueCount = new List<Subscriber>();

            // For Each invoice. Check if the invoice status is "PastDue". 
            // If "PastDue" search for the subscriber and add that subscriber to the pastDueCount list
            foreach (var item in invoiceList)
            {
                if (item.currentStatus == "PastDue")
                {
                    var pastDue = subList.Where(a => a.userID == item.userID).ToList();
                    pastDueCount.AddRange(pastDue);
                }
            }
            return pastDueCount;            
        }
    }
}
