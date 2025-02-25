using eShopSolution.Appplication.Catelog.Products.Dtos;
using eShopSolution.Appplication.Catelog.Products.Dtos.Public;
using eShopSolution.Appplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appplication.Catelog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
