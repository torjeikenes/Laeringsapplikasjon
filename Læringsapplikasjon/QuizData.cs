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

        public QuizData(string q, string[] a, string au, string c, bool isPict)
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
    }
}
