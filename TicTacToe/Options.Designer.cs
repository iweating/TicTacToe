namespace TicTacToe
{
    partial class Options
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
            this.lblYourMarker = new System.Windows.Forms.Label();
            this.lblColorScheme = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.cbColorScheme = new System.Windows.Forms.ComboBox();
            this.btnXMarker = new System.Windows.Forms.Button();
            this.btnOMarker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYourMarker
            // 
            this.lblYourMarker.AutoSize = true;
            this.lblYourMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourMarker.Location = new System.Drawing.Point(13, 13);
            this.lblYourMarker.Name = "lblYourMarker";
            this.lblYourMarker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYourMarker.Size = new System.Drawing.Size(100, 20);
            this.lblYourMarker.TabIndex = 0;
            this.lblYourMarker.Text = "Your Marker:";
            // 
            // lblColorScheme
            // 
            this.lblColorScheme.AutoSize = true;
            this.lblColorScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorScheme.Location = new System.Drawing.Point(12, 116);
            this.lblColorScheme.Name = "lblColorScheme";
            this.lblColorScheme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblColorScheme.Size = new System.Drawing.Size(117, 20);
            this.lblColorScheme.TabIndex = 1;
            this.lblColorScheme.Text = "Color Scheme: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 221);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(197, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(105, 221);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(86, 23);
            this.btnDefaults.TabIndex = 4;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // cbColorScheme
            // 
            this.cbColorScheme.FormattingEnabled = true;
            this.cbColorScheme.Items.AddRange(new object[] {
            "White",
            "Black"});
            this.cbColorScheme.Location = new System.Drawing.Point(136, 114);
            this.cbColorScheme.Name = "cbColorScheme";
            this.cbColorScheme.Size = new System.Drawing.Size(121, 21);
            this.cbColorScheme.TabIndex = 5;
            this.cbColorScheme.SelectedIndexChanged += new System.EventHandler(this.cbColorScheme_SelectedIndexChanged);
            // 
            // btnXMarker
            // 
            this.btnXMarker.BackgroundImage = global::TicTacToe.Properties.Resources.XMark;
            this.btnXMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXMarker.Location = new System.Drawing.Point(26, 37);
            this.btnXMarker.Name = "btnXMarker";
            this.btnXMarker.Size = new System.Drawing.Size(65, 65);
            this.btnXMarker.TabIndex = 6;
            this.btnXMarker.UseVisualStyleBackColor = true;
            this.btnXMarker.Click += new System.EventHandler(this.btnXMarker_Click);
            // 
            // btnOMarker
            // 
            this.btnOMarker.BackgroundImage = global::TicTacToe.Properties.Resources.OMark;
            this.btnOMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOMarker.Location = new System.Drawing.Point(105, 37);
            this.btnOMarker.Name = "btnOMarker";
            this.btnOMarker.Size = new System.Drawing.Size(65, 65);
            this.btnOMarker.TabIndex = 7;
            this.btnOMarker.UseVisualStyleBackColor = true;
            this.btnOMarker.Click += new System.EventHandler(this.btnOMarker_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 262);
            this.Controls.Add(this.btnOMarker);
            this.Controls.Add(this.btnXMarker);
            this.Controls.Add(this.cbColorScheme);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblColorScheme);
            this.Controls.Add(this.lblYourMarker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourMarker;
        private System.Windows.Forms.Label lblColorScheme;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.ComboBox cbColorScheme;
        private System.Windows.Forms.Button btnXMarker;
        private System.Windows.Forms.Button btnOMarker;
    }
}