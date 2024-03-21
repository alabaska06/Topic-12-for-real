using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_12_for_real
{
    public class EventScore
    {
        public string Name { get; set; }
        public string Event { get; set; }
        private List<double> Scores { get; set; }

        public EventScore(string name, string eventName, List<double> scores)
        {
            Name = name;
            Event = eventName;
            Scores = scores;
        }


        
      

        public double Total
        {
            get { return Scores.Sum(); }
        }

        
        public double Average
        {
            get {  return Scores.Average(); }
        }
        
        public override string ToString()
        {
            return $"{Name} - {Event}: Total Score: {Total}, Average Score: {Average}";
        }

        public int CompareTo(EventScore other)
        {
            return Total.CompareTo(other.Total);
        }
        
    }
}

