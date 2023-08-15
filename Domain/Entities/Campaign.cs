﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Campaign: BaseEntity
    {
        public string Title { get; set; }
        public string Desription { get; set; }
        public decimal GoalAmount { get; set; }
        public decimal CurrentAmountRaised { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public ICollection<Donation>? Donations { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
