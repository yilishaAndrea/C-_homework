namespace task3
{
    partial class Exam
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.problem = new System.Windows.Forms.GroupBox();
            this.number = new System.Windows.Forms.GroupBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.problemTitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.problem.SuspendLayout();
            this.number.SuspendLayout();
            this.SuspendLayout();
            // 
            // problem
            // 
            this.problem.Controls.Add(this.number);
            this.problem.Location = new System.Drawing.Point(12, 54);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(560, 315);
            this.problem.TabIndex = 0;
            this.problem.TabStop = false;
            this.problem.Text = "题目";
            this.problem.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.SystemColors.ControlDark;
            this.number.Controls.Add(this.radioButtonD);
            this.number.Controls.Add(this.radioButtonC);
            this.number.Controls.Add(this.radioButtonB);
            this.number.Controls.Add(this.radioButtonA);
            this.number.Controls.Add(this.problemTitle);
            this.number.Location = new System.Drawing.Point(22, 20);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(516, 274);
            this.number.TabIndex = 0;
            this.number.TabStop = false;
            this.number.Text = "第1题";
            this.number.Enter += new System.EventHandler(this.number_Enter);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(36, 231);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(95, 16);
            this.radioButtonD.TabIndex = 4;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Tag = "answer";
            this.radioButtonD.Text = "radioButtonD";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.radioButtonD_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(36, 196);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(95, 16);
            this.radioButtonC.TabIndex = 3;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Tag = "answer";
            this.radioButtonC.Text = "radioButtonC";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(36, 158);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(95, 16);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Tag = "answer";
            this.radioButtonB.Text = "radioButtonB";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(36, 116);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(95, 16);
            this.radioButtonA.TabIndex = 1;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Tag = "answer";
            this.radioButtonA.Text = "radioButtonA";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // problemTitle
            // 
            this.problemTitle.AutoSize = true;
            this.problemTitle.BackColor = System.Drawing.SystemColors.Control;
            this.problemTitle.Location = new System.Drawing.Point(34, 27);
            this.problemTitle.MaximumSize = new System.Drawing.Size(200, 100);
            this.problemTitle.MinimumSize = new System.Drawing.Size(450, 70);
            this.problemTitle.Name = "problemTitle";
            this.problemTitle.Size = new System.Drawing.Size(450, 70);
            this.problemTitle.TabIndex = 0;
            this.problemTitle.Text = "hhhhhh";
            this.problemTitle.Click += new System.EventHandler(this.problemTitle_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(226, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 12);
            this.title.TabIndex = 1;
            this.title.Text = "本次考试一共10题";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(144, 394);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "提交";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.UseWaitCursor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(294, 393);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "下一题";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(700, 1000);
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.title);
            this.Controls.Add(this.problem);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Exam";
            this.Text = "exam";
            this.problem.ResumeLayout(false);
            this.number.ResumeLayout(false);
            this.number.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox problem;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox number;
        private System.Windows.Forms.Label problemTitle;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonNext;
    }
}

