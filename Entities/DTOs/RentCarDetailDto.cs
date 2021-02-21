﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentCarDetailDto : IDto
    {
        public int RentId { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string CompanyName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
