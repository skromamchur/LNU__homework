using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Task1
{
    enum MarathonType { 
        Marathon,
        Half_marathon 
    }
    internal class Runner
    {
        public Runner(int id)
        {
            this.setId(id);
        }
        
        public int id { get;private set; }

        public void setId(int id) {
           
            if(Validation.isPositive(id))
            {
                this.id = id;
            }
        }
        public string name { get; set; }
        public DateTime Date { get; set; }

        public string PhoneNumber { get; set; }

        public TimeSpan BestResult { get; set; }
       
        public MarathonType MarathonType { get; set; }

        public DateTime CompetitionDate { get; set; }
    }
}
