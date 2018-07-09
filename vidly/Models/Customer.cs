using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Customer
    {
        //properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }//this is a navigation property that allows us to navigate from one type to another in this case from customer to its membership type
        public byte MembershipTypeId { get; set; }
    }
}