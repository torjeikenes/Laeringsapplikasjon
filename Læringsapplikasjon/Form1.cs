using System;
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
        private List<TeachData> teachList = new List<TeachData>();

        int currentQuizNr;
        int correctAnswers;
        string rootDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Kurs\";
        string courseName = "Test";
        string soundFile;
        string gameFile;
        string gameDir;

        List<string> dirs = new List<string>();
        List<string> games = new List<string>();

        private void Laeringsspill_Load(object sender, EventArgs e)
        {
            LoadPanel(startPanel);

            folderGame.SelectedPath = rootDir;
            LoadFolders(rootDir);
            /*
            quizList.Add(new QuizData("What are frogs?", new string[] { "frog", "test", "ting", "frosk" }, "frog", "frosk.png", "frog.wav"));
            quizList.Add(new QuizData("Hvilket svar er Riktig?", new string[] { "Riktig", "test", "ting", "frosk" }, "Riktig"));
            LoadQuestion(0);*/
        }

        private void LoadPanel(Panel pa)
        {
            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                p.Location = new Point(0, 0);
                p.Visible = false;
            }

            pa.Visible = true;

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

                if (qu.Photo != "")
                {
                    quizPict.Visible = true;
                    quizPict.Load(rootDir + courseName + "\\" + qu.Photo);
                }
                else
                    quizPict.Visible = false;

                if (qu.Audio != "")
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
                LoadPanel(compQuizP);
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

        private void quizAudioBt_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(gameDir + "\\" + soundFile);
            Console.WriteLine(gameDir + soundFile);
            sound.Play();
        }
        #endregion



        #region Load-funksjoner

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
            loadError.Text = "";
            if (listGames.Text != "")
            {
                gameFile = listGames.Text;
                gameDir = rootDir + gameFile + "\\";
                ReadJSON(gameDir, listGames.Text);
            }
            Console.WriteLine(listGames.Text);
            LoadQuestion(0);

            LoadPanel(quizPanel);
        }

        private void ReadJSON(string r, string f)
        {
            string jFile = r + f + ".json";

            Console.WriteLine(jFile);

            if (!File.Exists(jFile))
            {
                loadError.Text = "Mappen " + f + " mangler en .JSON fil!";
            }
            else
            {
                //
                // Kode for å hente ut data for teach-delen
                // 

                // Leser json-filen og putter den i en string
                string json = File.ReadAllText(jFile);
                Console.WriteLine(json);

                // Parser den over til et format json.net kan jobbe med
                JObject game = JObject.Parse(json);

                // Henter ut alle tittler med key "teach"
                var tTitles = from p in game["teach"] select (string)p["title"];

                // Gjør om titles til en vanlig liste for å telle antall læringskort det er
                List<string> s = new List<string>();
                foreach (var item in tTitles)
                {
                    s.Add(item);
                }

                // Lager teachData-objekter med data fra json-filen
                for (int i = 0; i < s.Count; i++)
                {
                    string tTitle = (string)game["teach"][i]["title"];
                    string tInfo = (string)game["teach"][i]["info"];
                    string tPhoto = (string)game["teach"][i]["photo"];
                    string tAudio = (string)game["teach"][i]["audio"];

                    teachList.Add(new TeachData(tTitle, tInfo, tPhoto, tAudio));
                    Console.WriteLine(tTitle + " : " + tInfo + " : " + tPhoto + " : " + tAudio);
                }

                //
                // Kode for å hente ut data for quiz-delen
                //

                // Henter ut alle tittler med key "teach"
                var Questions = from p in game["quiz"] select (string)p["question"];

                // Gjør om titles til en vanlig liste for å telle antall læringskort det er
                List<string> q = new List<string>();
                foreach (var item in Questions)
                {
                    q.Add(item);
                }

                // Lager teachData-objekter med data fra json-filen
                for (int i = 0; i < q.Count; i++)
                {
                    string question = (string)game["quiz"][i]["question"];

                    JArray answer = (JArray)game["quiz"][i]["answer"];
                    string[] answers = answer.Select(a => (string)a).ToArray();

                    string correct = (string)game["quiz"][i]["correct"];
                    string photo = (string)game["quiz"][i]["photo"];
                    string audio = (string)game["quiz"][i]["audio"];

                    quizList.Add(new QuizData(question, answers, correct, photo, audio));
                    //Console.WriteLine(question + " : " + answers + " : " + correct + " : " + photo + " : " + audio);
                    //Console.WriteLine(answers[0] + " : " + answers[1] + " : " + answers[2] + " : " + answers[3]);
                }

            }
            
        }
        #endregion
    }
}
