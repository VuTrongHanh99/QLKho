using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho_app
{
    public partial class QLObject : Form
    {
        BUS_Object bus;
        public QLObject()
        {
            InitializeComponent();
            bus = new BUS_Object();
        }

        private void QLObject_Load(object sender, EventArgs e)
        {
            dgvObject.DataSource = bus.getObject(); // get thanh vien
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text != "" && txtName.Text != "" && txtBarcode.Text != "")
            {
                // Tạo DTo
                NetCore.Domain.Entities.Object tv = new NetCore.Domain.Entities.Object(); // Vì ID tự tăng nên để ID số gì cũng dc
                tv.DisplayName = txtName.Text;
                tv.QRCode = txtQRcode.Text;
                tv.BarCode = txtBarcode.Text;
                // Them
                if (bus.themObject(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvObject.DataSource = bus.getObject(); // refresh datagridview
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
            if (dgvObject.SelectedCells.Count > 0)
            {
                if (txtName.Text != "")
                {
                    // Tạo DTo
                    NetCore.Domain.Entities.Object unit = new NetCore.Domain.Entities.Object(); // Vì ID tự tăng nên để ID số gì cũng dc
                    unit.Id = Convert.ToInt16(dgvObject.Rows[dgvObject.SelectedCells[0].RowIndex].Cells[0].Value.ToString()); ;
                    unit.DisplayName = txtName.Text;
                    unit.QRCode = txtQRcode.Text;
                    unit.BarCode = txtBarcode.Text;
                    // Sửa
                    if (bus.suaObject(unit))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvObject.DataSource = bus.getObject(); // refresh datagridview
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

        private void dgvObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Lấy row hiện tại
            int row = dgvObject.SelectedCells[0].RowIndex;
            //// Chuyển giá trị lên form
            txtName.Text = dgvObject.Rows[row].Cells[1].Value.ToString();
            txtQRcode.Text = dgvObject.Rows[row].Cells[2].Value.ToString();
            txtBarcode.Text = dgvObject.Rows[row].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvObject.SelectedCells.Count > 0)
            {
                // Lấy row hiện tại
                int ID = Convert.ToInt16(dgvObject.Rows[dgvObject.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                // Xóa
                if (bus.xoaObject(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvObject.DataSource = bus.getObject(); // refresh datagridview
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
    }
}
