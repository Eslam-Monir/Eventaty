namespace WindowsFormsApp5
{
    partial class Create_Event
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
            this.event_attendeelimit = new System.Windows.Forms.TextBox();
            this.event_description = new System.Windows.Forms.TextBox();
            this.event_date = new System.Windows.Forms.TextBox();
            this.event_time = new System.Windows.Forms.TextBox();
            this.event_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.event_location = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.event_categ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // event_attendeelimit
            // 
            this.event_attendeelimit.Location = new System.Drawing.Point(344, 154);
            this.event_attendeelimit.Name = "event_attendeelimit";
            this.event_attendeelimit.Size = new System.Drawing.Size(84, 20);
            this.event_attendeelimit.TabIndex = 37;
            // 
            // event_description
            // 
            this.event_description.Location = new System.Drawing.Point(446, 154);
            this.event_description.Name = "event_description";
            this.event_description.Size = new System.Drawing.Size(84, 20);
            this.event_description.TabIndex = 35;
            // 
            // event_date
            // 
            this.event_date.Location = new System.Drawing.Point(118, 154);
            this.event_date.Name = "event_date";
            this.event_date.Size = new System.Drawing.Size(84, 20);
            this.event_date.TabIndex = 34;
            // 
            // event_time
            // 
            this.event_time.Location = new System.Drawing.Point(223, 154);
            this.event_time.Name = "event_time";
            this.event_time.Size = new System.Drawing.Size(84, 20);
            this.event_time.TabIndex = 33;
            // 
            // event_name
            // 
            this.event_name.Location = new System.Drawing.Point(12, 154);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(84, 20);
            this.event_name.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "AttendeeLimit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Event Categories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Event description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Event Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Event Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Event Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Event Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-63, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Create Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(16, 413);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 38;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // event_location
            // 
            this.event_location.FormattingEnabled = true;
            this.event_location.Location = new System.Drawing.Point(684, 154);
            this.event_location.Name = "event_location";
            this.event_location.Size = new System.Drawing.Size(91, 21);
            this.event_location.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DodgerBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.GhostWhite;
            this.label9.Location = new System.Drawing.Point(299, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "Create your event!";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // event_categ
            // 
            this.event_categ.FormattingEnabled = true;
            this.event_categ.Location = new System.Drawing.Point(566, 154);
            this.event_categ.Name = "event_categ";
            this.event_categ.Size = new System.Drawing.Size(91, 21);
            this.event_categ.TabIndex = 41;
            this.event_categ.SelectedIndexChanged += new System.EventHandler(this.event_categ_SelectedIndexChanged);
            // 
            // Create_Event
            // 
            this.ClientSize = new System.Drawing.Size(793, 448);
            this.Controls.Add(this.event_categ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.event_location);
            this.Controls.Add(this.back);
            this.Controls.Add(this.event_attendeelimit);
            this.Controls.Add(this.event_description);
            this.Controls.Add(this.event_date);
            this.Controls.Add(this.event_time);
            this.Controls.Add(this.event_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Create_Event";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox event_attendeelimit;
        private System.Windows.Forms.TextBox event_description;
        private System.Windows.Forms.TextBox event_date;
        private System.Windows.Forms.TextBox event_time;
        private System.Windows.Forms.TextBox event_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox event_location;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox event_categ;
    }
}