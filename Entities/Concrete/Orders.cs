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
    [Table("Orders")]
    public class Orders  : IEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
