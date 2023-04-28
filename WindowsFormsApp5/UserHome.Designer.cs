namespace WindowsFormsApp5
{
    partial class UserHome
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
            this.create_event = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_comment = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.enroll_event = new System.Windows.Forms.Button();
            this.manage_categories = new System.Windows.Forms.Button();
            this.comments = new System.Windows.Forms.ListView();
            this.comment_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create_event
            // 
            this.create_event.Location = new System.Drawing.Point(339, 391);
            this.create_event.Margin = new System.Windows.Forms.Padding(4);
            this.create_event.Name = "create_event";
            this.create_event.Size = new System.Drawing.Size(111, 28);
            this.create_event.TabIndex = 23;
            this.create_event.Text = "Create Event";
            this.create_event.UseVisualStyleBackColor = true;
            this.create_event.Click += new System.EventHandler(this.create_event_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Location :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Categories :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 15;
            // 
            // add_comment
            // 
            this.add_comment.Location = new System.Drawing.Point(632, 279);
            this.add_comment.Margin = new System.Windows.Forms.Padding(4);
            this.add_comment.Name = "add_comment";
            this.add_comment.Size = new System.Drawing.Size(116, 28);
            this.add_comment.TabIndex = 14;
            this.add_comment.Text = "Add Comment";
            this.add_comment.UseVisualStyleBackColor = true;
            this.add_comment.Click += new System.EventHandler(this.add_comment_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(151, 308);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // enroll_event
            // 
            this.enroll_event.Location = new System.Drawing.Point(151, 391);
            this.enroll_event.Margin = new System.Windows.Forms.Padding(4);
            this.enroll_event.Name = "enroll_event";
            this.enroll_event.Size = new System.Drawing.Size(111, 28);
            this.enroll_event.TabIndex = 24;
            this.enroll_event.Text = "Enroll Event";
            this.enroll_event.UseVisualStyleBackColor = true;
            this.enroll_event.Click += new System.EventHandler(this.enroll_event_Click);
            // 
            // manage_categories
            // 
            this.manage_categories.Location = new System.Drawing.Point(514, 391);
            this.manage_categories.Margin = new System.Windows.Forms.Padding(4);
            this.manage_categories.Name = "manage_categories";
            this.manage_categories.Size = new System.Drawing.Size(131, 28);
            this.manage_categories.TabIndex = 25;
            this.manage_categories.Text = "Manage Categories";
            this.manage_categories.UseVisualStyleBackColor = true;
            this.manage_categories.Click += new System.EventHandler(this.manage_categories_Click);
            // 
            // comments
            // 
            this.comments.AutoArrange = false;
            this.comments.HideSelection = false;
            this.comments.Location = new System.Drawing.Point(573, 42);
            this.comments.Margin = new System.Windows.Forms.Padding(4);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(222, 156);
            this.comments.TabIndex = 26;
            this.comments.UseCompatibleStateImageBehavior = false;
            // 
            // comment_txt
            // 
            this.comment_txt.Location = new System.Drawing.Point(579, 233);
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(209, 24);
            this.comment_txt.TabIndex = 27;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.comment_txt);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.manage_categories);
            this.Controls.Add(this.enroll_event);
            this.Controls.Add(this.create_event);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_comment);
            this.Controls.Add(this.listView1);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_event;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_comment;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button enroll_event;
        private System.Windows.Forms.Button manage_categories;
        private System.Windows.Forms.ListView comments;
        private System.Windows.Forms.TextBox comment_txt;
    }
}