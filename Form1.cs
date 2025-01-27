using System;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        enum enPlayer
        {
           Player1, Player2
        }
        enum enWinner
        {
            Player1, Player2, Draw, InProgress
        }
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;

        }
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(Color.White, 16);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            // Horizontal lines
            e.Graphics.DrawLine(pen, 400, 200, 1000, 200);
            e.Graphics.DrawLine(pen, 400, 400, 1000, 400);
            // Vertical lines
            e.Graphics.DrawLine(pen, 600, 25, 600, 600);
            e.Graphics.DrawLine(pen, 800, 25, 800, 600);

        }

        private bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() 
                && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;

                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }
            GameStatus.GameOver = false;    
            return false;

        }

        private void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "Player2";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            DialogResult result = MessageBox.Show("Game Over", ":(", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Retry)
            {
                RestartGame();
            }
            else
            {
                Close();
            }
        }

        private void CheckWinner()
        {
            // Check Rows
            if (CheckValues(btn1, btn2, btn3))
                return;
            if (CheckValues(btn4, btn5, btn6))
                return;
            if (CheckValues(btn7, btn8, btn9))
                return;

            // Check Columns
            if (CheckValues(btn1, btn4, btn7))
                return;
            if (CheckValues(btn2, btn5, btn8))
                return;
            if (CheckValues(btn3, btn6, btn9))
                return;

            // Check Diagonal
            if (CheckValues(btn1, btn5, btn9))
                return;
            if (CheckValues(btn3, btn5, btn7))
                return;
        }

        private void PerformTicTacToe(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.BackgroundImage = Properties.Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.BackgroundImage = Properties.Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else
            {
               MessageBox.Show("Wrong Choice", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        private void ResetButtons()
        {
            foreach (Control control in gbGame.Controls)
            {
                control.BackgroundImage = Properties.Resources.question_mark_96;
                control.Tag = "?";
                control.BackColor = Color.Transparent;
            }
        }
        private void RestartGame()
        {
            ResetButtons();
            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.InProgress;
            lblWinner.Text = "In Progress";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            PerformTicTacToe((Button) sender);
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}