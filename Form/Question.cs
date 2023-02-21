using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Question
    {
        private int id { get; set; }
        private string content { get; set; }
        public ObservableCollection<Answer> answers = new ObservableCollection<Answer>();

        public Question(int id, string content)
        {
            this.id = id;
            this.content = content;
        }

        public void New(int formId, Question question)
        {

        }
    }
}
