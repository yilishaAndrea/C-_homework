namespace task3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.startanswer = new System.Windows.Forms.Button();
            this.yilisha_andrea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yilisha_andrea)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // startanswer
            // 
            this.startanswer.Location = new System.Drawing.Point(146, 143);
            this.startanswer.Name = "startanswer";
            this.startanswer.Size = new System.Drawing.Size(75, 23);
            this.startanswer.TabIndex = 1;
            this.startanswer.Text = "开始答题";
            this.startanswer.UseVisualStyleBackColor = true;
            this.startanswer.Click += new System.EventHandler(this.startanswer_Click);
            // 
            // yilisha_andrea
            // 
            this.yilisha_andrea.Image = ((System.Drawing.Image)(resources.GetObject("yilisha_andrea.Image")));
            this.yilisha_andrea.Location = new System.Drawing.Point(106, 30);
            this.yilisha_andrea.Name = "yilisha_andrea";
            this.yilisha_andrea.Size = new System.Drawing.Size(159, 78);
            this.yilisha_andrea.TabIndex = 2;
            this.yilisha_andrea.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.yilisha_andrea);
            this.Controls.Add(this.startanswer);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.yilisha_andrea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startanswer;
        private System.Windows.Forms.PictureBox yilisha_andrea;
    }
}