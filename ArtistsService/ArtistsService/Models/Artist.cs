﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistsService.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Score { get; set; }
    }
}