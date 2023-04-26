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
            this.SuspendLayout();
            // 
            // create_event
            // 
            this.create_event.Location = new System.Drawing.Point(134, 61);
            this.create_event.Name = "create_event";
            this.create_event.Size = new System.Drawing.Size(136, 23);
            this.create_event.TabIndex = 0;
            this.create_event.Text = "Create Event";
            this.create_event.UseVisualStyleBackColor = true;
            this.create_event.Click += new System.EventHandler(this.create_event_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_event);
            this.Name = "UserHome";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_event;
    }
}