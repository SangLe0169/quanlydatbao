using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlydatbao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-1Q6C5M4\SQLEXPRESS;Initial Catalog=QLDATBAO;Integrated Security=True");
        DataTable tblKHACHHANG,tblPHIEUDATBAO, tblCTDATBAO, tblTAPCHI;
        SqlDataAdapter daPDB, daCTDB, daKH, daTC;
        BindingManagerBase bindPDB, bindCTDB;

        private void cmbSodienthoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbSodienthoai.SelectedIndex;
            if(index>=0)
            {
                txtTenkhachhang.Text = tblKHACHHANG.Rows[index]["TenKH"].ToString();
                txtDiachi.Text = tblKHACHHANG.Rows[index]["DiaChi"].ToString();
            }
            else
            {
                txtTenkhachhang.Text = "";
                txtDiachi.Text = "";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        bool capNhat;
    
        private void Form1_Load(object sender, EventArgs e)
        {
            tblKHACHHANG = new DataTable();
            tblPHIEUDATBAO = new DataTable();
            tblCTDATBAO = new DataTable();
            tblTAPCHI = new DataTable();
            daKH = new SqlDataAdapter("Select * from KHACHHANG",kn);
            daPDB = new SqlDataAdapter("Select * from PHIEUDATBAO", kn);
            daCTDB = new SqlDataAdapter("Select * from CTDATBAO", kn);
            daTC = new SqlDataAdapter("Select * from TAPCHI", kn);
            try
            {
                daKH.Fill(tblKHACHHANG);
                daPDB.Fill(tblPHIEUDATBAO);
                daCTDB.Fill(tblCTDATBAO);
                daTC.Fill(tblTAPCHI);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadDSDT();
            loadCTDATBAO();
            addColCTDATBAO();
            loadDSDATBAO();
            ennableButton();
            bdPDB_PositionChanged(sender, e);
            capNhat = false;

   
            
        }

    
        private void loadDSDT()
        {
            cmbSodienthoai.DataSource = tblKHACHHANG;
            cmbSodienthoai.ValueMember = "MaKH";
            cmbSodienthoai.DisplayMember = "DienThoai";
            cmbSodienthoai.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSodienthoai.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void loadTAPCHI()
        {
            cmbTimtentapchi.DataSource = tblTAPCHI;
            cmbTimtentapchi.ValueMember = "MaTC";
            cmbTimtentapchi.DisplayMember = "TenTC";
            cmbTimtentapchi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbTimtentapchi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTimtentapchi.SelectedIndex = -1;
        }

        private void dgPhieudatbao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgPhieudatbao.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void bdPDB_PositionChanged(object sender, EventArgs e)
        {
            tblCTDATBAO.DefaultView.RowFilter = "SoPhieu='" + txtSophieu.Text + "'";
            int s = 0;
            foreach(DataRowView r in tblCTDATBAO.DefaultView)
            {
                s += int.Parse(r["ThanhTien"].ToString());
            }
            txtTongtien.Text = s.ToString();
        }

        private void addColCTDATBAO()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblTAPCHI, tblCTDATBAO });

            DataRelation qh = new DataRelation("FRK_TAPCHI_CTDATBAO", tblTAPCHI.Columns["MaTC"], tblCTDATBAO.Columns["MaTC"]);
            ds.Relations.Add(qh);

            DataColumn cot_TenTC = new DataColumn("TenTC", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).TenTC");
            DataColumn cot_DonGiaThang = new DataColumn("DonGiaThang", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).DonGiaThang");
            DataColumn cot_ThanhTien = new DataColumn("ThanhTien", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).DonGiaThang*SoLuong*(ThangKT-ThangBD+1)");
            tblCTDATBAO.Columns.Add(cot_TenTC);
            tblCTDATBAO.Columns.Add(cot_DonGiaThang);
            tblCTDATBAO.Columns.Add(cot_ThanhTien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cmbTimtentapchi.SelectedIndex==-1)
            {
                MessageBox.Show("Chưa chọn tạp chí!!");
                return;
            }
            int count = tblCTDATBAO.Select("SoPhieu= '" + txtSophieu.Text + "'and MaTC='" + cmbTimtentapchi.SelectedValue + "'").Count();
            if(count > 0)
            {
                MessageBox.Show("Tạp chí đã tồn tại, chọn tạp chí khác!!");
                return;
            }
            DataRow r = tblCTDATBAO.NewRow();
            r["MaTC"] = cmbTimtentapchi.SelectedValue;
            r["SoPhieu"] = txtSophieu.Text;
            r["SoLuong"] = numSoluong.Value;
            r["ThangBD"] = numThangBD.Value;
            r["ThangKT"] = numThangKT.Value;
            tblCTDATBAO.Rows.Add(r);
            bdPDB_PositionChanged(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = bindCTDB.Position;
            if(index >= 0)
            {
                bindCTDB.RemoveAt(index);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bindCTDB.CancelCurrentEdit();
            tblCTDATBAO.RejectChanges();
            bindCTDB.CancelCurrentEdit();
            tblPHIEUDATBAO.RejectChanges();
            bdPDB_PositionChanged(sender, e);
            capNhat = false;
            ennableButton();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            bindCTDB.AddNew();
            dtNgaydat.Value = DateTime.Now;
            try
            {
                SqlCommand cmm = new SqlCommand("Select dbo.fn_CreateMaPDB()", kn);
                kn.Open();
                txtSophieu.Text = cmm.ExecuteScalar().ToString();
                capNhat = true;
                ennableButton();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            kn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbSodienthoai.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chon khach hang!!");
                return;
            }
            try
            {
                bindPDB.EndCurrentEdit();
                daPDB.Update(tblPHIEUDATBAO);
                tblPHIEUDATBAO.AcceptChanges();

                bindCTDB.EndCurrentEdit();
                daCTDB.Update(tblCTDATBAO);
                tblCTDATBAO.AcceptChanges();
                MessageBox.Show("Cap nhat thanh cong");
                capNhat = false;
                ennableButton();
            }catch(SqlException ex)
            {
                tblCTDATBAO.RejectChanges();
                tblPHIEUDATBAO.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            capNhat = true;
            ennableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = tblCTDATBAO.Select("SoPhieu='" + txtSophieu.Text + "'");
                foreach (DataRow r in rows)
                    r.Delete();
                daCTDB.Update(tblCTDATBAO);
                tblCTDATBAO.AcceptChanges();
                bindPDB.RemoveAt(bindPDB.Position);
                daPDB.Update(tblPHIEUDATBAO);
                tblPHIEUDATBAO.AcceptChanges();
                MessageBox.Show("Xóa thành công");
            }
            catch(SqlException ex)
            {
                tblCTDATBAO.RejectChanges();
                tblPHIEUDATBAO.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadCTDATBAO()
        {
            bindCTDB = this.BindingContext[tblCTDATBAO];
            dgPhieudatbao.AutoGenerateColumns = false;
            dgPhieudatbao.DataSource = tblCTDATBAO;
        }

        private void loadDSDATBAO()
        {
            txtSophieu.DataBindings.Add("text", tblPHIEUDATBAO, "SoPhieu", true);
            dtNgaydat.DataBindings.Add("value", tblPHIEUDATBAO, "NgayDat", true);
            cmbSodienthoai.DataBindings.Add("SelectedValue", tblPHIEUDATBAO, "MaKH", true);
            bindCTDB = this.BindingContext[tblPHIEUDATBAO];


        }
        private void ennableButton()
        {
            btnKhoitao.Enabled = !capNhat;
            btnSửa.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnCancel.Enabled = capNhat;
            btnSave.Enabled = capNhat;
            btnThem.Enabled = capNhat;
            btnDelete.Enabled = capNhat;
            dgPhieudatbao.Enabled = capNhat;
         
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindCTDB.Position < bindCTDB.Count - 1)
                bindCTDB.Position += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindCTDB.Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindCTDB.Position > 0)
                bindCTDB.Position -= 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindCTDB.Position = bindCTDB.Count - 1;
        }
    }
}
