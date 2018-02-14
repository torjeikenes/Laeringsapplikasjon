using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Læringsapplikasjon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<QuizData> quizList = new List<QuizData>();

        private void Form1_Load(object sender, EventArgs e)
        {
            quizList.Add(new QuizData("What are frogs?", new string[] { "frog", "test", "ting", "frosk" }, "frog"));


        }



        private void LoadQuestion(int qstNr)
        {
            quizText.Text = quizList[qstNr].Question;
            qst1.Text = quizList[qstNr].Answers[0];
            qst2.Text = quizList[qstNr].Answers[1];
            qst3.Text = quizList[qstNr].Answers[2];
            qst4.Text = quizList[qstNr].Answers[3];

        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            LoadQuestion(0);

        }

    }
}
