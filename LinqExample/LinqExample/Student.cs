using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    public class Student
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
    }
}
