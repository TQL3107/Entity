using Entity.A_DAL.Models;
using Entity.B_BUS.Service;
using Entity.B_BUS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity.C_GUI.View
{
    public partial class CarManager : Form
    {
        public int SelectID { get; set; } // 
        public Account AC { get; set; }
        CarServices carService = new CarServices();
        public CarManager()
        {
            InitializeComponent();
        }
        private void CarManager_Load_1(object sender, EventArgs e)
        {
            lb_Username.Text = AC.Username;
        }
        public void LoadToDataGridView(List<Car> list) // hiển thị lên dtg 
        {
            dtg_show.Rows.Clear(); // xoá hết data cũ
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false; // ẩn cột id đi

            dtg_show.Columns[1].Name = "Tên xe";
            dtg_show.Columns[2].Name = "Hãng sản xuất";
            dtg_show.Columns[3].Name = "Giá xe";
            dtg_show.Columns[4].Name = "Số lượng";

            foreach (Car a in list) // mỗi xe trong danh sách thì sẽ thêm 1 dòng trong dtg
            {
                dtg_show.Rows.Add(a.Id, a.Carname, a.Manufactories, a.Price, a.Amount);

            }
        }
        private void btn_showCar_Click_1(object sender, EventArgs e)
        {
            List<Car> allCar = carService.ShowAllCar();
            LoadToDataGridView(allCar);
        }
        private void tbt_Ten_Hang_TextChanged_1(object sender, EventArgs e)
        {
            if (tbt_Ten_Hang.Text.Length > 0)
            {
                lb_checkSreach.Text = ValidateInputData.CheckEmptyString(tbt_Ten_Hang.Text);
                lb_checkSreach.ForeColor = Color.Red;
                lb_checkSreach.Font = new Font(lb_checkSreach.Font, FontStyle.Italic);
            }
            else lb_checkSreach.Text = "";
            List<Car> allCar = carService.SearchCarByNameOrManu(tbt_Ten_Hang.Text);
            LoadToDataGridView(allCar);
        }
        private void tbt_maxPrice_TextChanged_1(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(tbt_minPrice.Text);
            int max = Convert.ToInt32(tbt_maxPrice.Text);
            List<Car> allCar = carService.SearchCarByPriceRange(min, max);
            LoadToDataGridView(allCar);
        }
        private void dtg_show_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbt_TenXe.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tbt_HangXe.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            tbt_GiaXe.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            tbt_SoLuong.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            SelectID = Convert.ToInt32(dtg_show.CurrentRow.Cells[0].Value);
        }
        private void btn_XoaXe_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(carService.DeleteCar(SelectID));
            List<Car> allCar = carService.ShowAllCar();
            LoadToDataGridView(allCar);
        }
        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            string name = tbt_TenXe.Text;
            string hang = tbt_HangXe.Text;
            int gia = Convert.ToInt32(tbt_GiaXe.Text);
            int soluong = Convert.ToInt32(tbt_SoLuong.Text);
            MessageBox.Show(carService.CreateNewCar(name, hang, gia, soluong));
            List<Car> allCar = carService.ShowAllCar();
            LoadToDataGridView(allCar);
        }
        private void btn_SuaXe_Click_1(object sender, EventArgs e)
        {
            int id = SelectID;
            string name = tbt_TenXe.Text;
            string hang = tbt_HangXe.Text;
            int gia = Convert.ToInt32(tbt_GiaXe.Text);
            int soluong = Convert.ToInt32(tbt_SoLuong.Text);
            MessageBox.Show(carService.UpdateCar(id, name, hang, gia, soluong));
            List<Car> allCar = carService.ShowAllCar();
            LoadToDataGridView(allCar);
        }

        private void dtg_show_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lb_checkSreach_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
