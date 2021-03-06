﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PointControl
{
    public struct Team
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("TeamName")]
        public string TeamName { get; set; }
        [JsonProperty("Point")]
        public int Point { get; set; }
        [JsonProperty("PointOnSystem")]
        public int PointOnSystem { get; set; }
    }
}
