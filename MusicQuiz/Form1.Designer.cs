namespace MusicQuiz
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
            this.components = new System.ComponentModel.Container();
            this.folderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.newQuestionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.songTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.scroreTimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(305, 12);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(67, 37);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Select Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // newQuestionButton
            // 
            this.newQuestionButton.Location = new System.Drawing.Point(305, 55);
            this.newQuestionButton.Name = "newQuestionButton";
            this.newQuestionButton.Size = new System.Drawing.Size(67, 37);
            this.newQuestionButton.TabIndex = 1;
            this.newQuestionButton.Text = "New Question";
            this.newQuestionButton.UseVisualStyleBackColor = true;
            this.newQuestionButton.Click += new System.EventHandler(this.newQuestionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name the artist";
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(12, 55);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(218, 37);
            this.option1Button.TabIndex = 3;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(12, 122);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(218, 37);
            this.option2Button.TabIndex = 4;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(12, 189);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(218, 37);
            this.option3Button.TabIndex = 5;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLabel.Location = new System.Drawing.Point(6, 246);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(355, 25);
            this.feedbackLabel.TabIndex = 6;
            this.feedbackLabel.Text = "Hit \'Select Folder\' to add your music";
            // 
            // songTimer
            // 
            this.songTimer.Interval = 10;
            this.songTimer.Tick += new System.EventHandler(this.songTimer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // scroreTimerLabel
            // 
            this.scroreTimerLabel.AutoSize = true;
            this.scroreTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scroreTimerLabel.Location = new System.Drawing.Point(255, 157);
            this.scroreTimerLabel.Name = "scroreTimerLabel";
            this.scroreTimerLabel.Size = new System.Drawing.Size(0, 25);
            this.scroreTimerLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 294);
            this.Controls.Add(this.scroreTimerLabel);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newQuestionButton);
            this.Controls.Add(this.folderButton);
            this.Name = "Form1";
            this.Text = "Music Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button newQuestionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Timer songTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label scroreTimerLabel;


    }
}

