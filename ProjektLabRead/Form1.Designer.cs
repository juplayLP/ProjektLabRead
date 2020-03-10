namespace ProjektLabRead
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_User = new System.Windows.Forms.TextBox();
            this.TBX_Pass = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(65, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mit PLock anmelden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(166, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "ODER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "_______________________________";
            // 
            // TBX_User
            // 
            this.TBX_User.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_User.Location = new System.Drawing.Point(54, 297);
            this.TBX_User.Name = "TBX_User";
            this.TBX_User.Size = new System.Drawing.Size(334, 33);
            this.TBX_User.TabIndex = 4;
            this.TBX_User.Text = "Nutzername";
            this.TBX_User.Enter += new System.EventHandler(this.TBX_User_Enter);
            this.TBX_User.Leave += new System.EventHandler(this.TBX_User_Leave);
            // 
            // TBX_Pass
            // 
            this.TBX_Pass.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Pass.Location = new System.Drawing.Point(54, 352);
            this.TBX_Pass.Name = "TBX_Pass";
            this.TBX_Pass.Size = new System.Drawing.Size(334, 33);
            this.TBX_Pass.TabIndex = 5;
            this.TBX_Pass.Text = "Passwort";
            this.TBX_Pass.TextChanged += new System.EventHandler(this.TBX_Pass_TextChanged);
            this.TBX_Pass.Enter += new System.EventHandler(this.TBX_Pass_Enter);
            this.TBX_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBX_Pass_KeyDown);
            this.TBX_Pass.Leave += new System.EventHandler(this.TBX_Pass_Leave);
            // 
            // BTN_Login
            // 
            this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Login.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_Login.Location = new System.Drawing.Point(112, 403);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(194, 67);
            this.BTN_Login.TabIndex = 6;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 492);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.TBX_Pass);
            this.Controls.Add(this.TBX_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_User;
        private System.Windows.Forms.TextBox TBX_Pass;
        private System.Windows.Forms.Button BTN_Login;
    }
}

