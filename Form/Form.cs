using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Form
    {
        private int id { get; set; }
        private string name { get; set; }
        private int teacher { get; set; }
        public ObservableCollection<Question> questions = new ObservableCollection<Question>();

        public Form(int id, string name, int teacher)
        {
            this.id = id;
            this.name = name;
            this.teacher = teacher;
        }

        public Form New(Form form)
        {
            return form;
        }

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public void RemoveQuestion(Question question)
        {
            questions.Remove(question);
        }
    }
}
