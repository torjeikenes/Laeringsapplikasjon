using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Læringsapplikasjon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<QuizData> quizList = new List<QuizData>();

        int currentQuizNr;
        int correctAnswers;
        string rootDir = @"C:\Users\torje\Documents\Kurs\";
        string courseName = "Test";
        string soundFile;

        private void Form1_Load(object sender, EventArgs e)
        {
            quizList.Add(new QuizData("What are frogs?", new string[] { "frog", "test", "ting", "frosk" }, "frog", "frosk.png", "frog.wav"));
            quizList.Add(new QuizData("Hvilket svar er Riktig?", new string[] { "Riktig", "test", "ting", "frosk" }, "Riktig"));
            LoadQuestion(0);
        }

        #region quiz
        private void LoadQuestion(int qstNr)
        {
            if (qstNr < quizList.Count)
            {
                QuizData qu = quizList[qstNr];
                quizText.Text = qu.Question;
                qst1.Text = qu.Answers[0];
                qst2.Text = qu.Answers[1];
                qst3.Text = qu.Answers[2];
                qst4.Text = qu.Answers[3];

                if (qu.Photo != null)
                {
                    quizPict.Visible = true;
                    quizPict.Load(rootDir + courseName + "\\" + qu.Photo);
                }
                else
                    quizPict.Visible = false;

                if (qu.Audio != null)
                {
                    quizAudioBt.Visible = true;
                    soundFile = qu.Audio;
                }
                else
                    quizAudioBt.Visible = false;
            }
        }

        private string getAnswer()
        {
            string ans = "";
            foreach (RadioButton b in Controls.OfType<RadioButton>())
            {
                if (b.Checked)
                {
                    ans = b.Text;
                }
            }
            return ans;
        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            if (quizList[currentQuizNr].CheckAnswer(getAnswer()))
                correctAnswers++;

            currentQuizNr++;
            LoadQuestion(currentQuizNr);
        }
        #endregion

        private void quizAudioBt_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(rootDir + courseName + "\\" + soundFile);
            sound.Play();
        }
    }
}
