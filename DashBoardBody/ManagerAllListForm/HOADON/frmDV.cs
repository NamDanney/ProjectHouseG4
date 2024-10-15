using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentHouse.DashBoardBody.ManagerAllListForm.HOADON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenDV.Text) &&
       !string.IsNullOrWhiteSpace(txtMaDV.Text) &&
       !string.IsNullOrWhiteSpace(txtGiaTien.Text)&&
       !string.IsNullOrWhiteSpace(txtGhiChu.Text))
            {              
                int rowIndex = dgvDV.Rows.Add();            
                dgvDV.Rows[rowIndex].Cells[0].Value = txtMaDV.Text;
                dgvDV.Rows[rowIndex].Cells[1].Value = txtTenDV.Text;
                dgvDV.Rows[rowIndex].Cells[2].Value = txtGiaTien.Text;
                dgvDV.Rows[rowIndex].Cells[2].Value = txtGhiChu.Text;           
                txtGhiChu.Clear();
                txtGiaTien.Clear();
                txtMaDV.Clear();
                txtTenDV.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
