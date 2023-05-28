namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            TreeNode tNode;
            tNode = treeView1.Nodes.Add("gcuf");
            treeView1.Nodes[0].Nodes.Add("depart");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("room");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.FullPath.ToString());
         
        }
    }
}