namespace RalphMchugh2263Pj7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BinaryTreeNode headOfTree = new BinaryTreeNode("25000", 0);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuildTree_Click(object sender, EventArgs e)
        {
            Random rand = new Random();


            for (int i = 1; i <= Convert.ToInt32(txtBoxBuildTreeIn.Text); i++)
            {
                headOfTree.InsertValIntoSubTree(rand.Next(50000).ToString());
            }
        }

        private void btnInsertVal_Click(object sender, EventArgs e)
        {
            headOfTree.InsertValIntoSubTree(txtBoxInsertValIn.Text);
        }

        private void btnFindNode_Click(object sender, EventArgs e)
        {
            // what a call to call
            MessageBox.Show(headOfTree.value(headOfTree.find(headOfTree, Convert.ToInt32(txtBoxFindNodeIn.Text))));
        }

        private void btnCheckVal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(headOfTree.IsValInSubTree(txtBoxCheckValIn.Text).ToString());
        }

        private void btnInfixString_Click(object sender, EventArgs e)
        {
            rTxtBoxOutput.Text = headOfTree.getStringOfAllInfixValues(headOfTree);
        }

        private void btnSubTree_Click(object sender, EventArgs e)
        {
            rTxtBoxOutput.Text = headOfTree.GetInfixSubTreeString();
        }

        private void btnMaxVal_Click(object sender, EventArgs e)
        {
            lblMaxValOut.Text = ": " + headOfTree.value(headOfTree.maxVal(headOfTree)).ToString();
        }

        private void btnMinVal_Click(object sender, EventArgs e)
        {
            lblMinValOut.Text = ": " + headOfTree.value(headOfTree.minVal(headOfTree)).ToString();
        }

        private void btnMaxDepth_Click(object sender, EventArgs e)
        {
            lblMaxDepthOut.Text = ": " + headOfTree.maxDepth(headOfTree).ToString();
        }

        private void btnMinDepth_Click(object sender, EventArgs e)
        {
            lblMinDepthOut.Text = ": " + headOfTree.minDepth(headOfTree).ToString();
        }



        /*
        
    MessageBox.Show(headOfTree.GetInfixSubTreeString());

            // MessageBox.Show(headOfTree.getStringOfAllInfixValues(headOfTree));
        */

        // Test case is 10k size with range from 0 to 50k cast to strings
        // what is the min/max depth of the resulting tree
        // sort and "regenerate" What happens? 
        // what is the min/max depth of the resulting tree?
    }
}