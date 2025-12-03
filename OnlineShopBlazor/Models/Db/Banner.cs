using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopBlazor.Models.Db;

[Table("Banner")]
public partial class Banner
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [StringLength(1000)]
    public string? SubTitle { get; set; }

    [StringLength(50)]
    public string? ImageName { get; set; }

    public short? Priority { get; set; }

    [StringLength(100)]
    public string? Link { get; set; }

    [StringLength(50)]
    public string? Position { get; set; }
}
