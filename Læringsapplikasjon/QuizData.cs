using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Læringsapplikasjon
{
    class QuizData
    {
        private string question;
        private string photo;
        private string audio;
        private string[] answers;
        private string correct;


        #region konstruktor
        public QuizData(string q, string[] a, string c, string p, string au)
        {
            question = q;
            answers = a;
            correct = c;
            photo = p;
            audio = au;
        }

        public QuizData(string q, string[] a, string c,string p)
        {
            question = q;
            answers = a;
            correct = c;
            photo = p;
        }

        public QuizData(string q, string[] a, string c,  string au, bool isPict)
        {
            question = q;
            answers = a;
            correct = c;
            audio = au;
        }

        public QuizData(string q, string[] a, string c)
        {
            question = q;
            answers = a;
            correct = c;
        }
        #endregion

        #region set_get_metoder
        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string[] Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }


        #endregion

        public bool CheckAnswer(string answer)
        {
            if (answer == correct)
                return true;
            else
                return false;

        }
    }
}
