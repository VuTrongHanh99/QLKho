using BUS;
using NetCore.Domain.Entities;

namespace QLKho_app
{
    public partial class Form1 : Form
    {
        BUS_Customer busTV;
        public Form1()
        {
            InitializeComponent();
            busTV = new BUS_Customer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtName.Text != "" && txtSDT.Text != "")
            {
                // Tạo DTo
                Customer tv = new Customer(); // Vì ID tự tăng nên để ID số gì cũng dc
                tv.DisplayName = txtName.Text;
                tv.PhoneNumber = txtSDT.Text;
                tv.Email = txtEmail.Text;
                // Them
                if (busTV.themThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}