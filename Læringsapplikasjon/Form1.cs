using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;

namespace Læringsapplikasjon
{
    public partial class Laeringsspill : Form
    {
        public Laeringsspill()
        {
            InitializeComponent();
        }

        private List<QuizData> quizList = new List<QuizData>();

        int currentQuizNr;
        int correctAnswers;
        string rootDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Kurs\";
        string courseName = "Test";
        string soundFile;
        List<string> dirs = new List<string>();
        List<string> games = new List<string>();

        private void Laeringsspill_Load(object sender, EventArgs e)
        {
            folderGame.SelectedPath = rootDir;
            LoadFolders(rootDir);
            /*
            quizList.Add(new QuizData("What are frogs?", new string[] { "frog", "test", "ting", "frosk" }, "frog", "frosk.png", "frog.wav"));
            quizList.Add(new QuizData("Hvilket svar er Riktig?", new string[] { "Riktig", "test", "ting", "frosk" }, "Riktig"));
            LoadQuestion(0);*/
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
            else
            {
                compQuizText.Text = "Du fikk " + Convert.ToString(correctAnswers) + " riktige svar";
                compQuizP.Dock = DockStyle.Fill;
            }
        }

        private string getAnswer()
        {
            /*
            string ans = "";
            Console.WriteLine(Controls.OfType<RadioButton>());
            foreach (RadioButton b in Controls.OfType<RadioButton>())
            {
                Console.WriteLine("heihei");
                if (b.Checked)
                {
                    ans = b.Text;
                }
            }
            return ans;
            */

            RadioButton correct = quizPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (correct != null)
                return correct.Text;
            else
                return "";
        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            Console.WriteLine(getAnswer());
            if (quizList[currentQuizNr].CheckAnswer(getAnswer()))
                correctAnswers++;

            currentQuizNr++;
            LoadQuestion(currentQuizNr);

            foreach (RadioButton b in quizPanel.Controls.OfType<RadioButton>())
            {
                b.Checked = false;
            }
        }
        #endregion

        private void quizAudioBt_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(rootDir + courseName + "\\" + soundFile);
            sound.Play();
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            folderGame.ShowDialog();
            rootDir = folderGame.SelectedPath + "\\";
            LoadFolders(rootDir);
            //Console.WriteLine(folderGame.SelectedPath);
        }

        private void LoadFolders(string d)
        {
            if (dirs != null)
                dirs.Clear();
            if (games != null)
                games.Clear();
            if (listGames.Items != null)
                listGames.Items.Clear();

            string[] dir = Directory.GetDirectories(d);

            for (int i = 0; i < dir.Length; i++)
            {
                dirs.Add(dir[i]);
                dir[i] = dir[i].Replace(rootDir, "");
                listGames.Items.Add(dir[i]);
                games.Add(dir[i]);
                
            }

            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (listGames.Text != "")
                Console.WriteLine(listGames.Text);
        }

        private void ReadJSON(string d, string f)
        {
            string jFile = d + "\\" + f + ".json";

            if (!File.Exists(jFile))
            {

            }
            else
            {
                string json = File.ReadAllText(jFile);
                JObject game = JObject.Parse(json);

                IList<JToken> quizList = game["quiz"].Children().ToList();
            }
            
        }
    }
}
