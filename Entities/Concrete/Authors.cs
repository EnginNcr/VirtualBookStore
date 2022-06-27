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
    [Table("Authors")]
    public class Authors : IEntity
    {
        [Key]
        public int AuthorId { get; set; }
        public int BookTypeId { get; set; }
        public string AuthorName { get; set; }
        
    }
}
