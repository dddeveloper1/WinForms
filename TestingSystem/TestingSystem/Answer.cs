using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    [Serializable]
    public class Answer
    {
        public string Ans { get; set; }
        public bool check { get; set; }

        public override string ToString()
        {
            return $"{Ans}";
        }
    }
}
