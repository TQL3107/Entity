using Entity.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.A_DAL.Repositories
{
    internal class CarRepos
    {
        _17332_ADOContext context = new _17332_ADOContext();
        public CarRepos()
        {

        }
        public List<Car> GetAllCar() // lấy tất cả xe 
        {
            return context.Cars.ToList(); // lấy danh sách theo tất
        }
        public List<Car> GetCarByNameOrManu(string name_manu) // tìm theo tên và hãng
        {
            var cars = context.Cars.Where(p => p.Carname.Contains(name_manu) || p.Manufactories.Contains(name_manu));
            return cars.ToList();
        }


        public List<Car> GetCarByPriceRange(int minPrice, int maxPrice)//tìm theo khoảng giá
        {
            var cars = context.Cars.Where(p => p.Price >= minPrice && p.Price <= maxPrice);
            return cars.ToList();
        }
        public bool DeleteCar(int ID)
        {
            try
            {
                Car car = context.Cars.SingleOrDefault(a => a.Id == ID);// lấy Car theo id
                context.Cars.Remove(car);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }


        public bool AddCar(string name, string manu, int gia, int amount)
        {
            Car c = new Car();
            c.Carname = name;
            c.Manufactories = manu;
            c.Price = gia;
            c.Amount = amount;
            try
            {
                context.Cars.Add(c);
                context.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;

            }

        }

        public bool EditCar(int id, string name, string manu, int gia, int amount)
        {
            try
            {
                // entity có tính tracking 
                // khi lấy được Car trong DBset thì nếu bạn thay đổi nó => thay đổi luôn trong DBset
                Car car = context.Cars.SingleOrDefault(a => a.Id == id);// lấy Car theo id
                car.Carname = name;
                car.Price = gia;
                car.Manufactories = manu;
                car.Amount = amount;
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool DeleteByName(string name)
        {
            var cars = context.Cars.Where(p => p.Carname == name);
            try
            {
                context.Cars.RemoveRange(cars); // Xoá cả 1 list luôn 
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    
    }
}
