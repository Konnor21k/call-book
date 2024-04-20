namespace call_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {

                ListViewItem item = new ListViewItem(textBox1.Text);

                item.SubItems.Add(textBox2.Text);
                item.SubItems.Add(textBox3.Text);

                listView1.Items.Add(item);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("¬ведите данные");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files (*.txt)|*txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(selectedFilePath))
                {
                    foreach (var item in listView1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
        }
    }
}
