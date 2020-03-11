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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Userdata = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Zugriffdata = new System.Windows.Forms.DataGridView();
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
            this.Tab.Size = new System.Drawing.Size(699, 411);
            this.Tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Userdata);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(691, 383);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Userdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Userdata.GridColor = System.Drawing.Color.White;
            this.Userdata.Location = new System.Drawing.Point(0, 0);
            this.Userdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Userdata.Name = "Userdata";
            this.Userdata.ReadOnly = true;
            this.Userdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Userdata.RowHeadersWidth = 51;
            this.Userdata.RowTemplate.Height = 24;
            this.Userdata.Size = new System.Drawing.Size(685, 392);
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
            this.tabPage2.Size = new System.Drawing.Size(690, 392);
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
            this.Text = "Verwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Verwaltung_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Verwaltung_ResizeEnd);
            this.Resize += new System.EventHandler(this.Verwaltung_Resize);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}