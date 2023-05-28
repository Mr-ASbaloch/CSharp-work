using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void Form1_Load_1(object sender, EventArgs e)
        {
            treeView1.CheckBoxes = true;
            TreeNode tNode;
            tNode = treeView1.Nodes.Add("gcuf");
        }
    }
}