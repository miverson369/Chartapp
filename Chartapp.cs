namespace Chartapp
{
    public partial class Chartapp : Form
    {
        private string _filePath = "";
        private string _rawfile = "";
        private string _rawFile;
        private List<string> _lines = new List<string>();
        public Chartapp() => InitializeComponent();

        private void BtnOpenFile_Click(object sender, EventArgs e)
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
                    
                    var fileStream = openFileDialog.OpenFile();

                    StreamReader StreamReader = new StreamReader(fileStream);
                    using StreamReader reader = StreamReader;
                    _rawFile = reader.ReadToEnd();
                    while (reader.Peek() >= 0)
                    {
                        _lines.Add(reader.ReadLine());
                    }
                    //MessageBox.Show(_filePath);
                }
            }
        }
    }
}