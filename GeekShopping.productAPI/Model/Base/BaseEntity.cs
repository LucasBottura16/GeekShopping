﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.productAPI.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
