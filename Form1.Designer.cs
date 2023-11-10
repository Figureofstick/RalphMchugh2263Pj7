namespace RalphMchugh2263Pj7
{
    partial class Form1
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
            btnBuildTree = new Button();
            btnFindNode = new Button();
            btnCheckVal = new Button();
            btnMinDepth = new Button();
            btnMaxVal = new Button();
            btnMinVal = new Button();
            txtBoxBuildTreeIn = new TextBox();
            btnMaxDepth = new Button();
            btnInfixString = new Button();
            btnSubTree = new Button();
            lblMaxValOut = new Label();
            lblMinValOut = new Label();
            lblMaxDepthOut = new Label();
            lblMinDepthOut = new Label();
            txtBoxFindNodeIn = new TextBox();
            txtBoxCheckValIn = new TextBox();
            rTxtBoxOutput = new RichTextBox();
            btnInsertVal = new Button();
            txtBoxInsertValIn = new TextBox();
            SuspendLayout();
            // 
            // btnBuildTree
            // 
            btnBuildTree.Location = new Point(35, 26);
            btnBuildTree.Name = "btnBuildTree";
            btnBuildTree.Size = new Size(75, 23);
            btnBuildTree.TabIndex = 0;
            btnBuildTree.Text = "Build Tree";
            btnBuildTree.UseVisualStyleBackColor = true;
            btnBuildTree.Click += btnBuildTree_Click;
            // 
            // btnFindNode
            // 
            btnFindNode.Location = new Point(35, 77);
            btnFindNode.Name = "btnFindNode";
            btnFindNode.Size = new Size(75, 23);
            btnFindNode.TabIndex = 1;
            btnFindNode.Text = "Find Node";
            btnFindNode.UseVisualStyleBackColor = true;
            btnFindNode.Click += btnFindNode_Click;
            // 
            // btnCheckVal
            // 
            btnCheckVal.Location = new Point(35, 123);
            btnCheckVal.Name = "btnCheckVal";
            btnCheckVal.Size = new Size(168, 23);
            btnCheckVal.TabIndex = 2;
            btnCheckVal.Text = "Is the value in the (sub)tree?";
            btnCheckVal.UseVisualStyleBackColor = true;
            btnCheckVal.Click += btnCheckVal_Click;
            // 
            // btnMinDepth
            // 
            btnMinDepth.Location = new Point(485, 164);
            btnMinDepth.Name = "btnMinDepth";
            btnMinDepth.Size = new Size(75, 23);
            btnMinDepth.TabIndex = 3;
            btnMinDepth.Text = "Min Depth";
            btnMinDepth.UseVisualStyleBackColor = true;
            btnMinDepth.Click += btnMinDepth_Click;
            // 
            // btnMaxVal
            // 
            btnMaxVal.Location = new Point(485, 77);
            btnMaxVal.Name = "btnMaxVal";
            btnMaxVal.Size = new Size(75, 23);
            btnMaxVal.TabIndex = 4;
            btnMaxVal.Text = "Max Value";
            btnMaxVal.UseVisualStyleBackColor = true;
            btnMaxVal.Click += btnMaxVal_Click;
            // 
            // btnMinVal
            // 
            btnMinVal.Location = new Point(485, 106);
            btnMinVal.Name = "btnMinVal";
            btnMinVal.Size = new Size(75, 23);
            btnMinVal.TabIndex = 5;
            btnMinVal.Text = "Min Value";
            btnMinVal.UseVisualStyleBackColor = true;
            btnMinVal.Click += btnMinVal_Click;
            // 
            // txtBoxBuildTreeIn
            // 
            txtBoxBuildTreeIn.Location = new Point(133, 26);
            txtBoxBuildTreeIn.Name = "txtBoxBuildTreeIn";
            txtBoxBuildTreeIn.Size = new Size(100, 23);
            txtBoxBuildTreeIn.TabIndex = 6;
            txtBoxBuildTreeIn.Text = "Tree Size Input";
            // 
            // btnMaxDepth
            // 
            btnMaxDepth.Location = new Point(485, 135);
            btnMaxDepth.Name = "btnMaxDepth";
            btnMaxDepth.Size = new Size(75, 23);
            btnMaxDepth.TabIndex = 7;
            btnMaxDepth.Text = "Max Depth";
            btnMaxDepth.UseVisualStyleBackColor = true;
            btnMaxDepth.Click += btnMaxDepth_Click;
            // 
            // btnInfixString
            // 
            btnInfixString.Location = new Point(35, 164);
            btnInfixString.Name = "btnInfixString";
            btnInfixString.Size = new Size(168, 23);
            btnInfixString.TabIndex = 8;
            btnInfixString.Text = "Infix String of Values";
            btnInfixString.UseVisualStyleBackColor = true;
            btnInfixString.Click += btnInfixString_Click;
            // 
            // btnSubTree
            // 
            btnSubTree.Location = new Point(35, 209);
            btnSubTree.Name = "btnSubTree";
            btnSubTree.Size = new Size(168, 23);
            btnSubTree.TabIndex = 9;
            btnSubTree.Text = "(Ugly) String of Values ";
            btnSubTree.UseVisualStyleBackColor = true;
            btnSubTree.Click += btnSubTree_Click;
            // 
            // lblMaxValOut
            // 
            lblMaxValOut.AutoSize = true;
            lblMaxValOut.Location = new Point(584, 81);
            lblMaxValOut.Name = "lblMaxValOut";
            lblMaxValOut.Size = new Size(49, 15);
            lblMaxValOut.TabIndex = 10;
            lblMaxValOut.Text = ": (value)";
            // 
            // lblMinValOut
            // 
            lblMinValOut.AutoSize = true;
            lblMinValOut.Location = new Point(584, 110);
            lblMinValOut.Name = "lblMinValOut";
            lblMinValOut.Size = new Size(49, 15);
            lblMinValOut.TabIndex = 11;
            lblMinValOut.Text = ": (value)";
            // 
            // lblMaxDepthOut
            // 
            lblMaxDepthOut.AutoSize = true;
            lblMaxDepthOut.Location = new Point(584, 139);
            lblMaxDepthOut.Name = "lblMaxDepthOut";
            lblMaxDepthOut.Size = new Size(52, 15);
            lblMaxDepthOut.TabIndex = 12;
            lblMaxDepthOut.Text = ": (depth)";
            // 
            // lblMinDepthOut
            // 
            lblMinDepthOut.AutoSize = true;
            lblMinDepthOut.Location = new Point(584, 168);
            lblMinDepthOut.Name = "lblMinDepthOut";
            lblMinDepthOut.Size = new Size(52, 15);
            lblMinDepthOut.TabIndex = 13;
            lblMinDepthOut.Text = ": (depth)";
            // 
            // txtBoxFindNodeIn
            // 
            txtBoxFindNodeIn.Location = new Point(133, 77);
            txtBoxFindNodeIn.Name = "txtBoxFindNodeIn";
            txtBoxFindNodeIn.Size = new Size(120, 23);
            txtBoxFindNodeIn.TabIndex = 14;
            txtBoxFindNodeIn.Text = "Node (value) to find";
            // 
            // txtBoxCheckValIn
            // 
            txtBoxCheckValIn.Location = new Point(220, 123);
            txtBoxCheckValIn.Name = "txtBoxCheckValIn";
            txtBoxCheckValIn.Size = new Size(100, 23);
            txtBoxCheckValIn.TabIndex = 15;
            txtBoxCheckValIn.Text = "Value to check";
            // 
            // rTxtBoxOutput
            // 
            rTxtBoxOutput.Location = new Point(35, 238);
            rTxtBoxOutput.Name = "rTxtBoxOutput";
            rTxtBoxOutput.Size = new Size(698, 184);
            rTxtBoxOutput.TabIndex = 16;
            rTxtBoxOutput.Text = "Click one of the string buttons";
            // 
            // btnInsertVal
            // 
            btnInsertVal.Location = new Point(275, 26);
            btnInsertVal.Name = "btnInsertVal";
            btnInsertVal.Size = new Size(75, 23);
            btnInsertVal.TabIndex = 17;
            btnInsertVal.Text = "Insert Value";
            btnInsertVal.UseVisualStyleBackColor = true;
            btnInsertVal.Click += btnInsertVal_Click;
            // 
            // txtBoxInsertValIn
            // 
            txtBoxInsertValIn.Location = new Point(370, 26);
            txtBoxInsertValIn.Name = "txtBoxInsertValIn";
            txtBoxInsertValIn.Size = new Size(100, 23);
            txtBoxInsertValIn.TabIndex = 18;
            txtBoxInsertValIn.Text = "Tree Size Input";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxInsertValIn);
            Controls.Add(btnInsertVal);
            Controls.Add(rTxtBoxOutput);
            Controls.Add(txtBoxCheckValIn);
            Controls.Add(txtBoxFindNodeIn);
            Controls.Add(lblMinDepthOut);
            Controls.Add(lblMaxDepthOut);
            Controls.Add(lblMinValOut);
            Controls.Add(lblMaxValOut);
            Controls.Add(btnSubTree);
            Controls.Add(btnInfixString);
            Controls.Add(btnMaxDepth);
            Controls.Add(txtBoxBuildTreeIn);
            Controls.Add(btnMinVal);
            Controls.Add(btnMaxVal);
            Controls.Add(btnMinDepth);
            Controls.Add(btnCheckVal);
            Controls.Add(btnFindNode);
            Controls.Add(btnBuildTree);
            Name = "Form1";
            Text = "Ralph McHugh - Binary Search Tree and Display - Pj 7";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuildTree;
        private Button btnFindNode;
        private Button btnCheckVal;
        private Button btnMinDepth;
        private Button btnMaxVal;
        private Button btnMinVal;
        private TextBox txtBoxBuildTreeIn;
        private Button btnMaxDepth;
        private Button btnInfixString;
        private Button btnSubTree;
        private Label lblMaxValOut;
        private Label lblMinValOut;
        private Label lblMaxDepthOut;
        private Label lblMinDepthOut;
        private TextBox txtBoxFindNodeIn;
        private TextBox txtBoxCheckValIn;
        private RichTextBox rTxtBoxOutput;
        private Button btnInsertVal;
        private TextBox txtBoxInsertValIn;
    }
}