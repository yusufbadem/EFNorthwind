using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwind.Models;
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string? QuantityPerUnit { get; set; }
    public decimal? UnitPrice { get; set; }
    public int? UnitsInStock { get; set; }
    public int? UnitsOnOrders { get; set; }
    public int? ReOrderLevel { get; set; }
    public bool Discontinued { get; set; }
    public int? SupplierId { get; set; }
    [ForeignKey("SupplierId")]
    public Supplier? Supplier { get; set; }
    public int? CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }

}


//Product, Category, Supplier, Employee isimli 4 tabloyu EF Code first ile oluşturacaksınız. 2 gün sonra onun üzerine yeni ödev gelecek. Kolonlar tamamen birebir aynı olacak ( null olmama durumları dahil )
