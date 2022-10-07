using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class TrainDataModel
    {
        public IEnumerable<int> Inputs { get; set; }
        public int Number { get; set; }

        public TrainDataModel()
        {
            Inputs = new List<int>();
        }
    }
}
