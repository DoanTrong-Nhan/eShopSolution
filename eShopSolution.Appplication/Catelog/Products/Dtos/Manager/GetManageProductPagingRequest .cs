using eShopSolution.Appplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Appplication.Catelog.Products.Dtos
{
    public class GetManagerProductPagingRequest : PagingRequestBase 
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
