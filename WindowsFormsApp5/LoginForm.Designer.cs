namespace WindowsFormsApp5
{
    partial class Login_form
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
            this.userName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Verify = new System.Windows.Forms.Label();
            this.IsPO = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(161, 184);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(189, 20);
            this.userName.TabIndex = 0;
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(161, 224);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(189, 20);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.Location = new System.Drawing.Point(211, 325);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(0, 13);
            this.Verify.TabIndex = 5;
            this.Verify.Click += new System.EventHandler(this.label3_Click);
            // 
            // IsPO
            // 
            this.IsPO.AutoSize = true;
            this.IsPO.Location = new System.Drawing.Point(161, 250);
            this.IsPO.Name = "IsPO";
            this.IsPO.Size = new System.Drawing.Size(107, 17);
            this.IsPO.TabIndex = 6;
            this.IsPO.Text = "I am place owner";
            this.IsPO.UseVisualStyleBackColor = true;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.IsPO);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.userName);
            this.Name = "Login_form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Verify;
        private System.Windows.Forms.CheckBox IsPO;
    }
}