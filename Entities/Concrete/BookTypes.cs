using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("BookTypes")]
    public class BookTypes : IEntity
    {
        [Key]
        public int BookTypeId { get; set; }
        public string BookType { get; set; }
    }
}
