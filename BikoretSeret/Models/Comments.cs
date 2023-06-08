using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Models
{
    public class Comments
    {
        public int id { get; set; }
        public string userName  { get ; set ; }
        public string comment   { get ; set ; }
        public int movieId { get ; set ; }
    }
}
