using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Ui.Models
{
    public class Entity
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"),StringLength(100)]
        public string Nome { get; set; }
    }
}