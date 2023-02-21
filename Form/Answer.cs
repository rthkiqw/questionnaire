using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    public class Answer
    {
        private int id { get; set; }
        private int type { get; set; }
        private string content { get; set; }

        public Answer(int id, int type, string content)
        {
            this.id = id;
            this.type = type;
            this.content = content;
        }

        public void New(int formId, Answer answer)
        {

        }
    }
}
