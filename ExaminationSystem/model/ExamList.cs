using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.model
{
    public  class ExamList
    {
        public int Q_id { get; set; }
        public string Q_body { get; set; }
        public string Ans_body { get; set; }


        //
        public string StudentAnswer { get; set; } = "0";
        public List<string> QAnswers { get; set; } = new List<string>();

    }
}
