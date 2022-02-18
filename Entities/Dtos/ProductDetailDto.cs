using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    //bu bir veritabanı tablosu olmadığı için IEntity olmaz
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
