namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbotinhtrang = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            txtsoluong = new TextBox();
            label4 = new Label();
            txtgiatien = new TextBox();
            label3 = new Label();
            txttensanpham = new TextBox();
            txtmasanpham = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbotinhtrang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtgiatien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txttensanpham);
            groupBox1.Controls.Add(txtmasanpham);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(41, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin sản phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbotinhtrang
            // 
            cbotinhtrang.FormattingEnabled = true;
            cbotinhtrang.Items.AddRange(new object[] { "Còn hàng", "Hết hàng" });
            cbotinhtrang.Location = new Point(629, 63);
            cbotinhtrang.Name = "cbotinhtrang";
            cbotinhtrang.Size = new Size(133, 31);
            cbotinhtrang.TabIndex = 10;
            cbotinhtrang.SelectedIndexChanged += cbotinhtrang_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(25, 164);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên Sản phẩm";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(534, 66);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 9;
            label5.Text = "Trạng thái";
            label5.Click += label5_Click;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(389, 157);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(125, 30);
            txtsoluong.TabIndex = 8;
            txtsoluong.TextChanged += txtsoluong_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(303, 164);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 7;
            label4.Text = "Số lượng";
            label4.Click += label4_Click;
            // 
            // txtgiatien
            // 
            txtgiatien.Location = new Point(389, 60);
            txtgiatien.Name = "txtgiatien";
            txtgiatien.Size = new Size(125, 30);
            txtgiatien.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(303, 67);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 5;
            label3.Text = "Giá tiền";
            label3.Click += label3_Click;
            // 
            // txttensanpham
            // 
            txttensanpham.Location = new Point(151, 157);
            txttensanpham.Name = "txttensanpham";
            txttensanpham.Size = new Size(125, 30);
            txttensanpham.TabIndex = 4;
            // 
            // txtmasanpham
            // 
            txtmasanpham.Location = new Point(151, 60);
            txtmasanpham.Name = "txtmasanpham";
            txtmasanpham.Size = new Size(125, 30);
            txtmasanpham.TabIndex = 2;
            txtmasanpham.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 71);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã SP";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(41, 280);
            button1.Name = "button1";
            button1.Size = new Size(162, 64);
            button1.TabIndex = 3;
            button1.Text = "Thêm sản phẩm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.Location = new Point(242, 280);
            button2.Name = "button2";
            button2.Size = new Size(157, 64);
            button2.TabIndex = 5;
            button2.Text = "Sửa sản phẩm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.Location = new Point(447, 280);
            button3.Name = "button3";
            button3.Size = new Size(166, 64);
            button3.TabIndex = 6;
            button3.Text = "Xóa sản phẩm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button4.Location = new Point(648, 280);
            button4.Name = "button4";
            button4.Size = new Size(173, 64);
            button4.TabIndex = 7;
            button4.Text = "Thoát chương trình";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(41, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 340);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết sản phẩm";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(11, 50);
            listView1.Name = "listView1";
            listView1.Size = new Size(751, 275);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            listView1.Click += listView1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã SP";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Sản Phẩm";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giá tiền";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Trạng Thái";
            columnHeader5.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 731);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Phần mềm quản lý đồng hồ";
            Load += Form1_Load;
            Click += Form1_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtmasanpham;
        private Button button1;
        private Label label5;
        private TextBox txtsoluong;
        private Label label4;
        private TextBox txtgiatien;
        private Label label3;
        private TextBox txttensanpham;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private ComboBox cbotinhtrang;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
