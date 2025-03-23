namespace Chartapp
{
    partial class Chartapp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent(object button1) => throw new NotImplementedException();

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button button1)
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 34);
            button1.TabIndex = 0;
            button1.Text = "Open File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.opendialog;
            // 
            // Chartapp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Chartapp";
            Text = "Chartapp";
            ResumeLayout(false);
        }

        private void opendialog(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}   