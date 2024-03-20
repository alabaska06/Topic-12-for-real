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

        public double GetTotalScore()
        {
            return Scores.Sum();
        }

        public double GetAverage()
        {
            return Scores.Average();
        }

        public override string ToString()
        {
            return $"{Name} - {Event}: Total Score: {GetTotalScore()}, Average Score: {GetAverage()}";
        }

        public int CompareTo(EventScore other)
        {
            return GetTotalScore().CompareTo(other.GetTotalScore());
        }
    }
}

