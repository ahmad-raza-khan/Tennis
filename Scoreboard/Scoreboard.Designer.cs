namespace Scoreboard
{
    partial class Scoreboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlayer1 = new Button();
            btnPlayer2 = new Button();
            lblScore = new Label();
            label1 = new Label();
            label2 = new Label();
            txtPlayer1 = new TextBox();
            txtPlayer2 = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // btnPlayer1
            // 
            btnPlayer1.Location = new Point(30, 84);
            btnPlayer1.Name = "btnPlayer1";
            btnPlayer1.Size = new Size(112, 23);
            btnPlayer1.TabIndex = 0;
            btnPlayer1.Text = "Player1 Scored";
            btnPlayer1.UseVisualStyleBackColor = true;
            btnPlayer1.Visible = false;
            btnPlayer1.Click += btnPlayer1_Click;
            // 
            // btnPlayer2
            // 
            btnPlayer2.Location = new Point(573, 84);
            btnPlayer2.Name = "btnPlayer2";
            btnPlayer2.Size = new Size(103, 23);
            btnPlayer2.TabIndex = 1;
            btnPlayer2.Text = "Player2 Scored";
            btnPlayer2.UseVisualStyleBackColor = true;
            btnPlayer2.Visible = false;
            btnPlayer2.Click += btnPlayer2_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 29F);
            lblScore.Location = new Point(273, 180);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(161, 52);
            lblScore.TabIndex = 2;
            lblScore.Text = "Love-All";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Player1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 29);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Player2";
            // 
            // txtPlayer1
            // 
            txtPlayer1.Location = new Point(74, 26);
            txtPlayer1.Name = "txtPlayer1";
            txtPlayer1.Size = new Size(233, 23);
            txtPlayer1.TabIndex = 5;
            // 
            // txtPlayer2
            // 
            txtPlayer2.Location = new Point(427, 26);
            txtPlayer2.Name = "txtPlayer2";
            txtPlayer2.Size = new Size(249, 23);
            txtPlayer2.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 29F);
            btnStart.Location = new Point(285, 133);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(169, 99);
            btnStart.TabIndex = 7;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Scoreboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 286);
            Controls.Add(btnStart);
            Controls.Add(txtPlayer2);
            Controls.Add(txtPlayer1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblScore);
            Controls.Add(btnPlayer2);
            Controls.Add(btnPlayer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Scoreboard";
            Text = "Scoreboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlayer1;
        private Button btnPlayer2;
        private Label lblScore;
        private Label label1;
        private Label label2;
        private TextBox txtPlayer1;
        private TextBox txtPlayer2;
        private Button btnStart;
    }
}
