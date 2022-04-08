using System.Xml.Serialization;
using System.Xml;

namespace RecordsManager
{
    public partial class frmMain : Form
    {
        public List<Record> records;
        FileStream file = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //New Records Creation
        private void openRecordsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(file == null)
            {
                DialogResult result;
                string filename;
                
                using (SaveFileDialog fileChooser =  new SaveFileDialog())
                {
                    fileChooser.CheckFileExists = false;
                    fileChooser.AddExtension = true;
                    fileChooser.DefaultExt = "record";

                    result = fileChooser.ShowDialog();
                    filename = fileChooser.FileName;
                }

                if(result == DialogResult.OK)
                {
                    if(string.IsNullOrEmpty(filename))
                    {
                        MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                            lblFileOpen.Text = "File Opened: " + filename;
                        }
                        catch(IOException)
                        {
                            MessageBox.Show("Error Opening File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void createRecordsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveRecordsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}