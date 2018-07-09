﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    //this class will represent the MembershipType property in Customer class and linked with this id.
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}