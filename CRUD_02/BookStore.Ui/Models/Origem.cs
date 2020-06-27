using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Ui.Models
{
    [Table(nameof(Origem))]
    public class Origem : Entity
    {
        public virtual ICollection<Book> Books { get; set; }
    }
}