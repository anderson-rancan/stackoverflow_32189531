namespace MDI_MultFormEvent
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
            this.button3rd = new System.Windows.Forms.Button();
            this.button4th = new System.Windows.Forms.Button();
            this.checkBox2nd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button3rd
            // 
            this.button3rd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3rd.Location = new System.Drawing.Point(94, 68);
            this.button3rd.Name = "button3rd";
            this.button3rd.Size = new System.Drawing.Size(97, 23);
            this.button3rd.TabIndex = 0;
            this.button3rd.Text = "3rd button";
            this.button3rd.UseVisualStyleBackColor = true;
            this.button3rd.Click += new System.EventHandler(this.button3rd_Click);
            // 
            // button4th
            // 
            this.button4th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4th.Location = new System.Drawing.Point(94, 122);
            this.button4th.Name = "button4th";
            this.button4th.Size = new System.Drawing.Size(97, 23);
            this.button4th.TabIndex = 0;
            this.button4th.Text = "4th button";
            this.button4th.UseVisualStyleBackColor = true;
            // 
            // checkBox2nd
            // 
            this.checkBox2nd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2nd.AutoSize = true;
            this.checkBox2nd.Location = new System.Drawing.Point(95, 176);
            this.checkBox2nd.Name = "checkBox2nd";
            this.checkBox2nd.Size = new System.Drawing.Size(94, 17);
            this.checkBox2nd.TabIndex = 1;
            this.checkBox2nd.Text = "2nd checkbox";
            this.checkBox2nd.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox2nd);
            this.Controls.Add(this.button4th);
            this.Controls.Add(this.button3rd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3rd;
        private System.Windows.Forms.Button button4th;
        private System.Windows.Forms.CheckBox checkBox2nd;
    }
}