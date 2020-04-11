﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TTrackerLibrary
{
    public class TeamModel
    {
        public string TeamName { get; set; }
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
