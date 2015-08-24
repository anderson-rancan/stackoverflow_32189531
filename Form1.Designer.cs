namespace MDI_MultFormEvent
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
            this.button1st = new System.Windows.Forms.Button();
            this.button2nd = new System.Windows.Forms.Button();
            this.checkBox1st = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1st
            // 
            this.button1st.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1st.Location = new System.Drawing.Point(94, 67);
            this.button1st.Name = "button1st";
            this.button1st.Size = new System.Drawing.Size(97, 23);
            this.button1st.TabIndex = 3;
            this.button1st.Text = "1st button";
            this.button1st.UseVisualStyleBackColor = true;
            this.button1st.Click += new System.EventHandler(this.button1st_Click);
            // 
            // button2nd
            // 
            this.button2nd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2nd.Location = new System.Drawing.Point(94, 171);
            this.button2nd.Name = "button2nd";
            this.button2nd.Size = new System.Drawing.Size(97, 23);
            this.button2nd.TabIndex = 5;
            this.button2nd.Text = "2nd button";
            this.button2nd.UseVisualStyleBackColor = true;
            // 
            // checkBox1st
            // 
            this.checkBox1st.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1st.AutoSize = true;
            this.checkBox1st.Location = new System.Drawing.Point(97, 122);
            this.checkBox1st.Name = "checkBox1st";
            this.checkBox1st.Size = new System.Drawing.Size(90, 17);
            this.checkBox1st.TabIndex = 4;
            this.checkBox1st.Text = "1st checkbox";
            this.checkBox1st.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button2nd);
            this.Controls.Add(this.checkBox1st);
            this.Controls.Add(this.button1st);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1st;
        private System.Windows.Forms.Button button2nd;
        private System.Windows.Forms.CheckBox checkBox1st;

    }
}