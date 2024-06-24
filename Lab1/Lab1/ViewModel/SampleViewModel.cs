using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.ViewModel
{
    public class SampleViewModel
    {
        public List<Player> Player { get; set; }
        public List<Staff> Staff { get; set; }
        public Stadium Stadium { get; set; }
    }
}