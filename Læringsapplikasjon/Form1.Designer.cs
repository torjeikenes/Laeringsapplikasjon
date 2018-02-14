namespace Læringsapplikasjon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quizPanel = new System.Windows.Forms.Panel();
            this.nextBt = new System.Windows.Forms.Button();
            this.qst4 = new System.Windows.Forms.RadioButton();
            this.qst3 = new System.Windows.Forms.RadioButton();
            this.qst2 = new System.Windows.Forms.RadioButton();
            this.qst1 = new System.Windows.Forms.RadioButton();
            this.quizAudioBt = new System.Windows.Forms.Button();
            this.quizPict = new System.Windows.Forms.PictureBox();
            this.quizText = new System.Windows.Forms.Label();
            this.teachPanel = new System.Windows.Forms.Panel();
            this.teachInfo = new System.Windows.Forms.Label();
            this.teachTilbakeBt = new System.Windows.Forms.Button();
            this.teachNesteBt = new System.Windows.Forms.Button();
            this.teachAudioBt = new System.Windows.Forms.Button();
            this.teachPict = new System.Windows.Forms.PictureBox();
            this.teachText = new System.Windows.Forms.Label();
            this.quizPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizPict)).BeginInit();
            this.teachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachPict)).BeginInit();
            this.SuspendLayout();
            // 
            // quizPanel
            // 
            this.quizPanel.Controls.Add(this.nextBt);
            this.quizPanel.Controls.Add(this.qst4);
            this.quizPanel.Controls.Add(this.qst3);
            this.quizPanel.Controls.Add(this.qst2);
            this.quizPanel.Controls.Add(this.qst1);
            this.quizPanel.Controls.Add(this.quizAudioBt);
            this.quizPanel.Controls.Add(this.quizPict);
            this.quizPanel.Controls.Add(this.quizText);
            this.quizPanel.Location = new System.Drawing.Point(54, 26);
            this.quizPanel.Name = "quizPanel";
            this.quizPanel.Size = new System.Drawing.Size(488, 404);
            this.quizPanel.TabIndex = 0;
            // 
            // nextBt
            // 
            this.nextBt.Location = new System.Drawing.Point(395, 355);
            this.nextBt.Name = "nextBt";
            this.nextBt.Size = new System.Drawing.Size(75, 23);
            this.nextBt.TabIndex = 7;
            this.nextBt.Text = "Neste";
            this.nextBt.UseVisualStyleBackColor = true;
            this.nextBt.Click += new System.EventHandler(this.nextBt_Click);
            // 
            // qst4
            // 
            this.qst4.AutoSize = true;
            this.qst4.Location = new System.Drawing.Point(63, 171);
            this.qst4.Name = "qst4";
            this.qst4.Size = new System.Drawing.Size(85, 17);
            this.qst4.TabIndex = 6;
            this.qst4.TabStop = true;
            this.qst4.Text = "radioButton4";
            this.qst4.UseVisualStyleBackColor = true;
            // 
            // qst3
            // 
            this.qst3.AutoSize = true;
            this.qst3.Location = new System.Drawing.Point(63, 147);
            this.qst3.Name = "qst3";
            this.qst3.Size = new System.Drawing.Size(85, 17);
            this.qst3.TabIndex = 5;
            this.qst3.TabStop = true;
            this.qst3.Text = "radioButton3";
            this.qst3.UseVisualStyleBackColor = true;
            // 
            // qst2
            // 
            this.qst2.AutoSize = true;
            this.qst2.Location = new System.Drawing.Point(63, 123);
            this.qst2.Name = "qst2";
            this.qst2.Size = new System.Drawing.Size(85, 17);
            this.qst2.TabIndex = 4;
            this.qst2.TabStop = true;
            this.qst2.Text = "radioButton2";
            this.qst2.UseVisualStyleBackColor = true;
            // 
            // qst1
            // 
            this.qst1.AutoSize = true;
            this.qst1.Location = new System.Drawing.Point(63, 99);
            this.qst1.Name = "qst1";
            this.qst1.Size = new System.Drawing.Size(85, 17);
            this.qst1.TabIndex = 3;
            this.qst1.TabStop = true;
            this.qst1.Text = "radioButton1";
            this.qst1.UseVisualStyleBackColor = true;
            // 
            // quizAudioBt
            // 
            this.quizAudioBt.Location = new System.Drawing.Point(63, 270);
            this.quizAudioBt.Name = "quizAudioBt";
            this.quizAudioBt.Size = new System.Drawing.Size(75, 23);
            this.quizAudioBt.TabIndex = 2;
            this.quizAudioBt.Text = "|>";
            this.quizAudioBt.UseVisualStyleBackColor = true;
            // 
            // quizPict
            // 
            this.quizPict.Location = new System.Drawing.Point(289, 99);
            this.quizPict.Name = "quizPict";
            this.quizPict.Size = new System.Drawing.Size(155, 157);
            this.quizPict.TabIndex = 1;
            this.quizPict.TabStop = false;
            // 
            // quizText
            // 
            this.quizText.AutoSize = true;
            this.quizText.Location = new System.Drawing.Point(89, 57);
            this.quizText.Name = "quizText";
            this.quizText.Size = new System.Drawing.Size(35, 13);
            this.quizText.TabIndex = 0;
            this.quizText.Text = "label1";
            // 
            // teachPanel
            // 
            this.teachPanel.Controls.Add(this.teachInfo);
            this.teachPanel.Controls.Add(this.teachTilbakeBt);
            this.teachPanel.Controls.Add(this.teachNesteBt);
            this.teachPanel.Controls.Add(this.teachAudioBt);
            this.teachPanel.Controls.Add(this.teachPict);
            this.teachPanel.Controls.Add(this.teachText);
            this.teachPanel.Location = new System.Drawing.Point(564, 26);
            this.teachPanel.Name = "teachPanel";
            this.teachPanel.Size = new System.Drawing.Size(488, 404);
            this.teachPanel.TabIndex = 1;
            // 
            // teachInfo
            // 
            this.teachInfo.AutoSize = true;
            this.teachInfo.Location = new System.Drawing.Point(89, 99);
            this.teachInfo.MaximumSize = new System.Drawing.Size(200, 0);
            this.teachInfo.Name = "teachInfo";
            this.teachInfo.Size = new System.Drawing.Size(68, 13);
            this.teachInfo.TabIndex = 9;
            this.teachInfo.Text = "PumpOgSpyl";
            // 
            // teachTilbakeBt
            // 
            this.teachTilbakeBt.Location = new System.Drawing.Point(34, 355);
            this.teachTilbakeBt.Name = "teachTilbakeBt";
            this.teachTilbakeBt.Size = new System.Drawing.Size(75, 23);
            this.teachTilbakeBt.TabIndex = 8;
            this.teachTilbakeBt.Text = "Tilbake";
            this.teachTilbakeBt.UseVisualStyleBackColor = true;
            // 
            // teachNesteBt
            // 
            this.teachNesteBt.Location = new System.Drawing.Point(395, 355);
            this.teachNesteBt.Name = "teachNesteBt";
            this.teachNesteBt.Size = new System.Drawing.Size(75, 23);
            this.teachNesteBt.TabIndex = 7;
            this.teachNesteBt.Text = "Neste";
            this.teachNesteBt.UseVisualStyleBackColor = true;
            // 
            // teachAudioBt
            // 
            this.teachAudioBt.Location = new System.Drawing.Point(63, 270);
            this.teachAudioBt.Name = "teachAudioBt";
            this.teachAudioBt.Size = new System.Drawing.Size(75, 23);
            this.teachAudioBt.TabIndex = 2;
            this.teachAudioBt.Text = "|>";
            this.teachAudioBt.UseVisualStyleBackColor = true;
            // 
            // teachPict
            // 
            this.teachPict.Location = new System.Drawing.Point(289, 99);
            this.teachPict.Name = "teachPict";
            this.teachPict.Size = new System.Drawing.Size(155, 157);
            this.teachPict.TabIndex = 1;
            this.teachPict.TabStop = false;
            // 
            // teachText
            // 
            this.teachText.AutoSize = true;
            this.teachText.Location = new System.Drawing.Point(89, 57);
            this.teachText.Name = "teachText";
            this.teachText.Size = new System.Drawing.Size(35, 13);
            this.teachText.TabIndex = 0;
            this.teachText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 479);
            this.Controls.Add(this.teachPanel);
            this.Controls.Add(this.quizPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.quizPanel.ResumeLayout(false);
            this.quizPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizPict)).EndInit();
            this.teachPanel.ResumeLayout(false);
            this.teachPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachPict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel quizPanel;
        private System.Windows.Forms.RadioButton qst4;
        private System.Windows.Forms.RadioButton qst3;
        private System.Windows.Forms.RadioButton qst2;
        private System.Windows.Forms.RadioButton qst1;
        private System.Windows.Forms.Button quizAudioBt;
        private System.Windows.Forms.PictureBox quizPict;
        private System.Windows.Forms.Label quizText;
        private System.Windows.Forms.Button nextBt;
        private System.Windows.Forms.Panel teachPanel;
        private System.Windows.Forms.Button teachTilbakeBt;
        private System.Windows.Forms.Button teachNesteBt;
        private System.Windows.Forms.Button teachAudioBt;
        private System.Windows.Forms.PictureBox teachPict;
        private System.Windows.Forms.Label teachText;
        private System.Windows.Forms.Label teachInfo;
    }
}

