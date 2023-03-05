namespace formsapp1
{
    partial class FrontPage
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
            this.uniMind = new System.Windows.Forms.TextBox();
            this.signIn = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.signinpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signinpic)).BeginInit();
            this.SuspendLayout();
            // 
            // uniMind
            // 
            this.uniMind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uniMind.BackColor = System.Drawing.SystemColors.InfoText;
            this.uniMind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uniMind.Font = new System.Drawing.Font("Sans Serif Collection", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniMind.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.uniMind.Location = new System.Drawing.Point(12, 223);
            this.uniMind.Name = "uniMind";
            this.uniMind.Size = new System.Drawing.Size(467, 148);
            this.uniMind.TabIndex = 0;
            this.uniMind.Text = "UniMind";
            this.uniMind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uniMind.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // signIn
            // 
            this.signIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.signIn.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.ForeColor = System.Drawing.Color.White;
            this.signIn.Location = new System.Drawing.Point(125, 377);
            this.signIn.Name = "signIn";
            this.signIn.ReadOnly = true;
            this.signIn.Size = new System.Drawing.Size(257, 52);
            this.signIn.TabIndex = 1;
            this.signIn.Text = "Sign In";
            this.signIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signIn.TextChanged += new System.EventHandler(this.signIn_TextChanged);
            // 
            // register
            // 
            this.register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register.BackColor = System.Drawing.SystemColors.HotTrack;
            this.register.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(156, 450);
            this.register.Name = "register";
            this.register.ReadOnly = true;
            this.register.Size = new System.Drawing.Size(195, 44);
            this.register.TabIndex = 2;
            this.register.Text = "Register";
            this.register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(79, 616);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(365, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By continuing you agree to the Terms and Conditions";
            // 
            // signinpic
            // 
            this.signinpic.ImageLocation = "C:\\Users\\patrw\\source\\repos\\DDDgroup2\\prototype2xamarin\\formsapp1\\2023-03-05 17_0" +
    "1_43-2023-02-21 01_14_56-Untitled Project – Uizard.png (1278×831).png";
            this.signinpic.Location = new System.Drawing.Point(125, 12);
            this.signinpic.Name = "signinpic";
            this.signinpic.Size = new System.Drawing.Size(281, 218);
            this.signinpic.TabIndex = 4;
            this.signinpic.TabStop = false;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(507, 752);
            this.Controls.Add(this.signinpic);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.uniMind);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrontPage";
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.FrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signinpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uniMind;
        private System.Windows.Forms.TextBox signIn;
        private System.Windows.Forms.TextBox register;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox signinpic;
    }
}

