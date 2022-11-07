namespace Entity.C_GUI.View
{
    partial class CarManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Username = new System.Windows.Forms.Label();
            this.btn_showCar = new System.Windows.Forms.Button();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.tbt_Ten_Hang = new System.Windows.Forms.TextBox();
            this.tbt_maxPrice = new System.Windows.Forms.TextBox();
            this.tbt_TenXe = new System.Windows.Forms.TextBox();
            this.tbt_HangXe = new System.Windows.Forms.TextBox();
            this.tbt_deleteName = new System.Windows.Forms.TextBox();
            this.tbt_minPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DeleteByName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbt_GiaXe = new System.Windows.Forms.TextBox();
            this.tbt_SoLuong = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_SuaXe = new System.Windows.Forms.Button();
            this.btn_XoaXe = new System.Windows.Forms.Button();
            this.lb_checkSreach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(28, 12);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(50, 20);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "label1";
            // 
            // btn_showCar
            // 
            this.btn_showCar.Location = new System.Drawing.Point(28, 35);
            this.btn_showCar.Name = "btn_showCar";
            this.btn_showCar.Size = new System.Drawing.Size(150, 41);
            this.btn_showCar.TabIndex = 1;
            this.btn_showCar.Text = "Hiện Thị Tất Cả Xe";
            this.btn_showCar.UseVisualStyleBackColor = true;
            this.btn_showCar.Click += new System.EventHandler(this.btn_showCar_Click_1);
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(16, 162);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(551, 518);
            this.dtg_show.TabIndex = 2;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick_1);
            this.dtg_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellContentClick_1);
            // 
            // tbt_Ten_Hang
            // 
            this.tbt_Ten_Hang.Location = new System.Drawing.Point(602, 16);
            this.tbt_Ten_Hang.Name = "tbt_Ten_Hang";
            this.tbt_Ten_Hang.Size = new System.Drawing.Size(436, 27);
            this.tbt_Ten_Hang.TabIndex = 3;
            this.tbt_Ten_Hang.TextChanged += new System.EventHandler(this.tbt_Ten_Hang_TextChanged_1);
            // 
            // tbt_maxPrice
            // 
            this.tbt_maxPrice.Location = new System.Drawing.Point(882, 65);
            this.tbt_maxPrice.Name = "tbt_maxPrice";
            this.tbt_maxPrice.Size = new System.Drawing.Size(156, 27);
            this.tbt_maxPrice.TabIndex = 4;
            this.tbt_maxPrice.TextChanged += new System.EventHandler(this.tbt_maxPrice_TextChanged_1);
            // 
            // tbt_TenXe
            // 
            this.tbt_TenXe.Location = new System.Drawing.Point(602, 200);
            this.tbt_TenXe.Name = "tbt_TenXe";
            this.tbt_TenXe.Size = new System.Drawing.Size(436, 27);
            this.tbt_TenXe.TabIndex = 5;
            // 
            // tbt_HangXe
            // 
            this.tbt_HangXe.Location = new System.Drawing.Point(602, 288);
            this.tbt_HangXe.Name = "tbt_HangXe";
            this.tbt_HangXe.Size = new System.Drawing.Size(436, 27);
            this.tbt_HangXe.TabIndex = 6;
            // 
            // tbt_deleteName
            // 
            this.tbt_deleteName.Location = new System.Drawing.Point(602, 122);
            this.tbt_deleteName.Name = "tbt_deleteName";
            this.tbt_deleteName.Size = new System.Drawing.Size(292, 27);
            this.tbt_deleteName.TabIndex = 7;
            // 
            // tbt_minPrice
            // 
            this.tbt_minPrice.Location = new System.Drawing.Point(602, 64);
            this.tbt_minPrice.Name = "tbt_minPrice";
            this.tbt_minPrice.Size = new System.Drawing.Size(172, 27);
            this.tbt_minPrice.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập giá từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xóa theo tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập tên hoặc hãng xe";
            // 
            // btn_DeleteByName
            // 
            this.btn_DeleteByName.Location = new System.Drawing.Point(930, 120);
            this.btn_DeleteByName.Name = "btn_DeleteByName";
            this.btn_DeleteByName.Size = new System.Drawing.Size(108, 29);
            this.btn_DeleteByName.TabIndex = 13;
            this.btn_DeleteByName.Text = "Xóa Theo Tên";
            this.btn_DeleteByName.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên Xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá Xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(602, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hãng Xe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số Lượng";
            // 
            // tbt_GiaXe
            // 
            this.tbt_GiaXe.Location = new System.Drawing.Point(602, 386);
            this.tbt_GiaXe.Name = "tbt_GiaXe";
            this.tbt_GiaXe.Size = new System.Drawing.Size(436, 27);
            this.tbt_GiaXe.TabIndex = 18;
            // 
            // tbt_SoLuong
            // 
            this.tbt_SoLuong.Location = new System.Drawing.Point(602, 488);
            this.tbt_SoLuong.Name = "tbt_SoLuong";
            this.tbt_SoLuong.Size = new System.Drawing.Size(436, 27);
            this.tbt_SoLuong.TabIndex = 19;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(602, 543);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(436, 29);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Tạo Xe";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // btn_SuaXe
            // 
            this.btn_SuaXe.Location = new System.Drawing.Point(602, 599);
            this.btn_SuaXe.Name = "btn_SuaXe";
            this.btn_SuaXe.Size = new System.Drawing.Size(436, 29);
            this.btn_SuaXe.TabIndex = 21;
            this.btn_SuaXe.Text = "Sửa Thông Tin Xe";
            this.btn_SuaXe.UseVisualStyleBackColor = true;
            this.btn_SuaXe.Click += new System.EventHandler(this.btn_SuaXe_Click_1);
            // 
            // btn_XoaXe
            // 
            this.btn_XoaXe.Location = new System.Drawing.Point(602, 651);
            this.btn_XoaXe.Name = "btn_XoaXe";
            this.btn_XoaXe.Size = new System.Drawing.Size(436, 29);
            this.btn_XoaXe.TabIndex = 22;
            this.btn_XoaXe.Text = "Xóa Xe";
            this.btn_XoaXe.UseVisualStyleBackColor = true;
            this.btn_XoaXe.Click += new System.EventHandler(this.btn_XoaXe_Click_1);
            // 
            // lb_checkSreach
            // 
            this.lb_checkSreach.AutoSize = true;
            this.lb_checkSreach.Location = new System.Drawing.Point(53, 104);
            this.lb_checkSreach.Name = "lb_checkSreach";
            this.lb_checkSreach.Size = new System.Drawing.Size(0, 20);
            this.lb_checkSreach.TabIndex = 23;
            this.lb_checkSreach.TextChanged += new System.EventHandler(this.lb_checkSreach_TextChanged);
            // 
            // CarManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 692);
            this.Controls.Add(this.lb_checkSreach);
            this.Controls.Add(this.btn_XoaXe);
            this.Controls.Add(this.btn_SuaXe);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tbt_SoLuong);
            this.Controls.Add(this.tbt_GiaXe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_DeleteByName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbt_minPrice);
            this.Controls.Add(this.tbt_deleteName);
            this.Controls.Add(this.tbt_HangXe);
            this.Controls.Add(this.tbt_TenXe);
            this.Controls.Add(this.tbt_maxPrice);
            this.Controls.Add(this.tbt_Ten_Hang);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.btn_showCar);
            this.Controls.Add(this.lb_Username);
            this.Name = "CarManager";
            this.Text = "CarManager";
            this.Load += new System.EventHandler(this.CarManager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Username;
        private Button btn_showCar;
        private DataGridView dtg_show;
        private TextBox tbt_Ten_Hang;
        private TextBox tbt_maxPrice;
        private TextBox tbt_TenXe;
        private TextBox tbt_HangXe;
        private TextBox tbt_deleteName;
        private TextBox tbt_minPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_DeleteByName;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbt_GiaXe;
        private TextBox tbt_SoLuong;
        private Button btn_Them;
        private Button btn_SuaXe;
        private Button btn_XoaXe;
        private Label lb_checkSreach;
    }
}