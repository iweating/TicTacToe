namespace TicTacToe
{
    partial class frmTicTacToe
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
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnTopMiddle = new System.Windows.Forms.Button();
            this.btnMiddleMiddle = new System.Windows.Forms.Button();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnBottomMiddle = new System.Windows.Forms.Button();
            this.btnMiddleRight = new System.Windows.Forms.Button();
            this.btnMiddleLeft = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.Location = new System.Drawing.Point(40, 26);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(50, 50);
            this.btnTopLeft.TabIndex = 0;
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.Location = new System.Drawing.Point(190, 26);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(50, 50);
            this.btnTopRight.TabIndex = 1;
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // btnTopMiddle
            // 
            this.btnTopMiddle.Location = new System.Drawing.Point(117, 26);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(50, 50);
            this.btnTopMiddle.TabIndex = 2;
            this.btnTopMiddle.UseVisualStyleBackColor = true;
            this.btnTopMiddle.Click += new System.EventHandler(this.btnTopMiddle_Click);
            // 
            // btnMiddleMiddle
            // 
            this.btnMiddleMiddle.Location = new System.Drawing.Point(117, 95);
            this.btnMiddleMiddle.Name = "btnMiddleMiddle";
            this.btnMiddleMiddle.Size = new System.Drawing.Size(50, 50);
            this.btnMiddleMiddle.TabIndex = 5;
            this.btnMiddleMiddle.UseVisualStyleBackColor = true;
            this.btnMiddleMiddle.Click += new System.EventHandler(this.btnMiddleMiddle_Click);
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.Location = new System.Drawing.Point(190, 168);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(50, 50);
            this.btnBottomRight.TabIndex = 4;
            this.btnBottomRight.UseVisualStyleBackColor = true;
            this.btnBottomRight.Click += new System.EventHandler(this.btnBottomRight_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.Location = new System.Drawing.Point(41, 168);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(50, 50);
            this.btnBottomLeft.TabIndex = 3;
            this.btnBottomLeft.UseVisualStyleBackColor = true;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnBottomLeft_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.Location = new System.Drawing.Point(117, 168);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(50, 50);
            this.btnBottomMiddle.TabIndex = 8;
            this.btnBottomMiddle.UseVisualStyleBackColor = true;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btnBottomMiddle_Click);
            // 
            // btnMiddleRight
            // 
            this.btnMiddleRight.Location = new System.Drawing.Point(190, 95);
            this.btnMiddleRight.Name = "btnMiddleRight";
            this.btnMiddleRight.Size = new System.Drawing.Size(50, 50);
            this.btnMiddleRight.TabIndex = 7;
            this.btnMiddleRight.UseVisualStyleBackColor = true;
            this.btnMiddleRight.Click += new System.EventHandler(this.btnMiddleRight_Click);
            // 
            // btnMiddleLeft
            // 
            this.btnMiddleLeft.Location = new System.Drawing.Point(40, 95);
            this.btnMiddleLeft.Name = "btnMiddleLeft";
            this.btnMiddleLeft.Size = new System.Drawing.Size(50, 50);
            this.btnMiddleLeft.TabIndex = 6;
            this.btnMiddleLeft.UseVisualStyleBackColor = true;
            this.btnMiddleLeft.Click += new System.EventHandler(this.btnMiddleLeft_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(287, 13);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(107, 25);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(287, 44);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(107, 25);
            this.btnOptions.TabIndex = 11;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(287, 75);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 25);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(287, 116);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(72, 24);
            this.lblRecord.TabIndex = 13;
            this.lblRecord.Text = "Record";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(291, 144);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(43, 13);
            this.lblWin.TabIndex = 14;
            this.lblWin.Text = "Wins: 0";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Location = new System.Drawing.Point(291, 157);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(47, 13);
            this.lblLoses.TabIndex = 15;
            this.lblLoses.Text = "Loses: 0";
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Location = new System.Drawing.Point(291, 170);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(49, 13);
            this.lblDraws.TabIndex = 16;
            this.lblDraws.Text = "Draws: 0";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Black;
            this.line2.Location = new System.Drawing.Point(97, 6);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 244);
            this.line2.TabIndex = 17;
            this.line2.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(176, 6);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 244);
            this.line1.TabIndex = 18;
            this.line1.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.Black;
            this.line4.Location = new System.Drawing.Point(21, 151);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(244, 10);
            this.line4.TabIndex = 19;
            this.line4.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.Black;
            this.line3.Location = new System.Drawing.Point(21, 81);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(244, 10);
            this.line3.TabIndex = 20;
            this.line3.TabStop = false;
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.lblLoses);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnBottomMiddle);
            this.Controls.Add(this.btnMiddleRight);
            this.Controls.Add(this.btnMiddleLeft);
            this.Controls.Add(this.btnMiddleMiddle);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnTopMiddle);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopLeft);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 299);
            this.MinimumSize = new System.Drawing.Size(422, 299);
            this.Name = "frmTicTacToe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnTopMiddle;
        private System.Windows.Forms.Button btnMiddleMiddle;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnBottomMiddle;
        private System.Windows.Forms.Button btnMiddleRight;
        private System.Windows.Forms.Button btnMiddleLeft;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line3;
    }
}

