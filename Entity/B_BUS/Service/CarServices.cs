using Entity.A_DAL.Models;
using Entity.A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.B_BUS.Service
{
    internal class CarServices
    {
        CarRepos cr = new CarRepos();
        public List<Car> ShowAllCar()
        {
            return cr.GetAllCar();
        }
        public List<Car> SearchCarByNameOrManu(string s)
        {
            return cr.GetCarByNameOrManu(s);
        }
        public List<Car> SearchCarByPriceRange(int minPrice, int maxPrice)
        {
            return cr.GetCarByPriceRange(minPrice, maxPrice);
        }
        public string DeleteCar(int id)
        {
            if (cr.DeleteCar(id)) return "Xoá xe thành công";
            else return "Xoá xe thất bại";
        }
        public string CreateNewCar(string name, string manu, int price, int amount)
        {
            if (cr.AddCar(name, manu, price, amount))
            {
                return "Thêm mới thành công";
            }
            else return "Thêm mới thất bại";
        }
        public string UpdateCar(int id, string name, string manu, int price, int amount)
        {
            if (cr.EditCar(id, name, manu, price, amount))
            {
                return "Update thành công";
            }
            else return "Update thất bại";
        }
        public string DeleteByName(string name)
        {

            if (cr.DeleteByName(name))
            {
                return "Xoá xe thành công";
            }
            else return "Xoá xe thất bại ";
        }

    }
}
