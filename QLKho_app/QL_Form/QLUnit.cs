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
    public partial class QLUnit : Form
    {
        BUS_Unit busUnit;
        public QLUnit()
        {
            InitializeComponent();
            busUnit = new BUS_Unit();
        }

        private void QLUnit_Load(object sender, EventArgs e)
        {
            dgvUnit.DataSource = busUnit.getUnit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                // Tạo DTo
                NetCore.Domain.Entities.Unit unit = new NetCore.Domain.Entities.Unit(); // Vì ID tự tăng nên để ID số gì cũng dc
                unit.DisplayName = txtName.Text;
                // Them
                if (busUnit.themUnit(unit))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvUnit.DataSource = busUnit.getUnit(); // refresh datagridview
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
            if (dgvUnit.SelectedCells.Count > 0)
            {
                if (txtName.Text != "")
                {
                    // Tạo DTo
                    NetCore.Domain.Entities.Unit unit = new NetCore.Domain.Entities.Unit(); // Vì ID tự tăng nên để ID số gì cũng dc
                    unit.Id = Convert.ToInt16(dgvUnit.Rows[dgvUnit.SelectedCells[0].RowIndex].Cells[0].Value.ToString()); ;
                    unit.DisplayName = txtName.Text;
                    // Sửa
                    if (busUnit.suaUnit(unit))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvUnit.DataSource = busUnit.getUnit(); // refresh datagridview
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
            if (dgvUnit.SelectedCells.Count > 0)
            {
                // Lấy row hiện tại
                int ID = Convert.ToInt16(dgvUnit.Rows[dgvUnit.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                // Xóa
                if (busUnit.xoaUnit(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvUnit.DataSource = busUnit.getUnit(); // refresh datagridview
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

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Lấy row hiện tại
            int row = dgvUnit.SelectedCells[0].RowIndex;
            //// Chuyển giá trị lên form
            txtName.Text = dgvUnit.Rows[row].Cells[1].Value.ToString();
        }
    }
}
