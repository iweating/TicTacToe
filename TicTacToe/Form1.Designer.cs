namespace TicTacToe
{
    partial class TicTacToe
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
            this.btnBottomRight.Location = new System.Drawing.Point(190, 176);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(50, 50);
            this.btnBottomRight.TabIndex = 4;
            this.btnBottomRight.UseVisualStyleBackColor = true;
            this.btnBottomRight.Click += new System.EventHandler(this.btnBottomRight_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.Location = new System.Drawing.Point(40, 176);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(50, 50);
            this.btnBottomLeft.TabIndex = 3;
            this.btnBottomLeft.UseVisualStyleBackColor = true;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnBottomLeft_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.Location = new System.Drawing.Point(117, 176);
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
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBottomMiddle);
            this.Controls.Add(this.btnMiddleRight);
            this.Controls.Add(this.btnMiddleLeft);
            this.Controls.Add(this.btnMiddleMiddle);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnTopMiddle);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopLeft);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);

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
    }
}

