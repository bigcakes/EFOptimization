using EFOptimization.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFOptimization.Models.DTO
{
  public partial class ProductListModel
  {
    public int ProductID { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Column(TypeName = "money")]
    public decimal ListPrice { get; set; }

    public int InventoryCount { get; set; }

    public ProductListModel()
    {
    }
  }
}