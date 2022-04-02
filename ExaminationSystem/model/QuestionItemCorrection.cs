using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.model
{
    public  class QuestionItemCorrection
    {
        public ExamList Question { get; set; }
        public List<String> answers { get; set; } = new List<String>();
        public string StudentAnswer { get; set; }
    }
}
