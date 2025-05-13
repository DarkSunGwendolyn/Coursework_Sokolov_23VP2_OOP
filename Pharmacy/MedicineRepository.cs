using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace Pharmacy
{
    public class MedicineRepository : IRepository<Medicine>
    {
        private readonly PharmacyDbContext context;
        private readonly BindingList<Medicine> medicines;

        public MedicineRepository(string connectionString)
        {
            context = new PharmacyDbContext(connectionString);
            medicines = new BindingList<Medicine>(context.Medicines.ToList());
        }

        public void Add(Medicine medicine)
        {
            context.Medicines.Add(medicine);
            context.SaveChanges();
            medicines.Add(medicine);
        }

        public void Delete(Medicine medicine)
        {
            medicines.Remove(medicine);
            context.Medicines.Remove(medicine);
            context.SaveChanges();
        }

        public BindingList<Medicine> Filter(decimal lowerBound, decimal upperBound, string param)
        {
            switch (param)
            {
                case "Цена":
                    return new BindingList<Medicine>(medicines.Where(m => m.Price >= lowerBound && m.Price <= upperBound).ToList());
                case "Количество на складе":
                    return new BindingList<Medicine>(medicines.Where(m => m.Quantity >= lowerBound && m.Quantity <= upperBound).ToList());
                default:
                    throw new Exception("Некорректный параметр");
            }
        }
        public BindingList<Medicine> Filter(string compareWord, string param)
        {
            switch (param)
            {
                case "Название":
                    return new BindingList<Medicine>(medicines.Where(m => m.Name.Equals(compareWord, StringComparison.OrdinalIgnoreCase)).ToList());
                case "Болезнь":
                    return new BindingList<Medicine>(medicines.Where(m => m.Disease.Equals(compareWord, StringComparison.OrdinalIgnoreCase)).ToList());
                case "Производитель":
                    return new BindingList<Medicine>(medicines.Where(m => m.Manufacturer.Equals(compareWord, StringComparison.OrdinalIgnoreCase)).ToList());
                default:
                    throw new Exception("Некорректный параметр");
            }
        }

        public BindingList<Medicine> SortIncrease(string param)
        {
            switch (param)
            {
                case "Название":
                    return new BindingList<Medicine>(medicines.OrderBy(m => m.Name, StringComparer.OrdinalIgnoreCase).ToList());
                case "Болезнь":
                    return new BindingList<Medicine>(medicines.OrderBy(m => m.Disease, StringComparer.OrdinalIgnoreCase).ToList());
                case "Цена":
                    return new BindingList<Medicine>(medicines.OrderBy(m => m.Price).ToList());
                case "Количество на складе":
                     return new BindingList<Medicine>(medicines.OrderBy(m => m.Quantity).ToList());
                case "Производитель":
                    return new BindingList<Medicine>(medicines.OrderBy(m => m.Manufacturer, StringComparer.OrdinalIgnoreCase).ToList());
                default:
                    throw new Exception("Некорректный параметр");
            }
        }

        public BindingList<Medicine> SortDecrease(string param)
        {
            switch (param)
            {
                case "Название":
                    return new BindingList<Medicine>(medicines.OrderByDescending(m => m.Name, StringComparer.OrdinalIgnoreCase).ToList());
                case "Болезнь":
                    return new BindingList<Medicine>(medicines.OrderByDescending(m => m.Disease, StringComparer.OrdinalIgnoreCase).ToList());
                case "Цена":
                    return new BindingList<Medicine>(medicines.OrderByDescending(m => m.Price).ToList());
                case "Количество на складе":
                    return new BindingList<Medicine>(medicines.OrderByDescending(m => m.Quantity).ToList());
                case "Производитель":
                    return new BindingList<Medicine>(medicines.OrderByDescending(m => m.Manufacturer, StringComparer.OrdinalIgnoreCase).ToList());
                default:
                    throw new Exception("Некорректный параметр");
            }
        }
        public void Update(Medicine medicine)
        {
            context.Entry(medicine).State = EntityState.Modified;
            context.SaveChanges();
            medicines.ResetBindings();
        }

        public Medicine SearchByName(string name)
        {
            return medicines.FirstOrDefault(m => string.Compare(m.Name, name) == 0);
        }

        public BindingList <Medicine> GetAllMedicine()
        {
            return medicines;
        }
    }
}