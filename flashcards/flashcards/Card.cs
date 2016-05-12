using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashcards
{
    public class Card
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public long ProgressID { get; set; }
        public long Level { get; set; }
    
        public Card(string Question, string Answer, long ProgressID, long Level)
        {
            this.Question = Question;
            this.Answer = Answer;
            this.ProgressID = ProgressID;
            this.Level = Level;
        }
    
        public Card()
        {

        }
    }
}
