using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TransEfficiencySuite.Models
{
    public class Sign
    {
        public string Classification { get; set; }
        public string Area { get; set; }
        public string DiamondOrientation { get; set; }
        public string Height { get; set; }
        public string SignType { get; set; }
    }
}