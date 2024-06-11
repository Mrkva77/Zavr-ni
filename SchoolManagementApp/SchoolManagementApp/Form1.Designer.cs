namespace SchoolManagementApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtIme = new System.Windows.Forms.TextBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnShowPeople = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnProcessData = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(167, 29);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(119, 45);
            this.txtPrezime.TabIndex = 0;
            this.txtPrezime.Text = "Prezime";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(26, 29);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(122, 45);
            this.txtIme.TabIndex = 3;
            this.txtIme.Text = "Ime";
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Staff"});
            this.cmbUloga.Location = new System.Drawing.Point(309, 29);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(121, 28);
            this.cmbUloga.TabIndex = 4;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.AccessibleName = "btnAddPerson";
            this.btnAddPerson.Location = new System.Drawing.Point(26, 82);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(169, 99);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "ADD";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click_1);
            // 
            // btnShowPeople
            // 
            this.btnShowPeople.Location = new System.Drawing.Point(228, 82);
            this.btnShowPeople.Name = "btnShowPeople";
            this.btnShowPeople.Size = new System.Drawing.Size(169, 99);
            this.btnShowPeople.TabIndex = 7;
            this.btnShowPeople.Text = "SHOW";
            this.btnShowPeople.UseVisualStyleBackColor = true;
            this.btnShowPeople.Click += new System.EventHandler(this.btnShowPeople_Click_1);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(427, 82);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(169, 99);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // btnProcessData
            // 
            this.btnProcessData.Location = new System.Drawing.Point(619, 82);
            this.btnProcessData.Name = "btnProcessData";
            this.btnProcessData.Size = new System.Drawing.Size(169, 99);
            this.btnProcessData.TabIndex = 9;
            this.btnProcessData.Text = "PROCES";
            this.btnProcessData.UseVisualStyleBackColor = true;
            this.btnProcessData.Click += new System.EventHandler(this.btnProcessData_Click_1);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(26, 201);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(762, 150);
            this.textbox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.btnProcessData);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnShowPeople);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnShowPeople;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnProcessData;
        private System.Windows.Forms.TextBox textbox1;
    }
}

