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
            dgvTV.DataSource = busTV.getThanhVien(); // get thanh vien
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
                    dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvTV.SelectedCells.Count > 0)
            {
                if (txtEmail.Text != "" && txtName.Text != "" && txtSDT.Text != "")
                {
                    // Lấy row hiện tại
                    //DataGridViewRow row = dgvTV.SelectedRows[0];
                    //int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    Customer tv = new Customer(); // Vì ID tự tăng nên để ID số gì cũng dc
                    tv.Id = Convert.ToInt16(dgvTV.Rows[dgvTV.SelectedCells[0].RowIndex].Cells[0].Value.ToString()); ;
                    tv.DisplayName = txtName.Text;
                    tv.PhoneNumber = txtSDT.Text;
                    tv.Email = txtEmail.Text;
                    var check = busTV.suaThanhVien(tv);
                    // Sửa
                    if (check)
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvTV.SelectedCells.Count > 0)
            {
                // Lấy row hiện tại
                int ID = Convert.ToInt16(dgvTV.Rows[dgvTV.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                // Xóa
                if (busTV.xoaThanhVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void dgvTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Lấy row hiện tại
            /////DataGridViewRow row = dgvTV.SelectedRows[0];
            int row = dgvTV.SelectedCells[0].RowIndex;
            //// Chuyển giá trị lên form
            txtName.Text = dgvTV.Rows[row].Cells[1].Value.ToString();
            txtSDT.Text = dgvTV.Rows[row].Cells[3].Value.ToString();
            txtEmail.Text = dgvTV.Rows[row].Cells[4].Value.ToString();
            //// Chuyển giá trị lên form
            //txtName.Text = row.Cells[1].Value.ToString();
            //txtSDT.Text = row.Cells[3].Value.ToString();
            //txtEmail.Text = row.Cells[4].Value.ToString();
        }

        private void dgvTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = dgvTV.SelectedCells[0].RowIndex;
            txtName.Text = dgvTV.Rows[row].Cells[1].Value.ToString();
            txtSDT.Text = dgvTV.Rows[row].Cells[3].Value.ToString();
            txtEmail.Text = dgvTV.Rows[row].Cells[4].Value.ToString();
        }
    }
}