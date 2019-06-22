using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLGV
{

    
    public partial class Form_Toan : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QuanLyGiaoVien;Integrated Security=True");

        public Form_Toan()
        {
            InitializeComponent();
        }

        DateTime TachNam2(string NamHoc)
        {
            DateTime date;
            string str = "";
            for(int i=NamHoc.Length-1;i>0;i--)
            {
                if (NamHoc[i] != '-')
                    str = NamHoc[i] + str;
                else break;
            }
            str = str + "-10-28";
            date = Convert.ToDateTime(str);

            return date;
        }
        DateTime TachNam1(string NamHoc)
        {
            DateTime date;
            string str = "";
            for (int i = 0; i<NamHoc.Length ; i++)
            {
                if (NamHoc[i] != '-') str = str + NamHoc[i];
                else break;
            }
            str = str + "-10-28";
            date = Convert.ToDateTime(str);

            return date;
        }
        void LoadDsGv(string TenDv,string NamHoc)
        {
            DataTable dt = new DataTable();
            
            try 
            {
                DateTime dt1 = TachNam1(NamHoc);
                DateTime dt2 = TachNam2(NamHoc);
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query="select *from dbo.DS_GV(@Tendv,@date1,@date2)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TenDv", TenDv);
                command.Parameters.AddWithValue("@date1", dt1);
                command.Parameters.AddWithValue("@date2",dt2);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                dtgv_DSGV.DataSource = dt;

            }
            catch
            {

            }
        }
        void Load_ThongKeNckh(string magv,string Namhoc)
        {
            DataTable dt = new DataTable();
            DataTable gv = new DataTable();
            DateTime dt1 = TachNam1(Namhoc);
            DateTime dt2 = TachNam2(Namhoc);
            try
            {
               
                string query = "dbo.ThongKe_NC @Magv,@date1,@date2";

                if (conn.State == ConnectionState.Closed) conn.Open();
             
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Magv", magv);
                command.Parameters.AddWithValue("@date1", dt1);
                command.Parameters.AddWithValue("@date2", dt2);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["TENBAI"] = "Tổng số";
                int sum = 0;
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    sum = Convert.ToInt32(dt.Rows[i]["GIOCHUAN"].ToString()) + sum;
                }
                row["GIOCHUAN"] = sum.ToString();
                dt.Rows.Add(row);
                dtgv_Nckh.DataSource = dt;

                if (conn.State == ConnectionState.Closed) conn.Open();
                query = "select *from dbo.GV_CB(@Magv,@date1,@date2)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Magv", magv);
                cmd.Parameters.AddWithValue("@date1", dt1);
                cmd.Parameters.AddWithValue("@date2", dt2);
                SqlDataAdapter da_gv = new SqlDataAdapter(cmd);
                DataTable dt_gv = new DataTable();
                da_gv.Fill(dt_gv);
                txt_TenGiaoVien.Text = dt_gv.Rows[0]["TenGv"].ToString();
                txt_CapBac.Text= dt_gv.Rows[0]["CapBac"].ToString();




            }
            catch
            {

            }

                }
        private void Form_Toan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable tb_mgv = new DataTable();
            conn.Open();
            SqlDataAdapter da;
            da= new SqlDataAdapter("Select *from DONVI order by TenDonVi desc", conn);
            da.Fill(dt);
            conn.Close();
            cb_DonVi.ValueMember = "MaDonVi";
            cb_DonVi.DisplayMember = "TenDonVi";
            cb_DonVi.DataSource = dt;
         
            for (int i=2014;i<2019;i++)
            {
                string str = "";
                str = i.ToString() + "-" + (i + 1).ToString();
                cb_NamHoc.Items.Add(str);
               
                cb2_NamHoc.Items.Add(str);
              

            }
            cb_NamHoc.SelectedIndex = 0;
            cb2_NamHoc.SelectedIndex = 0;
            LoadDsGv(cb_DonVi.Text.ToString(), cb_NamHoc.Text.ToString());
            if (conn.State == ConnectionState.Closed) conn.Open();
            da = new SqlDataAdapter("Select *from GIAOVIEN order by MaGiaoVien", conn);
            da.Fill(tb_mgv);
            conn.Close();
            txt_TenGiaoVien.Enabled = false;
            txt_CapBac.Enabled = false;
            cb2_Magv.ValueMember = "MaGiaoVien";
            cb2_Magv.DisplayMember = "MaGiaoVien";
  
            cb2_Magv.DataSource = tb_mgv;
            Load_ThongKeNckh(cb2_Magv.Text, cb2_NamHoc.Text);

        }

        private void cb_DonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDsGv(cb_DonVi.Text, cb_NamHoc.Text);
        }

        private void cb_NamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDsGv(cb_DonVi.Text, cb_NamHoc.Text);
        }

        private void cb2_Magv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ThongKeNckh(cb2_Magv.Text, cb2_NamHoc.Text);
        }

        private void cb2_NamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ThongKeNckh(cb2_Magv.Text, cb2_NamHoc.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        int rowindex;
        private void dtgv_DSGV_MouseClick(object sender, MouseEventArgs e)
        {

             rowindex = dtgv_DSGV.HitTest(e.X, e.Y).RowIndex;
            if(e.Button==MouseButtons.Right)
            {   
                if(rowindex!=-1)
                
                contextMenuStrip1.Show(dtgv_DSGV,new Point(e.X, e.Y));
            }

        }

        private void tảiNCKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            string Magv = "";
            string NamHoc = "";
            Magv = dtgv_DSGV.Rows[rowindex].Cells[0].Value.ToString().Trim();
            NamHoc = cb_NamHoc.Text;
            Load_ThongKeNckh(Magv, NamHoc);

        }
    }
}
