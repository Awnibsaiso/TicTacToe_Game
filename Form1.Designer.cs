namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.gbGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 79);
            this.label2.TabIndex = 10;
            this.label2.Text = "TIC-TAC-TOE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(71, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 75);
            this.label3.TabIndex = 11;
            this.label3.Text = "Winner:";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblWinner.Location = new System.Drawing.Point(122, 435);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(296, 74);
            this.lblWinner.TabIndex = 12;
            this.lblWinner.Text = "In Progress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(71, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 75);
            this.label4.TabIndex = 13;
            this.label4.Text = "Turn:";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Gold;
            this.lblTurn.Location = new System.Drawing.Point(122, 276);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(234, 74);
            this.lblTurn.TabIndex = 14;
            this.lblTurn.Text = "Player1";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRestartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRestartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(84, 610);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(334, 68);
            this.btnRestartGame.TabIndex = 0;
            this.btnRestartGame.Text = "Restart Game!";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // gbGame
            // 
            this.gbGame.BackColor = System.Drawing.Color.Transparent;
            this.gbGame.Controls.Add(this.btn9);
            this.gbGame.Controls.Add(this.btn7);
            this.gbGame.Controls.Add(this.btn6);
            this.gbGame.Controls.Add(this.btn5);
            this.gbGame.Controls.Add(this.btn4);
            this.gbGame.Controls.Add(this.btn3);
            this.gbGame.Controls.Add(this.btn8);
            this.gbGame.Controls.Add(this.btn2);
            this.gbGame.Controls.Add(this.btn1);
            this.gbGame.ForeColor = System.Drawing.Color.Transparent;
            this.gbGame.Location = new System.Drawing.Point(522, 28);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(819, 705);
            this.gbGame.TabIndex = 15;
            this.gbGame.TabStop = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(587, 488);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(205, 175);
            this.btn9.TabIndex = 13;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(38, 488);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(205, 175);
            this.btn7.TabIndex = 12;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(587, 248);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(205, 175);
            this.btn6.TabIndex = 11;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(313, 248);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(205, 175);
            this.btn5.TabIndex = 10;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(38, 248);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(205, 175);
            this.btn4.TabIndex = 9;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(587, 21);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(205, 175);
            this.btn3.TabIndex = 8;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(313, 488);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(205, 175);
            this.btn8.TabIndex = 4;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(313, 21);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(205, 175);
            this.btn2.TabIndex = 3;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::TicTacToe.Properties.Resources.question_mark_96;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(38, 21);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(205, 175);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1377, 771);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TIC-TAC-TOE";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.gbGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}

