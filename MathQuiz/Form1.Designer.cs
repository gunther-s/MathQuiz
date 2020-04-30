namespace MathQuiz
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
            this.mathLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startTheQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mathLabel
            // 
            this.mathLabel.AutoSize = true;
            this.mathLabel.Location = new System.Drawing.Point(46, 32);
            this.mathLabel.Name = "mathLabel";
            this.mathLabel.Size = new System.Drawing.Size(31, 13);
            this.mathLabel.TabIndex = 0;
            this.mathLabel.Text = "Math";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startTheQuiz
            // 
            this.startTheQuiz.Location = new System.Drawing.Point(211, 334);
            this.startTheQuiz.Name = "startTheQuiz";
            this.startTheQuiz.Size = new System.Drawing.Size(223, 57);
            this.startTheQuiz.TabIndex = 1;
            this.startTheQuiz.Text = "Start the Quiz";
            this.startTheQuiz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 403);
            this.Controls.Add(this.startTheQuiz);
            this.Controls.Add(this.mathLabel);
            this.Name = "Form1";
            this.Text = "Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mathLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startTheQuiz;
    }
}

