﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class PaymentStatus
    {
        [Key]
        public long PaymentStatusID { get; set; }
        public string Status { get; set; }
    }
}
