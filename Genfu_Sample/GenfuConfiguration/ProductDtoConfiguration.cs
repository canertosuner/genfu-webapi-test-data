using System.Collections.Generic;
using GenFu;
using Genfu_Sample.Dto;

namespace Genfu_Sample.GenfuConfiguration
{
    public class ProductDtoConfiguration
    {
        public ProductDtoConfiguration()
        {
            A.Configure<ProductDto>()
                .Fill(p => p.Price)
                .WithinRange(18, 46)
                .Fill(p => p.Quantity).WithinRange(10, 100);


            A.Configure<ProductDto>()
                .Fill(p => p.ExpireDate)
                .AsFutureDate();


            var codeList = new List<string>() { "TR", "UK", "US", "FR", "GE", "NL" };
            A.Configure<ProductDto>()
                .Fill(p => p.Code).WithRandom(codeList);
        }
    }
}
