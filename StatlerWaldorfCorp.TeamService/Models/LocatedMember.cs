﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StatlerWaldorfCorp.TeamService.Models
{
    public class LocatedMember : Member
    {
        public LocationRecord LastLocation { get; set; }
    }
}
