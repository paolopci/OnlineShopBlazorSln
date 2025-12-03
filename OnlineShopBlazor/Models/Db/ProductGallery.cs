using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopBlazor.Models.Db;

[Table("ProductGallery")]
public partial class ProductGallery
{
    [Key]
    public int Id { get; set; }

    public int? ProductId { get; set; }

    [StringLength(50)]
    public string? ImageName { get; set; }
}
