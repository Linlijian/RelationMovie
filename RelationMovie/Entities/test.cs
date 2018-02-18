using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RelationMovie.Entities
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int AIdA { get; set; }

        public int AIdA1 { get; set; }

        public int AIdA2 { get; set; }

    }
}