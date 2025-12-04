using System;
using System.Windows.Forms;

namespace BT3cpp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CaiDatListView();
            ThemDuLieuMau();
        }

        // ============================
        // CẤU HÌNH LISTVIEW
        // ============================
        void CaiDatListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();
            listView1.Columns.Add("Last Name", 120);
            listView1.Columns.Add("First Name", 120);
            listView1.Columns.Add("Phone", 120);
        }

        // ============================
        // DỮ LIỆU MẪU GIỐNG BÀI THẦY
        // ============================
        void ThemDuLieuMau()
        {
            ListViewItem item1 = new ListViewItem("Ly");
            item1.SubItems.Add("Thi Bong");
            item1.SubItems.Add("23456");
            listView1.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Nguyen");
            item2.SubItems.Add("Van Chinh");
            item2.SubItems.Add("4555");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Tran");
            item3.SubItems.Add("Chanh Truc");
            item3.SubItems.Add("123456");
            listView1.Items.Add(item3);
        }

        // ============================
        // NÚT ADD NAME
        // ============================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem item = new ListViewItem(txtLastName.Text);
            item.SubItems.Add(txtFirstName.Text);
            item.SubItems.Add(txtPhone.Text);

            listView1.Items.Add(item);

            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
        }

        // ============================
        // CLICK LISTVIEW → ĐỔ THÔNG TIN LÊN TEXTBOX
        // ============================
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtLastName.Text = item.SubItems[0].Text;
                txtFirstName.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }

        // ============================
        // MENU VIEW → DETAILS
        // ============================
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}