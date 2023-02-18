using System.ComponentModel.DataAnnotations;

namespace LessonsBotDbProvider.ModelsDb
{
    public class WordBook
    {
        [Key]
        public Guid IdWord { get; set; }

        protected List<string> _questions;

        public string Questions
        {
            set
            {
                _questions = value.Split(';').ToList();
            }
            
            get
            {
                string data = "";

                foreach (var item in _questions)
                {
                    data += $"{item};";
                }

                return data;
            }
        }

        protected List<string> _answers;

        public string Answers
        {

            set
            {
                _answers = value.Split(';').ToList();
            }

            get
            {
                string data = "";

                foreach (var item in _answers)
                {
                    data += $"{item};";
                }

                return data;
            }
        }

        public WordBook()
        {
            _questions = new List<string>();
            _answers = new List<string>();
        }


    }
}
