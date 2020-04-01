namespace Face_identifcation
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-2, -4);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Node1";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Node2";
            treeNode13.Name = "Node3";
            treeNode13.Text = "Node3";
            treeNode14.Name = "Node4";
            treeNode14.Text = "Node4";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Node0";
            treeNode16.Name = "Node6";
            treeNode16.Text = "Node6";
            treeNode17.Name = "Node7";
            treeNode17.Text = "Node7";
            treeNode18.Name = "Node8";
            treeNode18.Text = "Node8";
            treeNode19.Name = "Node9";
            treeNode19.Text = "Node9";
            treeNode20.Name = "Node5";
            treeNode20.Text = "Node5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(187, 452);
            this.treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(191, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 166);
            this.panel1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(197, 200);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 374);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 448);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}