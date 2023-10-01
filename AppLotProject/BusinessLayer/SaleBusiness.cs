using DataAccessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SaleBusiness:ISaleBusiness
    {
        public static ISaleRepository saleRepository;
        public SaleBusiness(ISaleRepository _saleRepository)
        {
            saleRepository = _saleRepository;
        }
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
