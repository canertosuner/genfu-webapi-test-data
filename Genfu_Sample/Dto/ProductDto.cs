using System;

namespace Genfu_Sample.Dto
{
public class ProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime ExpireDate { get; set; }
    public string Code { get; set; }
}
}
