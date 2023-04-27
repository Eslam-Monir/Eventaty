
namespace WindowsFormsApp5
{
    partial class Comment
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
            this.texB = new System.Windows.Forms.TextBox();
            this.Sub_Comment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texB
            // 
            this.texB.Location = new System.Drawing.Point(12, 12);
            this.texB.Multiline = true;
            this.texB.Name = "texB";
            this.texB.Size = new System.Drawing.Size(412, 122);
            this.texB.TabIndex = 0;
            // 
            // Sub_Comment
            // 
            this.Sub_Comment.Location = new System.Drawing.Point(273, 241);
            this.Sub_Comment.Name = "Sub_Comment";
            this.Sub_Comment.Size = new System.Drawing.Size(293, 36);
            this.Sub_Comment.TabIndex = 1;
            this.Sub_Comment.Text = "Submit";
            this.Sub_Comment.UseVisualStyleBackColor = true;
            this.Sub_Comment.Click += new System.EventHandler(this.Sub_Comment_Click);
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sub_Comment);
            this.Controls.Add(this.texB);
            this.Name = "Comment";
            this.Text = "Comment";
            this.Load += new System.EventHandler(this.Comment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texB;
        private System.Windows.Forms.Button Sub_Comment;
    }
}