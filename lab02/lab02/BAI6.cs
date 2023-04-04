using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab02
{
    public partial class BAI6 : Form
    {
        public BAI6()
        {
            InitializeComponent();
        }

        private void BAI6_Load(object sender, EventArgs e)
        {
            // Lấy danh sách ổ đĩa trên máy tính
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Thêm ổ đĩa vào TreeView
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory;
                driveNode.Nodes.Add(new TreeNode());
                treeView1.Nodes.Add(driveNode);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Lấy danh sách thư mục con và tạo nút cho chúng
            TreeNode selectedNode = e.Node;
            if (selectedNode.Tag != null)
            {
                DirectoryInfo selectedDir = (DirectoryInfo)selectedNode.Tag;
                selectedNode.Nodes.Clear();
                foreach (DirectoryInfo dir in selectedDir.GetDirectories())
                {
                    TreeNode dirNode = new TreeNode(dir.Name);
                    dirNode.Tag = dir;
                    dirNode.Nodes.Add("");
                    selectedNode.Nodes.Add(dirNode);
                }

                // Lấy danh sách file trong thư mục
                foreach (FileInfo file in selectedDir.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file;
                    selectedNode.Nodes.Add(fileNode);
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string filePath = e.Node.FullPath;
            /*if (File.Exists(filePath))
            {
                treeView1.Nodes.Add(e.Node.FullPath);
            }*/
            // Nếu đối tượng được chọn là một tệp tin
            if (e.Node.Tag is FileInfo)
            {
                // Đọc nội dung của tệp tin và hiển thị trong RichTextBox
                FileInfo file = (FileInfo)e.Node.Tag;
                if (file.Extension.Equals(".txt"))
                {
                        richTextBox1.LoadFile(file.FullName, RichTextBoxStreamType.PlainText);
                    
                }
                else if (file.Extension.Equals(".jpg") || file.Extension.Equals(".png"))
                {
                    // Hiển thị ảnh
                    Image image = Image.FromFile(file.FullName);
                    Clipboard.SetImage(image);
                    richTextBox1.Paste();
                }
            }
        }
    }
}
