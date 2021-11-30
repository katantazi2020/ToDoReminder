namespace ToDoReminder
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblpriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lbltodo = new System.Windows.Forms.Label();
            this.txttodo = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.grptodo = new System.Windows.Forms.GroupBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblpriolst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblClocktimerr = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grptodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openDataFileToolStripMenuItem,
            this.saveDataFileToolStripMenuItem,
            this.exitAltF4ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.newToolStripMenuItem.Text = "New            Ctrl+N";
            // 
            // openDataFileToolStripMenuItem
            // 
            this.openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            this.openDataFileToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.openDataFileToolStripMenuItem.Text = "Open data file";
            this.openDataFileToolStripMenuItem.Click += new System.EventHandler(this.openDataFileToolStripMenuItem_Click);
            // 
            // saveDataFileToolStripMenuItem
            // 
            this.saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            this.saveDataFileToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.saveDataFileToolStripMenuItem.Text = "Save data file";
            this.saveDataFileToolStripMenuItem.Click += new System.EventHandler(this.saveDataFileToolStripMenuItem_Click);
            // 
            // exitAltF4ToolStripMenuItem
            // 
            this.exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            this.exitAltF4ToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.exitAltF4ToolStripMenuItem.Text = "Exit     Alt+F4";
            this.exitAltF4ToolStripMenuItem.Click += new System.EventHandler(this.exitAltF4ToolStripMenuItem_Click);
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Location = new System.Drawing.Point(13, 38);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(109, 20);
            this.lbldatetime.TabIndex = 1;
            this.lbldatetime.Text = "Date and time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblpriority
            // 
            this.lblpriority.AutoSize = true;
            this.lblpriority.Location = new System.Drawing.Point(516, 46);
            this.lblpriority.Name = "lblpriority";
            this.lblpriority.Size = new System.Drawing.Size(56, 20);
            this.lblpriority.TabIndex = 3;
            this.lblpriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(594, 46);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(150, 28);
            this.cmbPriority.TabIndex = 4;
            // 
            // lbltodo
            // 
            this.lbltodo.AutoSize = true;
            this.lbltodo.Location = new System.Drawing.Point(17, 77);
            this.lbltodo.Name = "lbltodo";
            this.lbltodo.Size = new System.Drawing.Size(49, 20);
            this.lbltodo.TabIndex = 5;
            this.lbltodo.Text = "To do";
            // 
            // txttodo
            // 
            this.txttodo.Location = new System.Drawing.Point(147, 77);
            this.txttodo.Name = "txttodo";
            this.txttodo.Size = new System.Drawing.Size(312, 26);
            this.txttodo.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(489, 77);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 31);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // grptodo
            // 
            this.grptodo.Controls.Add(this.lblClocktimerr);
            this.grptodo.Controls.Add(this.lbldescription);
            this.grptodo.Controls.Add(this.lblpriolst);
            this.grptodo.Controls.Add(this.label3);
            this.grptodo.Controls.Add(this.lbldate);
            this.grptodo.Controls.Add(this.btndelete);
            this.grptodo.Controls.Add(this.btnchange);
            this.grptodo.Controls.Add(this.listBox1);
            this.grptodo.Location = new System.Drawing.Point(33, 139);
            this.grptodo.Name = "grptodo";
            this.grptodo.Size = new System.Drawing.Size(726, 284);
            this.grptodo.TabIndex = 8;
            this.grptodo.TabStop = false;
            this.grptodo.Text = "To Do";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(527, 18);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(89, 20);
            this.lbldescription.TabIndex = 6;
            this.lbldescription.Text = "Description";
            // 
            // lblpriolst
            // 
            this.lblpriolst.AutoSize = true;
            this.lblpriolst.Location = new System.Drawing.Point(364, 18);
            this.lblpriolst.Name = "lblpriolst";
            this.lblpriolst.Size = new System.Drawing.Size(56, 20);
            this.lblpriolst.TabIndex = 5;
            this.lblpriolst.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hour";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(37, 17);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(44, 20);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "Date";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(349, 233);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(132, 29);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(79, 234);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(128, 28);
            this.btnchange.TabIndex = 1;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(669, 184);
            this.listBox1.TabIndex = 0;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblClocktimerr
            // 
            this.lblClocktimerr.AutoSize = true;
            this.lblClocktimerr.Location = new System.Drawing.Point(651, 242);
            this.lblClocktimerr.Name = "lblClocktimerr";
            this.lblClocktimerr.Size = new System.Drawing.Size(48, 20);
            this.lblClocktimerr.TabIndex = 9;
            this.lblClocktimerr.Text = "Timer";
            this.lblClocktimerr.Click += new System.EventHandler(this.lblClocktimerr_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.grptodo);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttodo);
            this.Controls.Add(this.lbltodo);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblpriority);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbldatetime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grptodo.ResumeLayout(false);
            this.grptodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblpriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lbltodo;
        private System.Windows.Forms.TextBox txttodo;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox grptodo;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblpriolst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblClocktimerr;
    }
}

