using DataAccessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SaleBusiness
    {
        public static SaleRepository saleRepository = new SaleRepository();
        public List<Sale> GetAllSales()
        {
            return saleRepository.GetAllSales();
        }
        public int DeleteSale(int saleID)
        {
            return saleRepository.DeleteSale(saleID);
        }
        public int InsertSale(Sale sale)
        {
            return saleRepository.InsertSale(sale);
        }
        public int UpdateSale(Sale sale)
        {
            return saleRepository.UpdateSale(sale);
        }
    }
}
