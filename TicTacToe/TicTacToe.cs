using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        int user = 1;
        List<List<int>> markedSpots = new List<List<int>>();
        bool gameWon = false;
        System.Timers.Timer timer = new System.Timers.Timer();

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void NewGame()
        {
            Random random = new Random();
            this.user = random.Next(1, 3);
            gameWon = false;
            markedSpots = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                markedSpots.Add(new List<int> { 0, 0 });
            }
            btnTopLeft.Image = null;
            btnTopLeft.Enabled = true;
            btnTopRight.Image = null;
            btnTopRight.Enabled = true;
            btnTopMiddle.Image = null;
            btnTopMiddle.Enabled = true;
            btnMiddleLeft.Image = null;
            btnMiddleLeft.Enabled = true;
            btnMiddleMiddle.Image = null;
            btnMiddleMiddle.Enabled = true;
            btnMiddleRight.Image = null;
            btnMiddleRight.Enabled = true;
            btnBottomLeft.Image = null;
            btnBottomLeft.Enabled = true;
            btnBottomMiddle.Image = null;
            btnBottomMiddle.Enabled = true;
            btnBottomRight.Image = null;
            btnBottomRight.Enabled = true;

            timer.Start();
            timer.SynchronizingObject = lblTimer;

            //lblTimer.Text = "Timer: 00:00:00";
            
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnTopLeft.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[0][1] = 1;
                markedSpots[0][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnTopLeft.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                btnTopLeft.Enabled = false;
                markedSpots[0][1] = 2;
                markedSpots[0][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnTopLeft.Enabled = false;
            }
        }

        private void btnTopMiddle_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnTopMiddle.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[1][1] = 1;
                markedSpots[1][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnTopMiddle.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[1][1] = 2;
                markedSpots[1][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnTopMiddle.Enabled = false;
            }
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnTopRight.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[2][1] = 1;
                markedSpots[2][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnTopRight.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[2][1] = 2;
                markedSpots[2][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnTopRight.Enabled = false;
            }
        }

        private void btnMiddleLeft_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnMiddleLeft.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[3][1] = 1;
                markedSpots[3][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnMiddleLeft.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[3][1] = 2;
                markedSpots[3][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnMiddleLeft.Enabled = false;
            }
        }

        private void btnMiddleMiddle_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnMiddleMiddle.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[4][1] = 1;
                markedSpots[4][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnMiddleMiddle.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[4][1] = 2;
                markedSpots[4][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnMiddleMiddle.Enabled = false;
            }
        }

        private void btnMiddleRight_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnMiddleRight.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[5][1] = 1;
                markedSpots[5][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnMiddleRight.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[5][1] = 2;
                markedSpots[5][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnMiddleRight.Enabled = false;
            }
        }

        private void btnBottomLeft_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnBottomLeft.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[6][1] = 1;
                markedSpots[6][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnBottomLeft.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[6][1] = 2;
                markedSpots[6][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnBottomLeft.Enabled = false;
            }
        }

        private void btnBottomMiddle_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnBottomMiddle.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[7][1] = 1;
                markedSpots[7][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnBottomMiddle.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[7][1] = 2;
                markedSpots[7][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnBottomMiddle.Enabled = false;
            }
        }

        private void btnBottomRight_Click(object sender, EventArgs e)
        {
            if (user == 1)
            {
                btnBottomRight.Image = ((System.Drawing.Image)(Properties.Resources.XMark));
                markedSpots[8][1] = 1;
                markedSpots[8][0] = 1;
                gameWon = WinnerCheck();
                user = 2;
            }
            else
            {
                btnBottomRight.Image = ((System.Drawing.Image)(Properties.Resources.OMark));
                markedSpots[8][1] = 2;
                markedSpots[8][0] = 1;
                gameWon = WinnerCheck();
                user = 1;
            }
            if (!gameWon)
            {
                btnBottomRight.Enabled = false;
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            NewGame();
            //gameTimer.Start();
        }

        private bool WinnerCheck()
        {
            if ((markedSpots[0][1] == user && markedSpots[1][1] == user && markedSpots[2][1] == user) ||
                (markedSpots[3][1] == user && markedSpots[4][1] == user && markedSpots[5][1] == user) ||
                (markedSpots[6][1] == user && markedSpots[7][1] == user && markedSpots[8][1] == user) ||
                (markedSpots[0][1] == user && markedSpots[3][1] == user && markedSpots[6][1] == user) ||
                (markedSpots[1][1] == user && markedSpots[4][1] == user && markedSpots[7][1] == user) ||
                (markedSpots[2][1] == user && markedSpots[5][1] == user && markedSpots[8][1] == user) ||
                (markedSpots[0][1] == user && markedSpots[4][1] == user && markedSpots[8][1] == user) ||
                (markedSpots[2][1] == user && markedSpots[4][1] == user && markedSpots[6][1] == user) )
            {
                //TimeSpan sp = TimeSpan.FromSeconds(timer);
                //if (user == 0)
                //{

//                    MessageBox.Show("Time: " + sp.ToString() + "\nYou Win!");
//                }
//                else
//                {
//                    MessageBox.Show("Time: " + sp.ToString() + "\nYou Win!");
//                }
                NewGame();
                return true;
            }
            else if(
                (markedSpots[0][0] == 1 && markedSpots[1][0] == 1 && markedSpots[2][0] == 1) &&
                (markedSpots[3][0] == 1 && markedSpots[4][0] == 1 && markedSpots[5][0] == 1) &&
                (markedSpots[6][0] == 1 && markedSpots[7][0] == 1 && markedSpots[8][0] == 1) )
            {
                MessageBox.Show("Draw");
                NewGame();
                return true;
            }
            return false;
        }

    }
}
