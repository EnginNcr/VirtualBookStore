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
    [Table("Books")]
    public class Books:IEntity
    {
        [Key]
        public int BookId { get; set; }
        public int BookTypeId { get; set; }
        public int AuthorId { get; set; }
        public string BookName { get; set; }
        public decimal UnitsPrice { get; set; }
        public int StockAmount { get; set; }

    }
}
