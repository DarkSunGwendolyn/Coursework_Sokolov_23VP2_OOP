using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class MedicineService
    {
        private readonly MedicineRepository repos;

        public MedicineService(string connectionString)
        {
            repos = new MedicineRepository(connectionString);
        }

        public void AddMedicine(string name, decimal price, string disease, int quantity, string manufacturer)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(manufacturer) || string.IsNullOrEmpty(disease)) throw new ArgumentException("Заполните все поля");
            if (price < 0) throw new Exception("Цена не может быть отрицательной");
            if (quantity < 0) throw new Exception("Количество на складе не может быть отрицательным");
            Medicine medicine = new Medicine(name, price, disease, quantity, manufacturer);
            if (repos.SearchByName(name) != null) throw new Exception("Лекарство с таким названием уже есть в базе");
            repos.Add(medicine);
        }

        public void DeleteMedicine(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new Exception("Введите название лекарства, которое хотите удалить");
            Medicine medicine = repos.SearchByName(name);
            if (medicine == null) throw new Exception("Записи с таким названием не существует");
            repos.Delete(medicine);
        }

        public void UpdateMedicine(string name, string disease,decimal? price, int? quantity, string manufacturer)
        {
            Medicine medicine = repos.SearchByName(name);
            if (medicine == null) throw new Exception("Записи  с таким названием не существует");
            if (string.IsNullOrEmpty(disease)) throw new Exception("Введите название болезни");
            medicine.Disease = disease;
            if (!price.HasValue || price < 0) throw new Exception("Введите корректную цену");
            medicine.Price = price.Value;

            if (!quantity.HasValue || quantity < 0) 
                throw new Exception("Введите корректное количество на складе");
            medicine.Quantity = quantity.Value;

            if (string.IsNullOrEmpty(disease)) 
                throw new Exception("Введите производителя");
            medicine.Manufacturer = manufacturer;
            repos.Update(medicine);
        }

        public BindingList<Medicine> SortedIncreaseMedicine(string param)
        {
            BindingList<Medicine> records = repos.GetAllMedicine();
            if (records.Count == 0) throw new Exception("База данных пуста");
            return repos.SortIncrease(param);
        }

        public BindingList<Medicine> SortedDecreaseMedicine(string param)
        {
            BindingList<Medicine> records = repos.GetAllMedicine();
            if (records.Count == 0) throw new Exception("База данных пуста");
            return repos.SortDecrease(param);
        }

        public BindingList<Medicine> FiltredMedicine(decimal lowerBound, decimal upperBound, string param)
        {
            if (lowerBound >= upperBound) throw new Exception("Неккоректный ввод");
            BindingList<Medicine> records = repos.GetAllMedicine();
            if (records.Count == 0) throw new Exception("База данных пуста");
            BindingList<Medicine> result = repos.Filter(lowerBound, upperBound, param);
            if (result.Count == 0) throw new Exception("По заданному фильтру записи не найдены");
            return result;
        }
        public BindingList<Medicine> FiltredMedicine(string compareWord, string param)
        {
            BindingList<Medicine> records = repos.GetAllMedicine();
            if (records.Count == 0) throw new Exception("База данных пуста");
            BindingList<Medicine> result = repos.Filter(compareWord, param);
            if (result.Count == 0) throw new Exception("По заданному фильтру записи не найдены");
            return result;
        }

        public BindingList<Medicine> GetAllMedicines()
        {
            return repos.GetAllMedicine();
        }

        public Medicine FindByName(string name)
        {
            Medicine medicine =  repos.SearchByName(name);
            if (string.IsNullOrEmpty(name)) throw new Exception("Введите название записи, которую хотите найти");
            if (medicine == null) throw new Exception("Запись не найдена");
            return medicine;
        }
    }
}
