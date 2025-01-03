using System.Data.SqlClient;
namespace WinFormsApp1
    
{
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String chuoiketnoi = @"Data Source=WIN-ALRJI68AQDD\ANHQUANG03;Initial Catalog=quanlydongho;Integrated Security=True;Encrypt=False";
        String sql;
        System.Data.SqlClient.SqlConnection ketnoi;
        System.Data.SqlClient.SqlCommand thuchien;
        System.Data.SqlClient.SqlDataReader docdulieu;
        int i = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi = new System.Data.SqlClient.SqlConnection(chuoiketnoi);
            hienthi();

        }
        public void hienthi()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Select Mã_SP, Tên_SP, Giá_Tiền, Số_Lượng, Trạng_thái FROM sanpham";
            thuchien = new System.Data.SqlClient.SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtmasanpham.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txttensanpham.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtgiatien.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtsoluong.Text = listView1.SelectedItems[0].SubItems[3].Text;
            cbotinhtrang.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Danh sách các ô bị bỏ trống
            List<string> missingFields = new List<string>();

            if (string.IsNullOrWhiteSpace(txtmasanpham.Text))
                missingFields.Add("Mã sản phẩm");
            if (string.IsNullOrWhiteSpace(txttensanpham.Text))
                missingFields.Add("Tên sản phẩm");
            if (string.IsNullOrWhiteSpace(txtgiatien.Text))
                missingFields.Add("Giá tiền");
            if (string.IsNullOrWhiteSpace(txtsoluong.Text))
                missingFields.Add("Số lượng");
            if (string.IsNullOrWhiteSpace(cbotinhtrang.Text))
                missingFields.Add("Trạng thái");


            // Nếu có trường bị bỏ trống
            if (missingFields.Count > 0)
            {
                string errorMessage = "Các ô sau không được bỏ trống:\n- " + string.Join("\n- ", missingFields);
                MessageBox.Show(errorMessage, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            listView1.Items.Clear();
            ketnoi.Open();

            // Kiểm tra trùng lặp Mã sản phẩm
            sql = @"SELECT COUNT(*) FROM sanpham WHERE Mã_SP = N'" + txtmasanpham.Text + @"'";
            thuchien = new System.Data.SqlClient.SqlCommand(sql, ketnoi);
            int countMaSP = (int)thuchien.ExecuteScalar();

            // Kiểm tra trùng lặp Tên sản phẩm
            sql = @"SELECT COUNT(*) FROM sanpham WHERE Tên_SP = N'" + txttensanpham.Text + @"'";
            thuchien = new System.Data.SqlClient.SqlCommand(sql, ketnoi);
            int countTenSP = (int)thuchien.ExecuteScalar();

            // Nếu trùng Mã sản phẩm hoặc Tên sản phẩm
            if (countMaSP > 0 || countTenSP > 0)
            {
                string errorMessage = "Dữ liệu bị lặp:\n";
                if (countMaSP > 0)
                    errorMessage += "- Mã sản phẩm đã tồn tại.\n";
                if (countTenSP > 0)
                    errorMessage += "- Tên sản phẩm đã tồn tại.";
                MessageBox.Show(errorMessage, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ketnoi.Close();
                hienthi();
                return; // Thoát khỏi hàm nếu có trùng lặp
                
            }


            sql = @"Insert into sanpham(Mã_SP, Tên_SP, Giá_Tiền, Số_Lượng, Trạng_thái)
Values      ( N'" + txtmasanpham.Text + @"',N'" + txttensanpham.Text + @"',N'" + txtgiatien.Text + @"',N'" + txtsoluong.Text + @"',N'" + cbotinhtrang.Text + @"')";
            thuchien = new System.Data.SqlClient.SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu trạng thái là "Còn hàng" nhưng ô số lượng bị trống
            if (cbotinhtrang.SelectedItem != null && cbotinhtrang.SelectedItem.ToString() == "Còn hàng" && string.IsNullOrWhiteSpace(txtsoluong.Text))
            {
                MessageBox.Show("Ô Số lượng không được để trống khi trạng thái là 'Còn hàng'.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng chương trình để người dùng sửa dữ liệu
            }

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi hàm nếu không có mục nào được chọn
            }




            ketnoi.Open();
            sql = @"Update sanpham SET
                    Mã_SP = N'" + txtmasanpham.Text + @"', Tên_SP = N'" + txttensanpham.Text + @"',
                    Giá_Tiền = N'" + txtgiatien.Text + @"' , Số_Lượng = N'" + txtsoluong.Text + @"',
                    Trạng_thái = N'" + cbotinhtrang.Text + @"'
Where       (Mã_SP = N'" + txtmasanpham.Text + @"')";


            thuchien = new System.Data.SqlClient.SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Delete from sanpham Where (Mã_SP = N'" + txtmasanpham.Text + @"')";
            thuchien = new System.Data.SqlClient.SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void cbotinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra giá trị được chọn
            if (cbotinhtrang.SelectedItem != null && cbotinhtrang.SelectedItem.ToString() == "Hết hàng")
            {
                txtsoluong.Text = "0"; // Đặt số lượng về 0
                txtsoluong.Enabled = false; // Vô hiệu hóa ô nhập số lượng
            }
            else
            {
                txtsoluong.Enabled = true; // Kích hoạt lại ô nhập số lượng
                txtsoluong.Text = ""; // Xóa nội dung ô nhập
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem giá trị của ô số lượng là 0
            if (txtsoluong.Text == "0")
            {
                cbotinhtrang.SelectedItem = "Hết hàng"; // Tự động chọn trạng thái là "Hết hàng"
                txtsoluong.Enabled = false; // Vô hiệu hóa ô số lượng
            }
            else
            {
                if (cbotinhtrang.SelectedItem != null && cbotinhtrang.SelectedItem.ToString() == "Hết hàng")
                {
                    cbotinhtrang.SelectedIndex = -1; // Bỏ chọn trạng thái "Hết hàng"
                }
                txtsoluong.Enabled = true; // Kích hoạt lại ô số lượng
            }
        }
    }
}
