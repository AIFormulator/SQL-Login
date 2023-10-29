namespace SQL_Login
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.User_progress = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.Leaderboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.MaskedTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeft.Controls.Add(this.button3);
            this.panelLeft.Controls.Add(this.User_progress);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Controls.Add(this.Leaderboard);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(207, 450);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "DASHBOARD";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // User_progress
            // 
            this.User_progress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.User_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_progress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_progress.Image = ((System.Drawing.Image)(resources.GetObject("User_progress.Image")));
            this.User_progress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User_progress.Location = new System.Drawing.Point(12, 164);
            this.User_progress.Name = "User_progress";
            this.User_progress.Size = new System.Drawing.Size(192, 51);
            this.User_progress.TabIndex = 2;
            this.User_progress.Text = "   USER PROGRESS";
            this.User_progress.UseVisualStyleBackColor = false;
            this.User_progress.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(78, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(101, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Family Savers";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Leaderboard
            // 
            this.Leaderboard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leaderboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Leaderboard.Image = ((System.Drawing.Image)(resources.GetObject("Leaderboard.Image")));
            this.Leaderboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Leaderboard.Location = new System.Drawing.Point(12, 107);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(192, 51);
            this.Leaderboard.TabIndex = 0;
            this.Leaderboard.Text = "LEADERBOARD";
            this.Leaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Leaderboard.UseVisualStyleBackColor = false;
            this.Leaderboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.Submit);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.Deposit);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.Username);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(207, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(593, 450);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(109, 183);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(241, 22);
            this.Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount to Deposit:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(109, 287);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(241, 22);
            this.Deposit.TabIndex = 3;
            this.Deposit.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(168, 331);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(131, 43);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Deposit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Main Goal:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(62, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 45);
            this.textBox1.TabIndex = 7;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button Leaderboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button User_progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Deposit;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}