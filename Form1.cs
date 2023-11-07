namespace RalphMchugh2263Pj7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buildTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            BinaryTreeNode headOfTree = new BinaryTreeNode("25000");
            
            for(int i = 1; i <= 10; i++) {
                headOfTree.InsertValIntoSubTree(rand.Next(50000).ToString());
            }
            MessageBox.Show(headOfTree.GetInfixSubTreeString());
        }

        // Test case is 10k size with range from 0 to 50k cast to strings
        // what is the min/max depth of the resulting tree
        // sort and "regenerate" What happens? 
        // what is the min/max depth of the resulting tree?
    }
}