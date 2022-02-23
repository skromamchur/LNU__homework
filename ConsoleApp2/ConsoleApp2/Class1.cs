using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ConsoleApp2
{
    enum MarathonType { 
        Marathon,
        Half_marathon 
    }
    internal class Runner
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public DateTime Date { get; set; }

        public string PhoneNumber { get; set; }

        public TimeSpan BestResult { get; set; }
       
        public MarathonType MarathonType { get; set; }

        public DateTime CompetitionDate { get; set; }

    }
}
