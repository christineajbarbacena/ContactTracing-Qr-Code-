namespace Contact_Tracing_Form
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.lblViewAll = new System.Windows.Forms.Label();
            this.bttnViewall = new System.Windows.Forms.Button();
            this.bttnBacktoForm1 = new System.Windows.Forms.Button();
            this.bttnCloseall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(12, 29);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(204, 13);
            this.lblInstruction1.TabIndex = 2;
            this.lblInstruction1.Text = "Show all the responses by the given date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(63, 55);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(198, 20);
            this.txtboxDate.TabIndex = 6;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.bttnSearch.Location = new System.Drawing.Point(295, 53);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 23);
            this.bttnSearch.TabIndex = 7;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // lblViewAll
            // 
            this.lblViewAll.AutoSize = true;
            this.lblViewAll.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblViewAll.Location = new System.Drawing.Point(12, 107);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(97, 13);
            this.lblViewAll.TabIndex = 8;
            this.lblViewAll.Text = "View all responses:";
            // 
            // bttnViewall
            // 
            this.bttnViewall.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bttnViewall.Location = new System.Drawing.Point(188, 107);
            this.bttnViewall.Name = "bttnViewall";
            this.bttnViewall.Size = new System.Drawing.Size(182, 23);
            this.bttnViewall.TabIndex = 9;
            this.bttnViewall.Text = "View all";
            this.bttnViewall.UseVisualStyleBackColor = false;
            this.bttnViewall.Click += new System.EventHandler(this.bttnViewall_Click);
            // 
            // bttnBacktoForm1
            // 
            this.bttnBacktoForm1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bttnBacktoForm1.Location = new System.Drawing.Point(79, 152);
            this.bttnBacktoForm1.Name = "bttnBacktoForm1";
            this.bttnBacktoForm1.Size = new System.Drawing.Size(75, 23);
            this.bttnBacktoForm1.TabIndex = 10;
            this.bttnBacktoForm1.Text = "Back";
            this.bttnBacktoForm1.UseVisualStyleBackColor = false;
            this.bttnBacktoForm1.Click += new System.EventHandler(this.bttnBacktoForm1_Click);
            // 
            // bttnCloseall
            // 
            this.bttnCloseall.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bttnCloseall.Location = new System.Drawing.Point(205, 152);
            this.bttnCloseall.Name = "bttnCloseall";
            this.bttnCloseall.Size = new System.Drawing.Size(75, 23);
            this.bttnCloseall.TabIndex = 11;
            this.bttnCloseall.Text = "Close";
            this.bttnCloseall.UseVisualStyleBackColor = false;
            this.bttnCloseall.Click += new System.EventHandler(this.bttnCloseall_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 217);
            this.Controls.Add(this.bttnCloseall);
            this.Controls.Add(this.bttnBacktoForm1);
            this.Controls.Add(this.bttnViewall);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInstruction1);
            this.Name = "Form2";
            this.Text = "Admin Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Label lblViewAll;
        private System.Windows.Forms.Button bttnViewall;
        private System.Windows.Forms.Button bttnBacktoForm1;
        private System.Windows.Forms.Button bttnCloseall;
    }
}