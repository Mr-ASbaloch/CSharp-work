namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox mylist = new ListBox();
            mylist.Location = new Point(12, 12);
            mylist.Size = new Size(245, 199);
            this.Controls.Add(mylist);

            mylist.Items.Add("physics");
            mylist.Items.Add("chemistry");
            mylist.Items.Add("urdu");
            mylist.Items.Add("computer stdudy");

        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
        }
    }
}