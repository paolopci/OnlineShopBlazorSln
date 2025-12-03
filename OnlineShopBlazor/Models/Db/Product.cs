using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopBlazor.Models.Db;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(4000)]
    public string? FullDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    [StringLength(50)]
    public string? ImageName { get; set; }

    public int? Qty { get; set; }

    [StringLength(1000)]
    public string? Tags { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VideoUrl { get; set; }
}
