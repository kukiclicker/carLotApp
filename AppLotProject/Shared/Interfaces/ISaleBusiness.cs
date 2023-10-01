using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface ISaleBusiness
    {
        List<Sale> GetAllSales();
        int InsertSale(Sale sale);
        int UpdateSale(Sale sale);
        int DeleteSale(int saleID);
    }
}
