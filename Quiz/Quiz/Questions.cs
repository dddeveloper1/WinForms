using System;
using System.Collections.Generic;

namespace Quiz
{
    [Serializable]
    public class Questions
    {
        public string Question { get; set; }
        public List<Answer> answers = new List<Answer>();
        public bool check { get; set; } = false;
    
    }
}
