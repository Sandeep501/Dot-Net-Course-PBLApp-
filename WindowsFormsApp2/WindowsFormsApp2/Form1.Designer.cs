namespace WindowsFormsApp2
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
            this.Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Click
            // 
            this.Click.BackColor = System.Drawing.SystemColors.Window;
            this.Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click.Location = new System.Drawing.Point(341, 170);
            this.Click.Name = "Click";
            this.Click.Padding = new System.Windows.Forms.Padding(4);
            this.Click.Size = new System.Drawing.Size(100, 35);
            this.Click.TabIndex = 0;
            this.Click.Text = "Click";
            this.Click.UseVisualStyleBackColor = false;
            this.Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Click;
    }
}

