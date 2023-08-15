﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CampaignResponsetDto
    {
        public string Title { get; set; }
        public string Desription { get; set; }
        public decimal GoalAmount { get; set; }
        public decimal CurrentAmountRaised { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
