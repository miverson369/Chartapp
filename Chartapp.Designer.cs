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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
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

        #endregion

        private Button button1;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //open a file dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //set the properties on the filedialog
                openFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Data");
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                //open the filedialog and do something
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //process the file information
                    _filePath = openFileDialog.FileName;
                    MessageBox.Show(_filePath);
                }

                
            }
        }   
    }
}
