using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class LearnViewModel
    {
        public double LearnFactor { get; set; }
        public int Epoch { get; set; }
        public int LearnProgressMax { get; set; }
        public int LearnProgress { get; set; }
    }
}
