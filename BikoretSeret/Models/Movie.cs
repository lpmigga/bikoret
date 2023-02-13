using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Models
{
    public class Movie
    {
        public int ID { get; set ; }
        public string name { get; set; }
        public string category { get; set; }
        public string summery { get; set; }
        public byte[] ImageData { get; set; }

    }
}
