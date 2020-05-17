using System;
using System.IO;
using System.Windows.Forms;

namespace WF_15
{
    public partial class FolderManager : Form
    {
        public FolderManager()
        {
            InitializeComponent();
            listView1.ContextMenuStrip = contextMenuStrip1;
        }
      
       
        TreeNode rootNode;
        private void GreateTree(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name); 
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode); 
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void browseToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog of = new FolderBrowserDialog();
            var dialogResult = of.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBox1.Text = of.SelectedPath;
                GreateTree(of.SelectedPath);
            }
        }
        DirectoryInfo[] subSubDirs;
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0); 
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                    GetDirectories(subSubDirs, aNode);               
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "Directory") };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(new string[] { file.Name, "File", (file.Length / 1000).ToString() + " KB" }, 0);
                subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "File") };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("File name");
            listView1.Columns.Add("Type");
            listView1.Columns.Add("Size");
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void FolderManager_Load(object sender, EventArgs e)
        {

        }

    }
}
