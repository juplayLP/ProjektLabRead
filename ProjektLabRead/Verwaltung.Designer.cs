namespace ProjektLabRead
{
    partial class Verwaltung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Userdata = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Zugriffdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_Vorname = new System.Windows.Forms.TextBox();
            this.TBX_Nachname = new System.Windows.Forms.TextBox();
            this.TBX_Email = new System.Windows.Forms.TextBox();
            this.TBX_Benutzername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBX_Passwort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBX_Ibutton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBX_UID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBX_Key = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Userdata)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zugriffdata)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(699, 419);
            this.Tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.CBX_Key);
            this.tabPage1.Controls.Add(this.TBX_UID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TBX_Ibutton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TBX_Passwort);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TBX_Benutzername);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TBX_Email);
            this.tabPage1.Controls.Add(this.TBX_Nachname);
            this.tabPage1.Controls.Add(this.TBX_Vorname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Userdata);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(691, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Userdata
            // 
            this.Userdata.AllowUserToAddRows = false;
            this.Userdata.AllowUserToDeleteRows = false;
            this.Userdata.AllowUserToResizeColumns = false;
            this.Userdata.AllowUserToResizeRows = false;
            this.Userdata.BackgroundColor = System.Drawing.Color.White;
            this.Userdata.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Userdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Userdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Userdata.GridColor = System.Drawing.Color.White;
            this.Userdata.Location = new System.Drawing.Point(0, 151);
            this.Userdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Userdata.Name = "Userdata";
            this.Userdata.ReadOnly = true;
            this.Userdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Userdata.RowHeadersWidth = 51;
            this.Userdata.RowTemplate.Height = 24;
            this.Userdata.Size = new System.Drawing.Size(685, 235);
            this.Userdata.TabIndex = 0;
            this.Userdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Userdata_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Zugriffdata);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(691, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zugriffsrechte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Zugriffdata
            // 
            this.Zugriffdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Zugriffdata.Location = new System.Drawing.Point(2, 6);
            this.Zugriffdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zugriffdata.Name = "Zugriffdata";
            this.Zugriffdata.RowHeadersWidth = 51;
            this.Zugriffdata.RowTemplate.Height = 24;
            this.Zugriffdata.Size = new System.Drawing.Size(684, 380);
            this.Zugriffdata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // TBX_Vorname
            // 
            this.TBX_Vorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Vorname.Location = new System.Drawing.Point(81, 6);
            this.TBX_Vorname.Name = "TBX_Vorname";
            this.TBX_Vorname.Size = new System.Drawing.Size(210, 22);
            this.TBX_Vorname.TabIndex = 4;
            // 
            // TBX_Nachname
            // 
            this.TBX_Nachname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Nachname.Location = new System.Drawing.Point(81, 33);
            this.TBX_Nachname.Name = "TBX_Nachname";
            this.TBX_Nachname.Size = new System.Drawing.Size(210, 22);
            this.TBX_Nachname.TabIndex = 5;
            // 
            // TBX_Email
            // 
            this.TBX_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Email.Location = new System.Drawing.Point(81, 61);
            this.TBX_Email.Name = "TBX_Email";
            this.TBX_Email.Size = new System.Drawing.Size(210, 22);
            this.TBX_Email.TabIndex = 6;
            // 
            // TBX_Benutzername
            // 
            this.TBX_Benutzername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Benutzername.Location = new System.Drawing.Point(81, 88);
            this.TBX_Benutzername.Name = "TBX_Benutzername";
            this.TBX_Benutzername.Size = new System.Drawing.Size(210, 22);
            this.TBX_Benutzername.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nutzername";
            // 
            // TBX_Passwort
            // 
            this.TBX_Passwort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Passwort.Location = new System.Drawing.Point(81, 116);
            this.TBX_Passwort.Name = "TBX_Passwort";
            this.TBX_Passwort.Size = new System.Drawing.Size(210, 22);
            this.TBX_Passwort.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Passwort";
            // 
            // TBX_Ibutton
            // 
            this.TBX_Ibutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Ibutton.Location = new System.Drawing.Point(371, 6);
            this.TBX_Ibutton.Name = "TBX_Ibutton";
            this.TBX_Ibutton.Size = new System.Drawing.Size(210, 22);
            this.TBX_Ibutton.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ibutton";
            // 
            // TBX_UID
            // 
            this.TBX_UID.BackColor = System.Drawing.Color.White;
            this.TBX_UID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_UID.Location = new System.Drawing.Point(371, 34);
            this.TBX_UID.Name = "TBX_UID";
            this.TBX_UID.ReadOnly = true;
            this.TBX_UID.Size = new System.Drawing.Size(210, 22);
            this.TBX_UID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "UserID";
            // 
            // CBX_Key
            // 
            this.CBX_Key.AutoSize = true;
            this.CBX_Key.Location = new System.Drawing.Point(329, 61);
            this.CBX_Key.Name = "CBX_Key";
            this.CBX_Key.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBX_Key.Size = new System.Drawing.Size(74, 19);
            this.CBX_Key.TabIndex = 15;
            this.CBX_Key.Text = "?KeyUser";
            this.CBX_Key.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(297, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(419, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "Zurücksetzen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(541, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 52);
            this.button3.TabIndex = 18;
            this.button3.Text = "Auswahl Übernehmen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(588, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 22);
            this.button4.TabIndex = 19;
            this.button4.Text = "Ändern";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.Tab);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Verwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Verwaltung_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Verwaltung_ResizeEnd);
            this.Resize += new System.EventHandler(this.Verwaltung_Resize);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Userdata)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Zugriffdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Zugriffdata;
        private System.Windows.Forms.DataGridView Userdata;
        private System.Windows.Forms.TextBox TBX_Passwort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBX_Benutzername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBX_Email;
        private System.Windows.Forms.TextBox TBX_Nachname;
        private System.Windows.Forms.TextBox TBX_Vorname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_Ibutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CBX_Key;
        private System.Windows.Forms.TextBox TBX_UID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}