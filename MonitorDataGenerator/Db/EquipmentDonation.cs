﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PCRApi.Models.Db
{
    public partial class EquipmentDonation
    {
        public long TeamLevel { get; set; }
        public long DonationNumOnce { get; set; }
        public long DonationNumDaily { get; set; }
        public long RequestNumOnce { get; set; }
    }
}
