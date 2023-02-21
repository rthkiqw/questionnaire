using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class StudentAnswer
    {
        private int id { get; set; }
        private int student { get; set; }
        private int form { get; set; }
        private int question { get; set; }
        private DateTime date { get; set; }

        public StudentAnswer(int id, int student, int form, int question, DateTime date)
        {
            this.id = id;
            this.student = student;
            this.form = form;
            this.question = question;
            this.date = date;
        }

        public void New(StudentAnswer studentAnswer)
        {

        }
    }
}
