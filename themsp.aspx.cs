using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
public partial class Default3 : System.Web.UI.Page
{
    OleDbConnection con;
    OleDbCommand cm; 
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btndangky_Click(object sender, EventArgs e)
    {
     
        if (txtmasp.Text != "")
        {
            if (Txttensp.Text != "")
            {
                if (txtgia.Text != "")
                {

                    //Download source code tại Sharecode.vn
                    con = new OleDbConnection();
                    con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ToString();
                    con.Open();
                    cm = new OleDbCommand("insert into tblsanpham values ('" + txtmasp.Text + "','" + DropDownList1.Text + "','" + Txttensp.Text + "','" + txtgia.Text + "','" + txtsl.Text + "','" + txtdd.Text + "','" + txtbh.Text + "','" + txtkm.Text + "','" + txtkd.Text + "','" + Txtpc.Text + "','" + Txtanh.Text + "','" + Txtghichu.Text + "')", con);
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                    con.Close();
                    Lbltb.Text = "bạn đã  nhập thành công";
                }
                else Lbltb.Text = "bạn chưa nhập giá của sản phẩm";
            }
            else Lbltb.Text = "Bạn chưa nhập tên của sản phẩm";
        }
        else Lbltb.Text = "Bạn phải nhập mã hàng";
    }
}
