using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Ui.Models
{
    public class Origem : Entity
    {
        public virtual ICollection<Book> Books { get; set; }
    }
}